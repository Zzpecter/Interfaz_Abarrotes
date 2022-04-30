using System.Configuration;

namespace UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private  void FrmLogin_Load(object sender, EventArgs e)
        {
            string ip = ConfigurationManager.AppSettings["API_IP"];
            DataLayer.Globals.setIP(ip);
            tbIP.Text = ip;

            probarConexion();
        }

        private async void bAcceder_Click(object sender, EventArgs e)
        {
            DataLayer.Models.LoginUser usuario = new DataLayer.Models.LoginUser()
            {
                login_usuario = tbLogin.Text,
                password_usuario=tbPassword.Text
            };
            if ( await DataLayer.Tasks.Authentication.authenticateUser(usuario))
            {
                List<DataLayer.Models.ViUsuario> users = await DataLayer.Tasks.Usuario.seleccionarPorLogin(usuario.login_usuario);

                if ( users.Count == 1)
                {
                    DataLayer.Models.ViUsuario usuarioAutenticado = users[0];
                    DataLayer.Models.Nivel nivel = await DataLayer.Tasks.Nivel.seleccionar(usuarioAutenticado.id_nivel);

                    Sesion.login_usuario = usuarioAutenticado.login_usuario;
                    Sesion.id_nivel = usuarioAutenticado.id_nivel;
                    Sesion.nivel = nivel.nivel;
                    Sesion.password_usuario = tbPassword.Text;
                    Sesion.horaConexion = DateTime.Now;


                    this.Hide();
                    FrmMenuPrincipal frm = new FrmMenuPrincipal();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bActualizarConexion_Click(object sender, EventArgs e)
        {
            DataLayer.Globals.setIP(tbIP.Text);
            probarConexion();
        }

        private async void probarConexion()
        {
            bool conexionEstablecida = await DataLayer.Tasks.Authentication.TryApiConnection();
            if (conexionEstablecida)
            {
                pbEstado.Image = Properties.Resources.icon_ok;

                bActualizarConexion.Enabled = false;
                tbIP.Enabled = false;
                tbIP.ReadOnly = true;

                bAcceder.Enabled = true;
                tbLogin.ReadOnly = false;
                tbPassword.ReadOnly = false;
            }
            else
            {
                pbEstado.Image = Properties.Resources.icon_notok;
                MessageBox.Show(DataLayer.Globals.MSJ_ERROR_CONEXION_API, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bActualizarConexion.Enabled = true;
                tbIP.Enabled = true;
                tbIP.ReadOnly = false;

                bAcceder.Enabled = false;
                tbLogin.ReadOnly = true;
                tbPassword.ReadOnly = true;
            }
        }

        private void tbIP_DoubleClick(object sender, EventArgs e)
        {
            tbIP.ReadOnly = false;
            bActualizarConexion.Enabled = true;
        }
    }
}
