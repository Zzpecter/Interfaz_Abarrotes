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
    public partial class FrmUsuario : Form
    {
        #region Inicializacion y Variables

        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViUsuario usuarioSeleccionado;
        private bool loading;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private async void FrmUsuario_Load(object sender, EventArgs e)
        {
            DataLayer.Tasks.Config cfg = new DataLayer.Tasks.Config();
            cfg.readURL(); //Estas 2 lineas igual se generan en el login
            await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.
            List<DataLayer.Models.ViUsuarioNivel> usuarios = await DataLayer.Tasks.Usuario.listarUsuarioNivel();
            CreateDataSource(usuarios);
        }
        #endregion

        #region Botones y Controles
        private void bAgregar_Click(object sender, EventArgs e)
        {

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {

        }

        private void bElimiar_Click(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {

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
                tbPassword.Text = "********";
            }

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            dgvDatos.DataSource = dtDatos;
            dgvDatos.Refresh();
            dgvDatos.ClearSelection();
            dgvDatos.Columns[0].HeaderText = "ID";
            dgvDatos.Columns[1].HeaderText = "Nombre de Usuario";
            dgvDatos.Columns[2].HeaderText = "Nivel de Usuario";
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViUsuarioNivel> usuarios = await DataLayer.Tasks.Usuario.listarUsuarioNivel();
            CreateDataSource(usuarios);
        }
        #endregion
    }
}
