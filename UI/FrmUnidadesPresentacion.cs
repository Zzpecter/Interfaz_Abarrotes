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
    public partial class FrmUnidadesPresentacion : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViUnidadPresentacion unidadSeleccionada;
        private bool loading;

        public FrmUnidadesPresentacion()
        {
            InitializeComponent();
        }

        private async void FrmUnidadesPresentacion_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.
            List<DataLayer.Models.ViUnidadPresentacion> unidadesPresentacion = await DataLayer.Tasks.UnidadPresentacion.listar();
            CreateDataSource(unidadesPresentacion);
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
            if (dgvUnidades.SelectedRows.Count == 1)
            {
                // TODO: Eliminar Entidad->Contacto->usuario
                int statusCode = await DataLayer.Tasks.UnidadPresentacion.eliminar(unidadSeleccionada.id_unidad_presentacion);

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
                    if (tbNombreMedida.Text != String.Empty && tbMultiplicadorKg.Value != Convert.ToDecimal(0.00))
                    {
                        //Crear e insertar la unidad de presentacion
                        DataLayer.Models.UnidadPresentacion unidadPresentacion = new DataLayer.Models.UnidadPresentacion()
                        {
                            nombre_medida = tbNombreMedida.Text,
                            multiplicador_kg = Convert.ToDouble(tbMultiplicadorKg.Value),
                            usuario_registro = "dev" //TODO cambiar cuando exista login.
                        };
                        int statusCode = await DataLayer.Tasks.UnidadPresentacion.insertar(unidadPresentacion);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese todos los valores necesarios antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbNombreMedida.Text != String.Empty && tbMultiplicadorKg.Value != Convert.ToDecimal(0.00))
                    {
                        DataLayer.Models.UnidadPresentacion unidadPresentacion = new DataLayer.Models.UnidadPresentacion()
                        {
                            nombre_medida = tbNombreMedida.Text,
                            multiplicador_kg = Convert.ToDouble(tbMultiplicadorKg.Value),
                            usuario_registro = "dev" //TODO cambiar cuando exista login.
                        };
                        int statusCode = await DataLayer.Tasks.UnidadPresentacion.actualizar(unidadPresentacion, unidadSeleccionada.id_unidad_presentacion);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese todos los valores necesarios antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void dgvUnidades_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvUnidades.SelectedRows.Count == 1)
            {
                int idUnidadPresentacion = Convert.ToInt32(dgvUnidades.SelectedRows[0].Cells[0].Value);
                this.unidadSeleccionada = await DataLayer.Tasks.UnidadPresentacion.seleccionar(idUnidadPresentacion);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombreMedida.Text = unidadSeleccionada.nombre_medida;
                tbMultiplicadorKg.Value = Convert.ToDecimal(unidadSeleccionada.multiplicador_kg);
            }
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombreMedida.Enabled = false;
                    tbMultiplicadorKg.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvUnidades.ReadOnly = false;
                    dgvUnidades.ClearSelection();
                    break;
                case "agregar":
                    tbNombreMedida.Enabled = true;
                    tbNombreMedida.Text = String.Empty;
                    tbMultiplicadorKg.Enabled = true;
                    tbMultiplicadorKg.Value = Convert.ToDecimal(1.00);

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvUnidades.ClearSelection();
                    dgvUnidades.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombreMedida.Enabled = true;
                    tbMultiplicadorKg.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvUnidades.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViUnidadPresentacion> unidadesPresencation)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(unidadesPresencation[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < unidadesPresencation.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(unidadesPresencation[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_unidad_presentacion"].SetOrdinal(0);
            dtDatos.Columns["nombre_medida"].SetOrdinal(1);
            dtDatos.Columns["multiplicador_kg"].SetOrdinal(2);

            dgvUnidades.DataSource = dtDatos;
            dgvUnidades.Columns[0].HeaderText = "ID";
            dgvUnidades.Columns[1].HeaderText = "Nombre Medida";
            dgvUnidades.Columns[2].HeaderText = "Multiplicador Kg.";
            dgvUnidades.Columns[0].Width = 0;
            dgvUnidades.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvUnidades.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUnidades.Refresh();
            dgvUnidades.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViUnidadPresentacion> unidadesPresentacion = await DataLayer.Tasks.UnidadPresentacion.listar();
            CreateDataSource(unidadesPresentacion);

        }
        #endregion
    }
}
