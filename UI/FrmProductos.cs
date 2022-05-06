using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmProductos : Form
    {
        #region Inicializacion y Variables

        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViProducto productoSeleccionado;
        List<DataLayer.Models.ViPresentacionUnidad> presentaciones;
        private List<DataLayer.ComboboxItem> cmbBoxUnidadesItems;
        DataLayer.Models.ViPresentacionProducto presentacionSeleccionada;
        private bool loading;
        public FrmProductos()
        {
            InitializeComponent();
            cmbBoxUnidadesItems = new List<DataLayer.ComboboxItem>();
        }

        private async void FrmProductos_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.listar();
            CreateDataSource(productos);

            presentaciones = await DataLayer.Tasks.PresentacionProducto.listar();  // listar las presentaciones para el cmbBox


            cmbPresentaciones.Items.Clear();
            cmbPresentaciones.Items.Add("Seleccione una presentacion...");

            foreach (DataLayer.Models.ViPresentacionUnidad presentacion in presentaciones)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = presentacion.id_presentacion_producto,
                    Text = presentacion.nombre_presentacion + " - " + presentacion.nombre_medida
                };
                cmbPresentaciones.Items.Add(cmbBoxItem);
                this.cmbBoxUnidadesItems.Add(cmbBoxItem);
            }
        }
        #endregion

        #region Botones y Controles

        private void bAgregar_Click(object sender, EventArgs e)
        {
            formState = "agregar";
            ChangeState();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            formState = "actualizar";
            ChangeState();
        }

        private async void bElimiar_Click(object sender, EventArgs e)
        {
            // TODO si hay registros de este producto en algun almacen, no eliminar
            if (dgvDatos.SelectedRows.Count == 1)
            {
                DataLayer.Models.ViProductoAlmacen productoAlmacen = await DataLayer.Tasks.ProductoAlmacen.seleccionarProducto(this.productoSeleccionado.id_producto);
                if (productoAlmacen.id_producto_almacen == -1)
                {
                    int statusCode = await DataLayer.Tasks.Producto.eliminar(productoSeleccionado.id_producto);
                    if (statusCode == 200)
                        RefreshData();
                }
                else
                    MessageBox.Show(DataLayer.Globals.MSJ_PRODUCTO_EN_ALMACEN, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            bool cumpleCondiciones;
            cumpleCondiciones = true;
            // chekeamos que nada este vacío o en un indice invalido
            if (tbNombreProducto.Text == String.Empty || tbCodigoProducto.Text == String.Empty || cmbPresentaciones.SelectedIndex == 0 || tbPrecioVenta.Value == decimal.Zero)
                cumpleCondiciones = false;

            switch (formState)
            {
                case "agregar":
                    if (cumpleCondiciones)
                    {
                        //Crear e insertar el producto
                        DataLayer.Models.Producto producto = new DataLayer.Models.Producto()
                        {
                            id_presentacion_producto = presentacionSeleccionada.id_presentacion_producto,
                            nombre = tbNombreProducto.Text,
                            codigo = tbCodigoProducto.Text,
                            precio_compra = tbPrecioCompra.Value,
                            precio_venta = tbPrecioVenta.Value,
                            usuario_registro = Sesion.login_usuario
                        };
                        DataLayer.Models.Producto productoInsertado = await DataLayer.Tasks.Producto.insertar(producto);

                        RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese todos los valores necesarios antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (cumpleCondiciones)
                    {
                        DataLayer.Models.Producto producto = new DataLayer.Models.Producto()
                        {
                            id_presentacion_producto = presentacionSeleccionada.id_presentacion_producto,
                            nombre = tbNombreProducto.Text,
                            codigo = tbCodigoProducto.Text,
                            precio_compra = tbPrecioCompra.Value,
                            precio_venta = tbPrecioVenta.Value,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Producto.actualizar(producto, productoSeleccionado.id_producto);

                        if (statusCode == 200)
                            RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese todos los valores necesarios antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvDatos.SelectedRows.Count == 1)
            {
                int idProductoSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                this.productoSeleccionado = await DataLayer.Tasks.Producto.seleccionar(idProductoSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombreProducto.Text = productoSeleccionado.nombre;
                tbCodigoProducto.Text = productoSeleccionado.codigo;
                tbPrecioCompra.Value = productoSeleccionado.precio_compra;
                tbPrecioVenta.Value = productoSeleccionado.precio_venta;

                //seleccionar el ComboBox segun la presentacion
                this.presentacionSeleccionada = await DataLayer.Tasks.PresentacionProducto.seleccionar(productoSeleccionado.id_presentacion_producto);
                int i = 1;
                foreach (DataLayer.ComboboxItem item in cmbBoxUnidadesItems)
                {
                    if (presentacionSeleccionada.id_presentacion_producto == item.ID)
                        cmbPresentaciones.SelectedIndex = i;
                    i++;
                }
            }
        }

        private void cmbPresentaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbPresentaciones.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxUnidadesItems[cmbPresentaciones.SelectedIndex - 1];
                foreach (DataLayer.Models.ViPresentacionProducto presentacion in this.presentaciones)
                    if (presentacion.id_presentacion_producto == selectedItem.ID)
                        this.presentacionSeleccionada = presentacion;
            }
            else if (cmbPresentaciones.SelectedIndex == 0)
                this.presentacionSeleccionada = new DataLayer.Models.ViPresentacionProducto();
        }

        private async void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if(!loading && tbBuscar.Text != String.Empty)
            {
                bReestablecer.Enabled = true;
                List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.buscar(tbBuscar.Text);
                if (productos.Count > 0)
                    CreateDataSource(productos);
                else
                {
                    dgvDatos.DataSource = null;
                }
            }
        }

        private void bReestablecer_Click(object sender, EventArgs e)
        {
            tbBuscar.Text = String.Empty;
            RefreshData();
        }
        #endregion

        #region Métodos de Apoyo
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombreProducto.Enabled = false;
                    tbCodigoProducto.Enabled = false;
                    tbPrecioCompra.Enabled = false;
                    tbPrecioVenta.Enabled = false;
                    cmbPresentaciones.Enabled = false;
                    tbBuscar.Enabled = true;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarPresentaciones.Enabled = false;

                    dgvDatos.ReadOnly = false;
                    dgvDatos.ClearSelection();
                    break;
                case "agregar":
                    tbNombreProducto.Enabled = true;
                    tbCodigoProducto.Enabled = true;
                    tbPrecioCompra.Enabled = true;
                    tbPrecioVenta.Enabled = true;
                    cmbPresentaciones.Enabled = true;
                    tbNombreProducto.Text = String.Empty;
                    tbCodigoProducto.Text = String.Empty;
                    tbPrecioCompra.Value = decimal.One;
                    tbPrecioVenta.Value = decimal.One;
                    cmbPresentaciones.SelectedIndex = 0;
                    tbBuscar.Enabled = false;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarPresentaciones.Enabled = false;

                    dgvDatos.ClearSelection();
                    dgvDatos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombreProducto.Enabled = true;
                    tbCodigoProducto.Enabled = true;
                    tbPrecioCompra.Enabled = true;
                    tbPrecioVenta.Enabled = true;
                    cmbPresentaciones.Enabled = true;
                    tbBuscar.Enabled = false;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarPresentaciones.Enabled = false;

                    dgvDatos.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViProductoPresentacionUnidad> productos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < productos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_producto"].SetOrdinal(0);
            dtDatos.Columns["id_presentacion_producto"].SetOrdinal(1);
            dtDatos.Columns["id_unidad_presentacion"].SetOrdinal(2);
            dtDatos.Columns["nombre"].SetOrdinal(3);
            dtDatos.Columns["codigo"].SetOrdinal(4);
            dtDatos.Columns["precio_compra"].SetOrdinal(5);
            dtDatos.Columns["precio_venta"].SetOrdinal(6);
            dtDatos.Columns["presentacion"].SetOrdinal(7);
            dtDatos.Columns["unidades"].SetOrdinal(8);
            dtDatos.Columns["multiplicador_kg"].SetOrdinal(9);
            dgvDatos.DataSource = dtDatos;
            dgvDatos.Columns[3].HeaderText = "Nombre Producto";
            dgvDatos.Columns[4].HeaderText = "Código";
            dgvDatos.Columns[5].HeaderText = "Precio Compra (Bs)";
            dgvDatos.Columns[6].HeaderText = "Precio Venta (Bs)";
            dgvDatos.Columns[7].HeaderText = "Presentación";
            dgvDatos.Columns[8].HeaderText = "Unidades";
            dgvDatos.Columns[9].HeaderText = "Multiplicador Kg.";
            dgvDatos.Columns[0].Width = 0;
            dgvDatos.Columns[1].Width = 0;
            dgvDatos.Columns[2].Width = 0;
            dgvDatos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDatos.Refresh();
            dgvDatos.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.listar();
            CreateDataSource(productos);
        }


        #endregion

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
