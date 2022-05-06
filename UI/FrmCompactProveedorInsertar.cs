namespace UI
{
    public partial class FrmCompactProveedorInsertar : Form
    {
        public FrmCompactProveedorInsertar()
        {
            InitializeComponent();
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != String.Empty)
            {
                //chekear si el proveedor ya existe
                bool duplicate = false;
                List<DataLayer.Models.ViProveedor> proveedores = await DataLayer.Tasks.Proveedor.listar();
                foreach (DataLayer.Models.ViProveedor proveedor in proveedores)
                    if (proveedor.nombre == tbNombre.Text)
                    {
                        duplicate = true;
                        break;
                    }

                if (!duplicate)
                {
                    DataLayer.Models.Proveedor proveedor = new DataLayer.Models.Proveedor()
                    {
                        nombre = tbNombre.Text,
                        usuario_registro = Sesion.login_usuario
                    };

                    int statusCode = await DataLayer.Tasks.Proveedor.insertar(proveedor);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ya existe un proveedor con ese nombre!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Nombre vacío.\nVerifique si los datos fueron ingresados correctamente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
