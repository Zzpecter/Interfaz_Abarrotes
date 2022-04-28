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

    //TODO metodo con timer para determinar si el input es de un barcode scanner
    // si se hace un input con barcode scanner hacer una busqueda de producto
    //TODO controlar la tecla ENTER en tbNITCI, cuando se aprete seleccionar cliente por CI

    public partial class FrmVentas : Form
    {
        #region Variables e Inicializacion
        private DataLayer.Models.ViCliente clienteSeleccionado;
        private DataLayer.Models.ViProductoEnAlmacen productoSeleccionado;
        private List<DataLayer.Models.ViProductoVenta> productosVenta;

        private DataTable dtVenta;
        private bool loading;
        private Decimal total;

        private DateTime _lastKeystroke = new DateTime(0);
        private List<char> _barcode = new List<char>();
        List<TimeSpan> keySpans = new List<TimeSpan>();
        public FrmVentas()
        {
            InitializeComponent();
            this.clienteSeleccionado = new DataLayer.Models.ViCliente() { id_entidad = -1};
            this.productosVenta = new List<DataLayer.Models.ViProductoVenta>();
        }

        private async void FrmVentas_Load(object sender, EventArgs e)
        {
            this.tbBarcode.Select();
        }
        #endregion 

        #region Botones y Controles
        private async void FrmVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // borrar barcode si hay intermitencia de mas de 100 ms
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            keySpans.Add(elapsed);
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

                if ( productos.Count > 0)
                {
                    this.productoSeleccionado = productos[0];
                    //Mostrar detalles
                    this.tbNombreProducto.Text = productoSeleccionado.nombre;
                    this.tbPresentacion.Text = productoSeleccionado.presentacion;
                    this.tbUnidades.Text = productoSeleccionado.unidades;
                    this.tbPrecioVenta.Value = productoSeleccionado.precio_venta;

                    bAgregar.Enabled = true;
                }
                _barcode.Clear();
            }
        }

        private async void tbNitCi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbNitCi.Text != String.Empty)
            {
                this.clienteSeleccionado = await DataLayer.Tasks.Cliente.seleccionarPorNit(tbNitCi.Text);
                if (this.clienteSeleccionado.id_entidad == -1)
                {
                    if (MessageBox.Show("Cliente no encontrado! Desea registrar un nuevo cliente?", "Cliente no encontrado", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        crearCliente();
                }
                else
                {
                    tbNombreCliente.Text = this.clienteSeleccionado.razon_social;
                    tbNitCi.ReadOnly = true;
                    tbNitCi.Enabled = false;
                }
            }
        }

        private void bNuevoCliente_Click(object sender, EventArgs e)
        {
            crearCliente();
        }
        #endregion


        #region Métodos Auxiliares
        private async void crearCliente()
        {
            //Mostrar el FrmCompactClienteInsertar
            //Que retorne un objeto de tipo ViCliente
            FrmCompactClienteInsertar frm = new FrmCompactClienteInsertar();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.clienteSeleccionado = frm.viCliente;

                tbNombreCliente.Text = this.clienteSeleccionado.razon_social;
                tbNitCi.ReadOnly = true;
                tbNitCi.Enabled = false;
            }
        }
        #endregion

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            //Controlar si el cliente fue insertado/actualizado y la info de los TB es correcta.
            if (!tbNombreCliente.ReadOnly)
            {
                //TODO insertar/actualizar
            }
            int numProductos = 0;

            //insertar salida_producto para el id
            DataLayer.Models.SalidaProducto nuevaSalida = await DataLayer.Tasks.SalidaProducto.insertar();

            //TODO: Implementar codigo para generar datos de la factura
            DataLayer.Models.Factura factura = new DataLayer.Models.Factura()
            {
                codigo_control = "N/A",
                datos_codigo_QR = "Sistema no Implementado",
                usuario_registro = Sesion.login_usuario
            };

            DataLayer.Models.Factura _factura = await DataLayer.Tasks.Factura.insertar(factura);

            //insertar venta
            DataLayer.Models.Venta venta = new DataLayer.Models.Venta()
            {
                id_salida_producto = nuevaSalida.id_salida_producto,
                id_usuario = Sesion.id_entidad,
                id_cliente = clienteSeleccionado.id_entidad,
                id_factura = _factura.id_factura,
                monto_total = this.total,
                fecha = DateTime.Now,
                usuario_registro = Sesion.login_usuario
            };
            DataLayer.Models.ViVenta _venta = await DataLayer.Tasks.Venta.insertar(venta);

            //iterar linea por linea del dgvVenta
            foreach (DataRow row in dtVenta.Rows)
            {
                int id_producto = Convert.ToInt32(row[0].ToString());
                int cantidad = Convert.ToInt32(row[6].ToString());
                decimal precio_venta = Convert.ToDecimal(row[3].ToString());

                //por cada linea:
                // actualizar el stock
                DataLayer.Models.ViProductoAlmacen _productoAlmacen = await DataLayer.Tasks.ProductoAlmacen.seleccionarProducto(id_producto);

                decimal stock_restante = _productoAlmacen.stock_actual - cantidad;
                if (stock_restante < 0)
                    stock_restante = 0;

                DataLayer.Models.ProductoAlmacen productoAlmacenActualizado = new DataLayer.Models.ProductoAlmacen()
                {
                    id_producto = id_producto,
                    id_almacen = _productoAlmacen.id_almacen,
                    stock_actual = stock_restante,
                    usuario_registro = Sesion.login_usuario
                };
                int statusCode = await DataLayer.Tasks.ProductoAlmacen.actualizar(productoAlmacenActualizado, _productoAlmacen.id_producto_almacen);
                

                //registrar detalle_salida
                DataLayer.Models.DetalleSalida detalleSalida = new DataLayer.Models.DetalleSalida()
                {
                    id_salida_producto = nuevaSalida.id_salida_producto,
                    id_producto = id_producto,
                    cantidad = cantidad,
                    precio_unidad = precio_venta,
                    usuario_registro = Sesion.login_usuario
                };
                int status = await DataLayer.Tasks.DetalleSalida.insertar(detalleSalida);
                numProductos++;
            }
            MessageBox.Show("Venta registrada.\nSe registraron " + numProductos.ToString() + " producto(s).", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bGuardar.Enabled = false;
            dtVenta.Clear();
            dgvVenta.Refresh();
            CalcularTotal();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bool IsMouse = (e is System.Windows.Forms.MouseEventArgs);
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
                    tbPrecioVenta.Value = this.productoSeleccionado.precio_venta;

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
                tbPrecioVenta.Value = this.productoSeleccionado.precio_venta;

                bAgregar.Enabled = true;
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            FrmSelectorCantidad frm = new FrmSelectorCantidad(this.productoSeleccionado.permite_cantidad_fraccionada);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataLayer.Models.ViProductoVenta producto_venta = new DataLayer.Models.ViProductoVenta()
                {
                    id_producto = this.productoSeleccionado.id_producto,
                    id_almacen = this.productoSeleccionado.id_almacen,
                    id_presentacion_producto = this.productoSeleccionado.id_presentacion_producto,
                    id_unidad_presentacion = this.productoSeleccionado.id_unidad_presentacion,
                    nombre = this.productoSeleccionado.nombre,
                    codigo = this.productoSeleccionado.codigo,
                    precio_compra = this.productoSeleccionado.precio_compra,
                    precio_venta = this.productoSeleccionado.precio_venta,
                    presentacion = this.productoSeleccionado.presentacion,
                    unidades = this.productoSeleccionado.unidades,
                    multiplicador_kg = this.productoSeleccionado.multiplicador_kg,
                    cantidad = frm.cantidad,
                    sub_total = frm.cantidad * this.productoSeleccionado.precio_venta
                };
                this.productosVenta.Add(producto_venta);
                CreateDataSource(productosVenta);

                bAgregar.Enabled = false;
                this.productoSeleccionado = new DataLayer.Models.ViProductoEnAlmacen() { id_producto = -1 };
                tbNombreProducto.Text = String.Empty;
                tbPresentacion.Text = String.Empty;
                tbUnidades.Text = String.Empty;
                tbPrecioVenta.Value = tbPrecioVenta.Minimum;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViProductoVenta> productos)
        {
            dtVenta = new DataTable();
            dtVenta.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtVenta.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < productos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(productos[i]);
                DataRow _tempRow = dtVenta.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtVenta.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtVenta.Columns.Remove("id_presentacion_producto");
            dtVenta.Columns.Remove("id_unidad_presentacion");
            dtVenta.Columns.Remove("id_almacen");
            dtVenta.Columns.Remove("multiplicador_kg");
            dtVenta.Columns.Remove("precio_compra");
            dtVenta.Columns.Remove("almacen");
            dtVenta.Columns.Remove("permite_cantidad_fraccionada");
            dtVenta.Columns["id_producto"].SetOrdinal(0);
            dtVenta.Columns["nombre"].SetOrdinal(1);
            dtVenta.Columns["codigo"].SetOrdinal(2);
            dtVenta.Columns["precio_venta"].SetOrdinal(3);
            dtVenta.Columns["presentacion"].SetOrdinal(4);
            dtVenta.Columns["unidades"].SetOrdinal(5);
            dtVenta.Columns["cantidad"].SetOrdinal(6);
            dtVenta.Columns["sub_total"].SetOrdinal(7);
            dgvVenta.DataSource = dtVenta;
            dgvVenta.Columns[1].HeaderText = "Nombre Producto";
            dgvVenta.Columns[2].HeaderText = "Código";
            dgvVenta.Columns[3].HeaderText = "Precio Venta (Bs)";
            dgvVenta.Columns[4].HeaderText = "Presentación";
            dgvVenta.Columns[5].HeaderText = "Unidades";
            dgvVenta.Columns[6].HeaderText = "Cantidad";
            dgvVenta.Columns[7].HeaderText = "Sub-Total";
            dgvVenta.Columns[0].Width = 0;
            dgvVenta.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVenta.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVenta.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvVenta.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvVenta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvVenta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVenta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVenta.Refresh();
            dgvVenta.ClearSelection();
            this.loading = false;

            foreach(DataGridViewRow linea in dgvVenta.Rows )
            {
                total += Convert.ToDecimal(linea.Cells[7].Value);
            }

            lblTotal.Text = "Total: " + total.ToString() + " Bs.";  
        }

        private void CalcularTotal()
        {
            this.total = 0;
            foreach (DataRow row in dtVenta.Rows)
            {
                this.total += Convert.ToDecimal(row[7]);
            }
            lblTotal.Text = "Total: " + total.ToString() + " Bs.";
        }
    }
}
