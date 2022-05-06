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
    public partial class FrmCompactDisposicionInsertar : Form
    {
        private List<DataLayer.Models.ViMotivo> motivos;
        private DataLayer.Models.ViMotivo motivoSeleccionado;
        private List<DataLayer.ComboboxItem> cmbBoxMotivosItems;

        private DateTime _lastKeystroke = new DateTime(0);
        private List<char> _barcode = new List<char>();
        private DataLayer.Models.ViProductoEnAlmacen productoSeleccionado;

        private bool loading;

        public FrmCompactDisposicionInsertar()
        {
            InitializeComponent();
            motivos = new List<DataLayer.Models.ViMotivo>();
            cmbBoxMotivosItems = new List<DataLayer.ComboboxItem>();
            productoSeleccionado = new DataLayer.Models.ViProductoEnAlmacen() { id_producto = -1};
        }

        private async void FrmCompactDisposicionInsertar_Load(object sender, EventArgs e)
        {
            loading = true;
            motivos = await DataLayer.Tasks.Motivo.listar();

            cmbMotivos.Items.Clear();
            cmbMotivos.Items.Add("Seleccione un motivo...");

            foreach (DataLayer.Models.ViMotivo motivo in motivos)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = motivo.id_motivo,
                    Text = motivo.descripcion_motivo
                };
                cmbMotivos.Items.Add(cmbBoxItem);
                this.cmbBoxMotivosItems.Add(cmbBoxItem);
            }

            cmbMotivos.SelectedIndex = 0;
            cmbMotivos.Enabled = false;

            loading = false;
        }

        private async void FrmCompactDisposicionInsertar_KeyPress(object sender, KeyPressEventArgs e)
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
                    this.tbCodigoProducto.Text = productoSeleccionado.codigo;
                    this.tbPresentacion.Text = productoSeleccionado.presentacion;
                    this.tbUnidades.Text = productoSeleccionado.unidades;

                    gbInfoDisposicion.Enabled = true;
                    tbCantidad.Maximum = this.productoSeleccionado.stock_actual;
                }
                _barcode.Clear();
            }
        }

        private void cbEliminarStock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminarStock.Checked)
                tbCantidad.Value = this.productoSeleccionado.stock_actual;
            else
                tbCantidad.Value = 1;
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
                    tbCodigoProducto.Text = this.productoSeleccionado.codigo;

                    gbInfoDisposicion.Enabled = true;
                    cmbMotivos.Enabled = true;
                    bEditarMotivos.Enabled = true;
                    tbComentario.ReadOnly = false;
                    tbCantidad.Maximum = this.productoSeleccionado.stock_actual;
                }
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            //Checkear que todos los campos esten llenados correctamente
            bool error = false;
            string errorCaption = "Error! Detalles:\n";

            if(this.productoSeleccionado.id_producto == -1)
            {
                error = true;
                errorCaption += "Producto seleccionado es inválido";
            }
            if(!error && cmbMotivos.SelectedIndex == 0)
            {
                error = true;
                errorCaption += "Motivo seleccionado es inválido";
            }

            
            if (!error)
            {
                //Actualizar el stock en producto_almacen
                DataLayer.Models.ViProductoAlmacen productoAlmacen = await DataLayer.Tasks.ProductoAlmacen.seleccionarProducto(this.productoSeleccionado.id_producto);

                productoAlmacen.stock_actual -= tbCantidad.Value;
                if (productoAlmacen.stock_actual < 0)
                    productoAlmacen.stock_actual = 0;

                DataLayer.Models.ProductoAlmacen productoAlmacenUpd = new DataLayer.Models.ProductoAlmacen() 
                {
                    id_almacen = productoAlmacen.id_almacen,
                    id_producto = productoAlmacen.id_producto,
                    stock_actual = productoAlmacen.stock_actual,
                    usuario_registro = Sesion.login_usuario
                };
                int statusProductoAlmacen = await DataLayer.Tasks.ProductoAlmacen.actualizar(productoAlmacenUpd, productoAlmacen.id_producto_almacen);

                //crear entrada en SalidaProducto -> Disposiciones
                DataLayer.Models.SalidaProducto nuevaSalida = await DataLayer.Tasks.SalidaProducto.insertar();


                DataLayer.Models.Disposicion disposicion = new DataLayer.Models.Disposicion()
                {
                    id_salida_producto=nuevaSalida.id_salida_producto,
                    id_usuario = Sesion.id_entidad,
                    id_motivo = this.motivoSeleccionado.id_motivo,
                    id_producto = productoAlmacen.id_producto,
                    cantidad = tbCantidad.Value,
                    fecha = DateTime.Now,
                    comentario = tbComentario.Text,
                    usuario_registro = Sesion.login_usuario
                };

                int statusDisposicion = await DataLayer.Tasks.Disposicion.insertar(disposicion);

                this.DialogResult = DialogResult.OK;

            }
        }

        private void cmbMotivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbMotivos.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxMotivosItems[cmbMotivos.SelectedIndex - 1];
                foreach (DataLayer.Models.ViMotivo motivo in this.motivos)
                    if (motivo.id_motivo == selectedItem.ID)
                        this.motivoSeleccionado = motivo;
            }
            else if (cmbMotivos.SelectedIndex == 0)
                this.motivoSeleccionado = new DataLayer.Models.ViMotivo();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
