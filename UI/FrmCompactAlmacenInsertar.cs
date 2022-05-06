namespace UI
{
    public partial class FrmCompactAlmacenInsertar : Form
    {

        public FrmCompactAlmacenInsertar()
        {
            InitializeComponent();
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != String.Empty)
            {
                //chekear si el almacen ya existe
                bool duplicate = false;
                List<DataLayer.Models.ViAlmacen> almacenes = await DataLayer.Tasks.Almacen.listar();
                foreach (DataLayer.Models.ViAlmacen almacen in almacenes)
                    if(almacen.descripcion == tbNombre.Text)
                    {
                        duplicate = true;
                        break;
                    }

                if (!duplicate)
                {
                    DataLayer.Models.Almacen almacen = new DataLayer.Models.Almacen()
                    {
                        descripcion = tbNombre.Text,
                        usuario_registro = Sesion.login_usuario
                    };

                    int statusCode = await DataLayer.Tasks.Almacen.insertar(almacen);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ya existe un almacén con ese nombre!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
