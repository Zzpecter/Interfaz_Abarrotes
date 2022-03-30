using System.Data;

namespace UI
{
    public partial class FrmUsuario : Form
    {
        #region Inicializacion y Variables

        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViUsuario usuarioSeleccionado;
        List<DataLayer.Models.Nivel> niveles;
        DataLayer.Models.Nivel nivelSeleccionado;
        private bool loading;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.
            List<DataLayer.Models.ViUsuarioNivel> usuarios = await DataLayer.Tasks.Usuario.listarUsuarioNivel();
            CreateDataSource(usuarios);

            niveles = await DataLayer.Tasks.Nivel.listar();  // listar los niveles para el cmbBox

            cmbNivel.Items.Clear();
            cmbNivel.Items.Add("Seleccione un nivel...");
            foreach (DataLayer.Models.Nivel nivel in niveles)
                cmbNivel.Items.Add(nivel.nivel);

            cmbNivel.SelectedIndex = 0;
            cmbNivel.Enabled = false;
        }
        #endregion

        #region Botones y Controles
        private void bAgregar_Click(object sender, EventArgs e)
        {
            formState = "agregar";
            ChangeState();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            formState = "actualizar";
            ChangeState();
        }

        private async void bElimiar_Click(object sender, EventArgs e)
        {
            if(dgvDatos.SelectedRows.Count == 1)
            {
                // Eliminar Entidad->Contacto->usuario
                int statusCode = await DataLayer.Tasks.Entidad.eliminar(usuarioSeleccionado.id_entidad);
                statusCode = await DataLayer.Tasks.Contacto.eliminarPorEntidad(usuarioSeleccionado.id_entidad);
                statusCode = await DataLayer.Tasks.Usuario.eliminar(usuarioSeleccionado.id_entidad);

                if (statusCode == 204)
                    RefreshData();
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            bool cumpleCondiciones;
            DataLayer.PasswordScore passScore;
            switch (formState)
            {
                case "agregar":
                    cumpleCondiciones = true;
                    // chekeamos que nada este vacío o en un indice invalido
                    if (tbLogin.Text == String.Empty || tbPassword.Text == String.Empty || cmbNivel.SelectedIndex == 0)
                        cumpleCondiciones = false;

                    // chekeamos fuerza del password
                    passScore = DataLayer.Helpers.CheckStrength(tbPassword.Text);
                    if(passScore == DataLayer.PasswordScore.Blank || passScore == DataLayer.PasswordScore.VeryWeak)
                    {
                        MessageBox.Show(DataLayer.Globals.MSJ_PASS_DEBIL, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cumpleCondiciones = false;
                    }

                    if (cumpleCondiciones)
                    {
                        //Insertar nueva entidad para generar el ID.
                        DataLayer.Models.Entidad entidad = await DataLayer.Tasks.Entidad.insertar();

                        //Crear e insertar el usuario
                        DataLayer.Models.Usuario usuario = new DataLayer.Models.Usuario()
                        {
                            id_entidad = entidad.id_entidad,
                            id_nivel = this.nivelSeleccionado.id_nivel,
                            login_usuario = tbLogin.Text,
                            password_usuario = tbPassword.Text,
                            usuario_registro = "dev" //TODO cambiar cuando exista login.
                        };
                        int statusCode = await DataLayer.Tasks.Usuario.insertar(usuario);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese login, contraseña y seleccione un nivel antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    cumpleCondiciones = true;
                    // chekeamos que nada este vacío o en un indice invalido
                    if (tbLogin.Text == String.Empty || tbPassword.Text == String.Empty || cmbNivel.SelectedIndex == 0)
                        cumpleCondiciones = false;

                    // chekeamos fuerza del password
                    passScore = DataLayer.Helpers.CheckStrength(tbPassword.Text);
                    if (passScore == DataLayer.PasswordScore.Blank || passScore == DataLayer.PasswordScore.VeryWeak)
                    {
                        MessageBox.Show(DataLayer.Globals.MSJ_PASS_DEBIL, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cumpleCondiciones = false;
                    }
                    if (cumpleCondiciones)
                    {
                        DataLayer.Models.Usuario usuario = new DataLayer.Models.Usuario()
                        {
                            id_nivel = this.nivelSeleccionado.id_nivel,
                            login_usuario = tbLogin.Text,
                            password_usuario = tbPassword.Text,
                            usuario_registro = "dev" //TODO cambiar cuando exista login.
                        };
                        int statusCode = await DataLayer.Tasks.Usuario.actualizar(usuario, usuarioSeleccionado.id_entidad);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese login, contraseña y seleccione un nivel antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvDatos.SelectedRows.Count == 1)
            {
                int idUsuarioSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                this.usuarioSeleccionado = await DataLayer.Tasks.Usuario.seleccionar(idUsuarioSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                bEditarContactos.Enabled = true;
                tbLogin.Text = usuarioSeleccionado.login_usuario;
                tbPassword.Text = String.Empty;

                // Cargar datos de contacto
                List<DataLayer.Models.ViContactoUnified> datosContacto = await DataLayer.Tasks.Contacto.listarUnified(idUsuarioSeleccionado);
                if (datosContacto.Count > 0)
                    RefreshContactData(datosContacto);
                else
                {
                    dgvContactos.DataSource = null;
                    dgvContactos.Refresh();
                }

                //seleccionar el ComboBox segun el nivel
                this.cmbNivel.SelectedIndex = usuarioSeleccionado.id_nivel;
            }

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false)
                foreach (DataLayer.Models.Nivel nivel in niveles)
                    if (nivel.nivel == cmbNivel.SelectedItem.ToString())
                        nivelSeleccionado = nivel;
        }
        #endregion

        #region Métodos de Apoyo
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbLogin.Enabled = false;
                    tbPassword.Enabled = false;
                    cmbNivel.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarContactos.Enabled = false;

                    dgvDatos.ReadOnly = false;
                    dgvDatos.ClearSelection();
                    break;
                case "agregar":
                    tbLogin.Enabled = true;
                    tbPassword.Enabled = true;
                    cmbNivel.Enabled = true;
                    tbLogin.Text = String.Empty;
                    tbPassword.Text = String.Empty;
                    cmbNivel.SelectedIndex = 0;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarContactos.Enabled = false;

                    dgvDatos.ClearSelection();
                    dgvDatos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbLogin.Enabled = true;
                    tbPassword.Enabled = true;
                    cmbNivel.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;
                    bEditarContactos.Enabled = false;

                    dgvDatos.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViUsuarioNivel> usuarios)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(usuarios[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < usuarios.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(usuarios[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns.Remove("password_usuario");
            dtDatos.Columns.Remove("id_nivel");
            dtDatos.Columns["id_entidad"].SetOrdinal(0);
            dtDatos.Columns["login_usuario"].SetOrdinal(1);
            dtDatos.Columns["nivel"].SetOrdinal(2);
            dgvDatos.DataSource = dtDatos;
            dgvDatos.Columns[0].HeaderText = "ID";
            dgvDatos.Columns[1].HeaderText = "Nombre de Usuario";
            dgvDatos.Columns[2].HeaderText = "Nivel de Usuario";
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDatos.Columns[0].Width = 0;
            dgvDatos.Refresh();
            dgvDatos.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViUsuarioNivel> usuarios = await DataLayer.Tasks.Usuario.listarUsuarioNivel();
            CreateDataSource(usuarios);
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
        #endregion
    }
}
