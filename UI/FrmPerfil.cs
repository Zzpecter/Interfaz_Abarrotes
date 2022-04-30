using System.Data;

namespace UI
{
    public partial class FrmPerfil : Form
    {
        private DataLayer.Models.ViUsuarioNivel usuarioActual;
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void bCambiarLogin_Click(object sender, EventArgs e)
        {
            bCambiarLogin.Visible = false;
            bGuardar.Visible = true;
            bCancelar.Visible = true;
            bCambiarPass.Visible = false;
            tbLogin.ReadOnly = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbLogin.Text = Sesion.login_usuario;
            tbLogin.ReadOnly = true;
            bCambiarLogin.Visible = true;
            bGuardar.Visible = false;
            bCancelar.Visible = false;
            bCambiarPass.Visible = true;
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            //Actualizar el usuario
            this.usuarioActual.login_usuario = tbLogin.Text;
            DataLayer.Models.Usuario usuarioActualizado = new DataLayer.Models.Usuario()
            {
                id_nivel = Sesion.id_nivel,
                login_usuario = tbLogin.Text,
                password_usuario = Sesion.password_usuario,
                usuario_registro = Sesion.login_usuario
            };

            int statusCode = await DataLayer.Tasks.Usuario.actualizar(usuarioActualizado, Sesion.id_entidad);

            Sesion.login_usuario = this.usuarioActual.login_usuario;

            bCambiarLogin.Visible = true;
            bGuardar.Visible = false;
            bCancelar.Visible = false;
            bCambiarPass.Visible = true;
            tbLogin.ReadOnly = true;
        }

        private async void FrmPerfil_Load(object sender, EventArgs e)
        {
            //crear usuario actual y llenar campos
            this.usuarioActual = new DataLayer.Models.ViUsuarioNivel()
            {
                id_entidad = Sesion.id_entidad,
                login_usuario = Sesion.login_usuario,
                password_usuario = Sesion.password_usuario,
                id_nivel = Sesion.id_nivel,
                nivel = Sesion.nivel
            };

            tbLogin.Text = this.usuarioActual.login_usuario;
            lblNivel.Text = this.usuarioActual.nivel;

            //Cargar info de contacto
            List<DataLayer.Models.ViContactoUnified> datosContacto = await DataLayer.Tasks.Contacto.listarUnified(this.usuarioActual.id_entidad);
            if (datosContacto.Count > 0)
                RefreshContactData(datosContacto);

            //Lanzar el timer para el label
            tmrTiempoConexion.Start();
        }

        private void RefreshContactData(List<DataLayer.Models.ViContactoUnified> datosContacto)
        {
            DataTable dtDatosContacto = new DataTable();
            dtDatosContacto.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(datosContacto[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatosContacto.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < datosContacto.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(datosContacto[i]);
                DataRow _tempRow = dtDatosContacto.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatosContacto.Rows.Add(_tempRow);
            }
            dgvContactos.DataSource = dtDatosContacto;
            dgvContactos.Columns[0].HeaderText = "ID";
            dgvContactos.Columns[1].HeaderText = "Contacto";
            dgvContactos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContactos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContactos.Refresh();
        }

        private void tmrTiempoConexion_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - Sesion.horaConexion;
            lblTiempoConexion.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }

        private void bCambiarPass_Click(object sender, EventArgs e)
        {
            FrmCambiarPass frm = new FrmCambiarPass();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Contraseña Actualizada!", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void bEditarContactos_Click(object sender, EventArgs e)
        {
            FrmContactos frm = new FrmContactos(Sesion.id_entidad);
            var result = frm.ShowDialog();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
