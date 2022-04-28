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
    public partial class FrmMotivos : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViMotivo motivoSeleccionado;
        private bool loading;

        public FrmMotivos()
        {
            InitializeComponent();
        }

        private async void FrmMotivos_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.ViMotivo> motivos = await DataLayer.Tasks.Motivo.listar();
            CreateDataSource(motivos);
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
            if (dgvMotivos.SelectedRows.Count == 1)
            {
                // TODO: Eliminar Entidad->Contacto->usuario
                int statusCode = await DataLayer.Tasks.Motivo.eliminar(motivoSeleccionado.id_motivo);

                if (statusCode == 200)
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
                    if (tbMotivo.Text != String.Empty)
                    {
                        //Crear e insertar el motivo
                        DataLayer.Models.Motivo motivo = new DataLayer.Models.Motivo()
                        {
                            descripcion_motivo = tbMotivo.Text,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Motivo.insertar(motivo);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese una descripcion de motivo antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbMotivo.Text != String.Empty)
                    {
                        DataLayer.Models.Motivo motivo = new DataLayer.Models.Motivo()
                        {
                            descripcion_motivo = tbMotivo.Text,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Motivo.actualizar(motivo, motivoSeleccionado.id_motivo);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese una descripcion de motivo antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void dgvMotivos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvMotivos.SelectedRows.Count == 1)
            {
                int idMotivoSeleccionado = Convert.ToInt32(dgvMotivos.SelectedRows[0].Cells[0].Value);
                this.motivoSeleccionado = await DataLayer.Tasks.Motivo.seleccionar(idMotivoSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbMotivo.Text = motivoSeleccionado.descripcion_motivo;
            }
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbMotivo.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvMotivos.ReadOnly = false;
                    dgvMotivos.ClearSelection();
                    break;
                case "agregar":
                    tbMotivo.Enabled = true;
                    tbMotivo.Text = String.Empty;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvMotivos.ClearSelection();
                    dgvMotivos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbMotivo.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvMotivos.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViMotivo> motivos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(motivos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < motivos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(motivos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_motivo"].SetOrdinal(0);
            dtDatos.Columns["descripcion_motivo"].SetOrdinal(1);

            dgvMotivos.DataSource = dtDatos;
            dgvMotivos.Columns[0].HeaderText = "ID";
            dgvMotivos.Columns[1].HeaderText = "Descripcion Motivo";
            dgvMotivos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMotivos.Columns[0].Width = 0;
            dgvMotivos.Refresh();
            dgvMotivos.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViMotivo> motivos = await DataLayer.Tasks.Motivo.listar();
            CreateDataSource(motivos);

        }
        #endregion

    }
}