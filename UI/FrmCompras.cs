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
    public partial class FrmCompras : Form
    {
        #region Inicializacion y Variables

        private DataTable dtDatos;
        private DataTable dtCompraActual;
        private DataLayer.Models.ViProductoPresentacionUnidad productoSeleccionado;
        private DataLayer.Models.ViProductoPresentacionUnidad productoCarritoSeleccionado;
        private List<DataLayer.ComboboxItem> cmbBoxProveedoresItems;
        private DataLayer.Models.ViProveedor proveedorSeleccionado;
        private List<DataLayer.Models.ViProveedor> proveedores;
        private List<DataLayer.ComboboxItem> cmbBoxAlmacenesItems;
        private DataLayer.Models.ViAlmacen almacenSeleccionado;
        private List<DataLayer.Models.ViAlmacen> almacenes;
        private decimal total;

        private bool loading;
        public FrmCompras()
        {
            InitializeComponent();
            this.cmbBoxProveedoresItems = new List<DataLayer.ComboboxItem>();
            this.cmbBoxAlmacenesItems = new List<DataLayer.ComboboxItem>();
        }

        private async void FrmCompras_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.

            List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.listar();
            CreateDataSource(productos);

            tbBuscar.Select();

            //cargar proveedores
            proveedores = await DataLayer.Tasks.Proveedor.listar();

            cmbProveedores.Items.Clear();
            cmbProveedores.Items.Add("Seleccione un proveedor...");

            foreach (DataLayer.Models.ViProveedor proveedor in proveedores)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = proveedor.id_entidad,
                    Text = proveedor.nombre
                };
                cmbProveedores.Items.Add(cmbBoxItem);
                this.cmbBoxProveedoresItems.Add(cmbBoxItem);
            }

            cmbProveedores.SelectedIndex = 0;

            //cargar almacenes
            almacenes = await DataLayer.Tasks.Almacen.listar();

            cmbAlmacenDestino.Items.Clear();
            cmbAlmacenDestino.Items.Add("Seleccione un almacen...");

            foreach (DataLayer.Models.ViAlmacen almacen in almacenes)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = almacen.id_almacen,
                    Text = almacen.descripcion
                };
                cmbAlmacenDestino.Items.Add(cmbBoxItem);
                this.cmbBoxAlmacenesItems.Add(cmbBoxItem);
            }

            cmbAlmacenDestino.SelectedIndex = 0;
        }
        #endregion

        #region Botones y Controles

        private void bAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarProductoAlCarrito();
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(dgvCompraActual.SelectedRows[0].Cells[8].Value) <= tbCantidad.Value)
            {
                foreach (DataRow row in dtCompraActual.Rows)
                {
                    if (Convert.ToInt32(row[0]) == productoCarritoSeleccionado.id_producto)
                    {
                        row.Delete();
                        break;
                    }
                }
            }
            else
            {
                foreach (DataRow row in dtCompraActual.Rows)
                {
                    if (Convert.ToInt32(row[0]) == productoCarritoSeleccionado.id_producto)
                    {
                        row["cantidad"] = Convert.ToInt32(row["cantidad"]) - tbCantidad.Value;
                        break;
                    }
                }
            }
            this.CalcularTotal();
        }

        private async void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvProductos.SelectedRows.Count == 1)
            {
                int idProductoSeleccionado = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value);
                this.productoSeleccionado = await DataLayer.Tasks.Producto.seleccionarPresentacionUnidad(idProductoSeleccionado);
                bAgregar.Enabled = true;
                bQuitar.Enabled = false;
                this.dgvCompraActual.ClearSelection();
                tbCantidad.Value = 1;
                tbPrecio.Enabled = true;
                tbPrecio.Value = this.productoSeleccionado.precio_compra;
            }
        }

        private async void dgvCompraActual_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvCompraActual.SelectedRows.Count == 1)
            {
                int idProductoSeleccionado = Convert.ToInt32(dgvCompraActual.SelectedRows[0].Cells[0].Value);
                this.productoCarritoSeleccionado = await DataLayer.Tasks.Producto.seleccionarPresentacionUnidad(idProductoSeleccionado);
                bQuitar.Enabled = true;
                bAgregar.Enabled = false;
                tbPrecio.Enabled = false;
                this.dgvProductos.ClearSelection();
                tbCantidad.Value = Convert.ToInt32(dgvCompraActual.SelectedRows[0].Cells[8].Value);
            }
        }

        private async void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!loading && tbBuscar.Text != String.Empty)
            {
                bReestablecer.Enabled = true;
                List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.buscar(tbBuscar.Text);
                if (productos.Count > 0)
                    CreateDataSource(productos);
                else
                {
                    dgvProductos.DataSource = null;
                }
            }
        }

        private async void bReestablecer_Click(object sender, EventArgs e)
        {
            tbBuscar.Text = String.Empty;
            List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.listar();
            CreateDataSource(productos);

            tbBuscar.Select();
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            int numProductos = 0;
            //insertar compra
            DataLayer.Models.Compra compra = new DataLayer.Models.Compra()
            {
                id_usuario = Sesion.id_entidad,
                id_proveedor = proveedorSeleccionado.id_entidad,
                monto_total = this.total,
                fecha = DateTime.Now,
                usuario_registro = "dev"
            };

            DataLayer.Models.ViCompra _compra = await DataLayer.Tasks.Compra.insertar(compra);
            //iterar linea por linea del dgvProductosCompra
            foreach (DataRow row in dtCompraActual.Rows)
            {
                int id_producto = Convert.ToInt32(row[2].ToString());
                int cantidad = Convert.ToInt32(row[8].ToString());
                decimal precio_compra = Convert.ToDecimal(row[5].ToString());
                //por cada linea:
                // - buscar si el id_producto está en producto_almacen
                DataLayer.Models.ViProductoAlmacen productoAlmacen = await DataLayer.Tasks.ProductoAlmacen.seleccionarProducto(id_producto); //id_producto

                // - SI esta: hacer un update, aumentar el stock
                if (productoAlmacen.id_producto != -1)
                {
                    DataLayer.Models.ProductoAlmacen _productoAlmacen = new DataLayer.Models.ProductoAlmacen()
                    {
                        id_producto = productoAlmacen.id_producto,
                        id_almacen = almacenSeleccionado.id_almacen, // TODOOO no esta seleccionando el almacen
                        stock_actual = productoAlmacen.stock_actual + cantidad, 
                        usuario_registro = Sesion.login_usuario
                    };
                    int statusCode = await DataLayer.Tasks.ProductoAlmacen.actualizar(_productoAlmacen, productoAlmacen.id_producto_almacen);
                }
                // - NO esta: registrar nueva entrada.
                else
                {
                    DataLayer.Models.ProductoAlmacen _productoAlmacen = new DataLayer.Models.ProductoAlmacen()
                    {
                        id_producto = id_producto, 
                        id_almacen = almacenSeleccionado.id_almacen,
                        stock_actual = cantidad, 
                        usuario_registro = Sesion.login_usuario
                    };
                    int statusCode = await DataLayer.Tasks.ProductoAlmacen.insertar(_productoAlmacen);
                }

                //registrar detalle_entrada
                DataLayer.Models.DetalleEntrada detalleEntrada = new DataLayer.Models.DetalleEntrada()
                {
                    id_compra = _compra.id_compra,
                    id_producto = id_producto,
                    cantidad = cantidad,
                    precio_unidad = precio_compra,
                    usuario_registro = Sesion.login_usuario
                };
                int status = await DataLayer.Tasks.DetalleEntrada.insertar(detalleEntrada);
                numProductos++;
            }
            MessageBox.Show("Compra registrada.\nSe registraron " + numProductos.ToString() + " producto(s).", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtCompraActual.Clear();
            dgvCompraActual.Refresh();
            CalcularTotal();
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbProveedores.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxProveedoresItems[cmbProveedores.SelectedIndex - 1];
                foreach (DataLayer.Models.ViProveedor proveedor in this.proveedores)
                    if (proveedor.id_entidad == selectedItem.ID)
                        this.proveedorSeleccionado = proveedor;
                if (cmbAlmacenDestino.SelectedIndex > 0 && dtCompraActual.Rows.Count > 0)
                    bGuardar.Enabled = true;
            }
            else if (cmbProveedores.SelectedIndex == 0)
            {
                bGuardar.Enabled = false;
                this.proveedorSeleccionado = new DataLayer.Models.ViProveedor();
            }
        }

        private void cmbAlmacenDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbAlmacenDestino.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxAlmacenesItems[cmbAlmacenDestino.SelectedIndex - 1];
                foreach (DataLayer.Models.ViAlmacen almacen in this.almacenes)
                    if (almacen.id_almacen == selectedItem.ID)
                        this.almacenSeleccionado = almacen;
                if(cmbProveedores.SelectedIndex > 0 && dtCompraActual.Rows.Count > 0)
                    bGuardar.Enabled = true;
            }
            else if (cmbProveedores.SelectedIndex == 0)
            {
                bGuardar.Enabled = false;
                this.almacenSeleccionado = new DataLayer.Models.ViAlmacen();
            }

        }
        
        private void tbCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbBuscar.Text != String.Empty && dgvProductos.SelectedRows.Count == 1)
            {
                AgregarProductoAlCarrito();
            }
        }
        #endregion

        #region Métodos de Apoyo
        private void CreateDataSource(List<DataLayer.Models.ViProductoPresentacionUnidad> productos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);

            if(dtCompraActual == null)
            {
                //DT de productos en el carrito.
                dtCompraActual = dtDatos.Clone();
                dtCompraActual.Columns.Add("cantidad");
                dtCompraActual.Columns.Remove("precio_venta");
                dtCompraActual.Columns.Remove("multiplicador_kg");
            }

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
            dtDatos.Columns["presentacion"].SetOrdinal(6);
            dtDatos.Columns["unidades"].SetOrdinal(7);
            dtDatos.Columns.Remove("precio_venta");
            dtDatos.Columns.Remove("multiplicador_kg");
            dgvProductos.DataSource = dtDatos;
            dgvProductos.Columns[3].HeaderText = "Nombre Producto";
            dgvProductos.Columns[4].HeaderText = "Código";
            dgvProductos.Columns[5].HeaderText = "Precio (Bs)";
            dgvProductos.Columns[6].HeaderText = "Presentación";
            dgvProductos.Columns[7].HeaderText = "Unidades";
            dgvProductos.Columns[0].Width = 0;
            dgvProductos.Columns[1].Width = 0;
            dgvProductos.Columns[2].Width = 0;
            dgvProductos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvProductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Refresh();
            dgvProductos.ClearSelection();


            dgvCompraActual.DataSource = dtCompraActual;
            dgvCompraActual.Columns[3].HeaderText = "Nombre Producto";
            dgvCompraActual.Columns[4].HeaderText = "Código";
            dgvCompraActual.Columns[5].HeaderText = "Precio (Bs)";
            dgvCompraActual.Columns[6].HeaderText = "Presentación";
            dgvCompraActual.Columns[7].HeaderText = "Unidades";
            dgvCompraActual.Columns[0].Width = 0;
            dgvCompraActual.Columns[1].Width = 0;
            dgvCompraActual.Columns[2].Width = 0;
            dgvCompraActual.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompraActual.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompraActual.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompraActual.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompraActual.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompraActual.Refresh();
            dgvCompraActual.ClearSelection();

            this.loading = false;
        }
        
        private void CalcularTotal()
        {
            this.total = 0;
            foreach (DataRow row in dtCompraActual.Rows)
            {
                //multiplicar cantidad por precio-compra
                this.total += (Convert.ToDecimal(row[8]) * Convert.ToDecimal(row[5]));
            }
            lblTotal.Text = "Total: " + total.ToString() + " Bs.";
        }

        private void AgregarProductoAlCarrito()
        {
            bool inCart = false;
            foreach (DataRow row in dtCompraActual.Rows)
            {
                if (Convert.ToInt32(row[0]) == productoSeleccionado.id_producto)
                {
                    row["cantidad"] = Convert.ToInt32(row["cantidad"]) + tbCantidad.Value;
                    inCart = true;
                }
            }

            if (!inCart)
                dtCompraActual.Rows.Add
                    (
                    productoSeleccionado.id_producto,
                    productoSeleccionado.id_presentacion_producto,
                    productoSeleccionado.id_unidad_presentacion,
                    productoSeleccionado.nombre,
                    productoSeleccionado.codigo,
                    tbPrecio.Value,
                    productoSeleccionado.presentacion,
                    productoSeleccionado.unidades,
                    tbCantidad.Value
                    );
            this.loading = true;
            dgvCompraActual.DataSource = dtCompraActual;
            dgvCompraActual.Refresh();
            this.loading = false;
            this.CalcularTotal();
        }
        #endregion
    }
}
