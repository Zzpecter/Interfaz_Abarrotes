using System.Configuration;

namespace UI
{
    public partial class FrmCompactProductoCrear : Form
    {

        public DataLayer.Models.ViProductoEnAlmacen nuevoProducto;
        private List<DataLayer.Models.ViPresentacionUnidad> presentaciones;
        private int LONGITUD_CODIGO_PRODUCTO;
        private List<DataLayer.ComboboxItem> cmbBoxPresentacionesItems;
        private DataLayer.Models.ViPresentacionProducto presentacionSeleccionada;
        private bool loading;

        public FrmCompactProductoCrear()
        {
            InitializeComponent();
            presentaciones = new List<DataLayer.Models.ViPresentacionUnidad>();
            nuevoProducto = new DataLayer.Models.ViProductoEnAlmacen() { id_producto = -1 };
            LONGITUD_CODIGO_PRODUCTO = Convert.ToInt32(ConfigurationManager.AppSettings["LONGITUD_CODIGO_PRODUCTO"]);
            presentacionSeleccionada = new DataLayer.Models.ViPresentacionProducto() { id_presentacion_producto = -1 };
            cmbBoxPresentacionesItems = new List<DataLayer.ComboboxItem>();
        }

        private void FrmCompactProductoCrear_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cbGenerarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGenerarCodigo.Checked)
            {
                tbCodigoProducto.ReadOnly = true;
                tbCodigoProducto.Text = String.Empty;
            }
            else
                tbCodigoProducto.ReadOnly = false;
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            //generar el codigo si el check esta activo
            if (cbGenerarCodigo.Checked)
            {
                Random rand = new Random();
                bool duplicado = true;
                string codigoGenerado = String.Empty;
                while (duplicado)
                {
                    codigoGenerado = String.Empty;
                    for (int i = 0; i < LONGITUD_CODIGO_PRODUCTO; i++)
                    {
                        int digito = rand.Next(0, 9);
                        codigoGenerado += Convert.ToString(digito);
                    }

                    List<DataLayer.Models.ViProductoPresentacionUnidad> productosCodigo = await DataLayer.Tasks.Producto.buscar(codigoGenerado);
                    if (productosCodigo.Count == 0)
                        duplicado = false;
                }
                tbCodigoProducto.Text = codigoGenerado;
            }

            //chekear que todo esté correctamente llenado
            bool error = false;
            string errorCaption = "Errores:\n";

            // nombre vacio
            if (tbNombreProducto.Text == String.Empty)
            {
                error = true;
                errorCaption += "- Ingrese un nombre de producto!\n";
            }

            //codigo vacio
            if (tbCodigoProducto.Text == String.Empty)
            {
                error = true;
                errorCaption += "- Ingrese un código de producto!\n";
            }
            else
            {
                //codigo duplicado
                List<DataLayer.Models.ViProductoPresentacionUnidad> productos = await DataLayer.Tasks.Producto.buscar(tbCodigoProducto.Text);
                if (productos.Count > 0)
                {
                    error = true;
                    errorCaption += "- El código de producto no es único!\n";
                }
            }

            //presentacion-unidad seleccionada
            if (cmbPresentaciones.SelectedIndex == 0)
            {
                error = true;
                errorCaption += "- Seleccione la presentación del producto!\n";
            }

            if(!error)
            {
                DataLayer.Models.Producto productoNuevo= new DataLayer.Models.Producto()
                {
                    id_presentacion_producto = presentacionSeleccionada.id_presentacion_producto,
                    nombre = tbNombreProducto.Text,
                    codigo = tbCodigoProducto.Text,
                    precio_compra = tbPrecioCompra.Value,
                    precio_venta = tbPrecioVenta.Value,
                    usuario_registro = Sesion.login_usuario
                };

                //insertar el producto
                DataLayer.Models.Producto _producto = await DataLayer.Tasks.Producto.insertar(productoNuevo);
                
                //crear entrada en producto_almacen
                DataLayer.Models.ProductoAlmacen productoAlmacenActualizado = new DataLayer.Models.ProductoAlmacen()
                {
                    id_producto = _producto.id_producto,
                    id_almacen = 1,
                    stock_actual = 1,
                    usuario_registro = Sesion.login_usuario
                };

                int statusCode = await DataLayer.Tasks.ProductoAlmacen.insertar(productoAlmacenActualizado);

                List<DataLayer.Models.ViProductoEnAlmacen> listaProductos = await DataLayer.Tasks.ProductoAlmacen.buscarProductoEnAlmacen(tbCodigoProducto.Text);
                this.nuevoProducto = listaProductos[0]; 
            }
            else
                MessageBox.Show(errorCaption, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            if (this.nuevoProducto.id_producto != -1 && !error)
                this.DialogResult = DialogResult.OK;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private async void CargarComboBox()
        {
            presentaciones = await DataLayer.Tasks.PresentacionProducto.listar();  // listar las presentaciones para el cmbBox

            this.loading = true;

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
                this.cmbBoxPresentacionesItems.Add(cmbBoxItem);
            }

            cmbPresentaciones.SelectedIndex = 1;
            this.loading = false;
        }

        private void cmbPresentaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbPresentaciones.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxPresentacionesItems[cmbPresentaciones.SelectedIndex - 1];
                foreach (DataLayer.Models.ViPresentacionProducto presentacion in this.presentaciones)
                    if (presentacion.id_presentacion_producto == selectedItem.ID)
                        this.presentacionSeleccionada = presentacion;
            }
            else if (cmbPresentaciones.SelectedIndex == 0)
                this.presentacionSeleccionada = new DataLayer.Models.ViPresentacionProducto() { id_presentacion_producto = -1};
        }

        private void bEditarPresentaciones_Click(object sender, EventArgs e)
        {
            FrmPresentacionProducto frm = new FrmPresentacionProducto();
            frm.ShowDialog();
            CargarComboBox();
        }
    }
}
