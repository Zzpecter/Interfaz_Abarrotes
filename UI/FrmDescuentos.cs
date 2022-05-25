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
    public partial class FrmDescuentos : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViDescuentoProducto descuentoSeleccionado;
        public DataLayer.Models.ViProductoEnAlmacen productoSeleccionado;
        private List<DataLayer.Models.ViDescuentoProducto> descuentos;
        private bool loading;

        public FrmDescuentos()
        {
            InitializeComponent();
        }

        private async void FrmDescuentos_Load(object sender, EventArgs e)
        {
            this.descuentos = await DataLayer.Tasks.Descuento.listar();
            this.descuentoSeleccionado = new DataLayer.Models.ViDescuentoProducto() { id_descuento = -1 };
            CreateDataSource();
        }
        #endregion

        #region Botones y Controles
        private void bAgregar_Click(object sender, EventArgs e)
        {
            //Mostrar FrmBuscarProductos, que devuelva el producto seleccionado
            FrmCompactProductoBuscar frm = new FrmCompactProductoBuscar();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.productoSeleccionado = frm.productoSeleccionado;
                formState = "agregar";
                ChangeState();
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            formState = "actualizar";
            ChangeState();
        }

        private async void bElimiar_Click(object sender, EventArgs e)
        {
            if (dgvDescuentos.SelectedRows.Count == 1)
            {
                int statusCode = await DataLayer.Tasks.Descuento.eliminar(descuentoSeleccionado.id_descuento);

                if (statusCode == 200)
                    RefreshData();
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case "agregar":
                    if (tbPrecioOferta.Value > 0 && dtpFechaFinalizacion.Value > DateTime.Now)
                    {
                        //Crear e insertar el descuento
                        DataLayer.Models.Descuento descuento = new DataLayer.Models.Descuento()
                        {
                            id_producto = productoSeleccionado.id_producto,
                            precio_oferta = tbPrecioOferta.Value,
                            fecha_expiracion = dtpFechaFinalizacion.Value,
                            usuario_registro = Sesion.login_usuario
                        };
                        DataLayer.Models.Descuento _descuento = await DataLayer.Tasks.Descuento.insertar(descuento);

                        RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Precio o Fecha Inválidos!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbPrecioOferta.Value > 0 && dtpFechaFinalizacion.Value > DateTime.Now)
                    {
                        DataLayer.Models.Descuento descuento = new DataLayer.Models.Descuento()
                        {
                            id_producto = descuentoSeleccionado.id_producto,
                            precio_oferta = tbPrecioOferta.Value,
                            fecha_expiracion = dtpFechaFinalizacion.Value,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Descuento.actualizar(descuento, descuentoSeleccionado.id_descuento);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Precio o Fecha Inválidos!", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private async void dgvDescuentos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvDescuentos.SelectedRows.Count == 1)
            {
                int idDescuentoSeleccionado = Convert.ToInt32(dgvDescuentos.SelectedRows[0].Cells[0].Value);
                this.descuentoSeleccionado = await DataLayer.Tasks.Descuento.seleccionar(idDescuentoSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbPrecioOferta.Value = descuentoSeleccionado.precio_oferta;
                dtpFechaFinalizacion.Value = descuentoSeleccionado.fecha_expiracion;
            }
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbPrecioOferta.Enabled = false;
                    dtpFechaFinalizacion.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDescuentos.ReadOnly = false;
                    dgvDescuentos.ClearSelection();
                    break;
                case "agregar":
                    lblProducto.Text = this.productoSeleccionado.nombre + " " + this.productoSeleccionado.presentacion + " " + this.productoSeleccionado.unidades;
                    tbPrecioOferta.Value = this.productoSeleccionado.precio_venta;
                    dtpFechaFinalizacion.Value = DateTime.Now + TimeSpan.FromDays(1);

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDescuentos.ClearSelection();
                    dgvDescuentos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbPrecioOferta.Enabled = true;
                    dtpFechaFinalizacion.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDescuentos.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource()
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.descuentos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < this.descuentos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.descuentos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_descuento"].SetOrdinal(0);
            dtDatos.Columns.Remove("id_producto");
            dtDatos.Columns.Remove("id_presentacion_producto");
            dtDatos.Columns.Remove("id_unidad_presentacion");
            dtDatos.Columns.Remove("codigo");
            dtDatos.Columns["nombre"].SetOrdinal(1);
            dtDatos.Columns["presentacion"].SetOrdinal(2);
            dtDatos.Columns["unidades"].SetOrdinal(3);
            dtDatos.Columns["precio_compra"].SetOrdinal(4);
            dtDatos.Columns["precio_venta_original"].SetOrdinal(5);
            dtDatos.Columns["precio_oferta"].SetOrdinal(6);
            dtDatos.Columns["fecha_expiracion"].SetOrdinal(7);

            dgvDescuentos.DataSource = dtDatos;
            dgvDescuentos.Columns[0].HeaderText = "ID";
            dgvDescuentos.Columns[1].HeaderText = "Producto";
            dgvDescuentos.Columns[2].HeaderText = "Presentacion";
            dgvDescuentos.Columns[3].HeaderText = "Unidades";
            dgvDescuentos.Columns[4].HeaderText = "Precio Compra";
            dgvDescuentos.Columns[5].HeaderText = "Precio Venta";
            dgvDescuentos.Columns[6].HeaderText = "Precio Oferta";
            dgvDescuentos.Columns[7].HeaderText = "Fecha Finalizacion";
            dgvDescuentos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDescuentos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDescuentos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDescuentos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvDescuentos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDescuentos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDescuentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDescuentos.Columns[0].Width = 0;
            dgvDescuentos.Refresh();
            dgvDescuentos.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            this.descuentos = await DataLayer.Tasks.Descuento.listar();
            CreateDataSource();
        }
        #endregion


    }
}
