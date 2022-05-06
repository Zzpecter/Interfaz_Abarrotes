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
        private List<DataLayer.Models.ViProductoCompra> productosCompra;
        private List<DataLayer.ComboboxItem> cmbBoxProveedoresItems;
        private DataLayer.Models.ViProveedor proveedorSeleccionado;
        private List<DataLayer.Models.ViProveedor> proveedores;
        private List<DataLayer.ComboboxItem> cmbBoxAlmacenesItems;
        private DataLayer.Models.ViAlmacen almacenSeleccionado;
        private List<DataLayer.Models.ViAlmacen> almacenes;
        private decimal total;

        private DateTime _lastKeystroke = new DateTime(0);
        private List<char> _barcode = new List<char>();

        private bool loading;
        public FrmCompras()
        {
            InitializeComponent();
            this.proveedorSeleccionado = new DataLayer.Models.ViProveedor() { id_entidad = -1 };
            this.almacenSeleccionado = new DataLayer.Models.ViAlmacen() { id_almacen = -1 };
            this.cmbBoxProveedoresItems = new List<DataLayer.ComboboxItem>();
            this.cmbBoxAlmacenesItems = new List<DataLayer.ComboboxItem>();
            this.productosCompra = new List<DataLayer.Models.ViProductoCompra>();
        }

        private async void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarAlmacenes();
            CargarProveedores();
            this.tbBarcode.Select();
        }
        #endregion

        #region Botones y Controles

        private async void FrmCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // borrar barcode si hay intermitencia de mas de 100 ms
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();

            // agregar tecla y marca de tiempo
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            // procesar el codigo de barras
            if (e.KeyChar == 13 && _barcode.Count > 4)
            {
                string barcode = new String(_barcode.ToArray());
                barcode = barcode.Remove(barcode.Length - 1);
                barcode = barcode.Remove(barcode.Length - 1);
                List<DataLayer.Models.ViProductoEnAlmacen> productos = await DataLayer.Tasks.ProductoAlmacen.buscarProductoEnAlmacen(barcode);

                if (productos.Count > 0)
                {
                    this.productoSeleccionado = productos[0];
                    //Mostrar detalles
                    this.tbNombreProducto.Text = productoSeleccionado.nombre;
                    this.tbPresentacion.Text = productoSeleccionado.presentacion;
                    this.tbUnidades.Text = productoSeleccionado.unidades;
                    this.tbPrecioCompra.Value = productoSeleccionado.precio_compra;

                    bAgregar.Enabled = true;
                }
                _barcode.Clear();
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bool IsMouse = (e is MouseEventArgs);
            if (IsMouse)
            {
                //Mostrar FrmBuscarProductos, que devuelva el producto seleccionado
                FrmCompactProductoBuscar frm = new FrmCompactProductoBuscar();
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.productoSeleccionado = frm.productoSeleccionado;

                    tbNombreProducto.Text = this.productoSeleccionado.nombre;
                    tbPresentacion.Text = this.productoSeleccionado.presentacion;
                    tbUnidades.Text = this.productoSeleccionado.unidades;
                    tbPrecioCompra.Value = this.productoSeleccionado.precio_compra;

                    bAgregar.Enabled = true;
                }
            }
        }

        private void bNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmCompactProductoCrear frm = new FrmCompactProductoCrear();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.productoSeleccionado = frm.nuevoProducto;

                tbNombreProducto.Text = this.productoSeleccionado.nombre;
                tbPresentacion.Text = this.productoSeleccionado.presentacion;
                tbUnidades.Text = this.productoSeleccionado.unidades;
                tbPrecioCompra.Value = this.productoSeleccionado.precio_compra;

                bAgregar.Enabled = true;
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            FrmSelectorCantidad frm = new FrmSelectorCantidad(this.productoSeleccionado.permite_cantidad_fraccionada);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataLayer.Models.ViProductoCompra producto_compra = new DataLayer.Models.ViProductoCompra()
                {
                    id_producto = this.productoSeleccionado.id_producto,
                    id_presentacion_producto = this.productoSeleccionado.id_presentacion_producto,
                    id_unidad_presentacion = this.productoSeleccionado.id_unidad_presentacion,
                    nombre = this.productoSeleccionado.nombre,
                    codigo = this.productoSeleccionado.codigo,
                    precio_compra = this.productoSeleccionado.precio_compra,
                    precio_venta = this.productoSeleccionado.precio_venta,
                    presentacion = this.productoSeleccionado.presentacion,
                    permite_cantidad_fraccionada = this.productoSeleccionado.permite_cantidad_fraccionada,
                    unidades = this.productoSeleccionado.unidades,
                    multiplicador_kg = this.productoSeleccionado.multiplicador_kg,
                    cantidad = frm.cantidad,
                    sub_total = frm.cantidad * this.productoSeleccionado.precio_compra
                };
                this.productosCompra.Add(producto_compra);
                CreateDataSource(productosCompra);

                bAgregar.Enabled = false;
                this.productoSeleccionado = new DataLayer.Models.ViProductoEnAlmacen() { id_producto = -1 };
                tbNombreProducto.Text = String.Empty;
                tbPresentacion.Text = String.Empty;
                tbUnidades.Text = String.Empty;
                tbPrecioCompra.Value = tbPrecioCompra.Minimum;
            }
        }

        private void bEditarAlmacenes_Click(object sender, EventArgs e)
        {
            FrmCompactAlmacenInsertar frm = new FrmCompactAlmacenInsertar();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
                CargarAlmacenes();
        }

        private void bEditarProveedores_Click(object sender, EventArgs e)
        {
            FrmCompactProveedorInsertar frm = new FrmCompactProveedorInsertar();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
                CargarProveedores();
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
                usuario_registro = Sesion.login_usuario
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
            dgvCompra.Refresh();
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbProveedores.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxProveedoresItems[cmbProveedores.SelectedIndex - 1];
                foreach (DataLayer.Models.ViProveedor proveedor in this.proveedores)
                    if (proveedor.id_entidad == selectedItem.ID)
                        this.proveedorSeleccionado = proveedor;
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
            }
        }
        #endregion

        #region Métodos de Apoyo
        private void CreateDataSource(List<DataLayer.Models.ViProductoCompra> productos)
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
            dtDatos.Columns.Remove("id_presentacion_producto");
            dtDatos.Columns.Remove("id_unidad_presentacion");
            dtDatos.Columns.Remove("multiplicador_kg");
            dtDatos.Columns.Remove("precio_venta");
            dtDatos.Columns.Remove("permite_cantidad_fraccionada");
            dtDatos.Columns["id_producto"].SetOrdinal(0);
            dtDatos.Columns["nombre"].SetOrdinal(1);
            dtDatos.Columns["codigo"].SetOrdinal(2);
            dtDatos.Columns["precio_compra"].SetOrdinal(3);
            dtDatos.Columns["presentacion"].SetOrdinal(4);
            dtDatos.Columns["unidades"].SetOrdinal(5);
            dtDatos.Columns["cantidad"].SetOrdinal(6);
            dtDatos.Columns["sub_total"].SetOrdinal(7);
            dgvCompra.DataSource = dtDatos;
            dgvCompra.Columns[1].HeaderText = "Nombre Producto";
            dgvCompra.Columns[2].HeaderText = "Código";
            dgvCompra.Columns[3].HeaderText = "Precio Compra (Bs)";
            dgvCompra.Columns[4].HeaderText = "Presentación";
            dgvCompra.Columns[5].HeaderText = "Unidades";
            dgvCompra.Columns[6].HeaderText = "Cantidad";
            dgvCompra.Columns[7].HeaderText = "Sub-Total";
            dgvCompra.Columns[0].Width = 0;
            dgvCompra.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompra.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompra.Refresh();
            dgvCompra.ClearSelection();
            this.loading = false;

            foreach (DataGridViewRow linea in dgvCompra.Rows)
            {
                total += Convert.ToDecimal(linea.Cells[7].Value);
            }

            lblTotal.Text = "Total: " + total.ToString() + " Bs.";
        }

        private async void CargarAlmacenes()
        {
            loading = true;
            almacenes = await DataLayer.Tasks.Almacen.listar();

            cmbAlmacenDestino.Items.Clear();
            cmbAlmacenDestino.Items.Add("Seleccione un almacén...");

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
            loading = false;
        }

        private async void CargarProveedores()
        {
            loading = true;
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
            loading = false;
        }
        #endregion
    }
}
