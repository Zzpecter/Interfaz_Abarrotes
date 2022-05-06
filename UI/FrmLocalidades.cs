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
    public partial class FrmLocalidades : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViLocalidad localidadSeleccionada;
        private DataLayer.Models.Departamento departamentoSeleccionado;
        private List<DataLayer.Models.Departamento> departamentos;
        private List<DataLayer.ComboboxItem> cmbBoxDepartamentosItems;
        private bool loading;
        public FrmLocalidades()
        {
            InitializeComponent();
            departamentos = new List<DataLayer.Models.Departamento>();
            cmbBoxDepartamentosItems = new List<DataLayer.ComboboxItem>();
        }

        private async void FrmLocalidades_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.ViLocalidad> localidades = await DataLayer.Tasks.Localidad.listar();
            CreateDataSource(localidades);


            departamentos = await DataLayer.Tasks.Departamento.listar();  // listar las unidades para el cmbBox
            cmbDepartamento.Items.Clear();
            cmbDepartamento.Items.Add("Seleccione un departamento...");

            foreach (DataLayer.Models.Departamento departamento in departamentos)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = departamento.id_departamento,
                    Text = departamento.nombre_departamento
                };
                cmbDepartamento.Items.Add(cmbBoxItem);
                this.cmbBoxDepartamentosItems.Add(cmbBoxItem);
            }

            cmbDepartamento.SelectedIndex = 0;
            cmbDepartamento.Enabled = false;
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
            if (dgvLocalidades.SelectedRows.Count == 1)
            {
                int statusCode = await DataLayer.Tasks.Localidad.eliminar(localidadSeleccionada.id_localidad);

                if (statusCode == 200)
                    RefreshData();
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case "agregar":
                    if (tbNombreLocalidad.Text != String.Empty && cmbDepartamento.SelectedIndex > 0)
                    {
                        //Crear e insertar la localidad
                        DataLayer.Models.Localidad localidad = new DataLayer.Models.Localidad()
                        {
                            nombre_localidad = tbNombreLocalidad.Text,
                            id_departamento = this.departamentoSeleccionado.id_departamento,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Localidad.insertar(localidad);

                        if (statusCode == 201)
                            RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese todos los valores necesarios antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbNombreLocalidad.Text != String.Empty && cmbDepartamento.SelectedIndex > 0)
                    {
                        DataLayer.Models.Localidad localidad = new DataLayer.Models.Localidad()
                        {
                            nombre_localidad = tbNombreLocalidad.Text,
                            id_departamento = this.departamentoSeleccionado.id_departamento,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Localidad.actualizar(localidad, localidadSeleccionada.id_localidad);

                        if (statusCode == 200)
                            RefreshData();
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

        private async void dgvLocalidades_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvLocalidades.SelectedRows.Count == 1)
            {
                int idLocalidadSeleccionada = Convert.ToInt32(dgvLocalidades.SelectedRows[0].Cells[0].Value);
                this.localidadSeleccionada = await DataLayer.Tasks.Localidad.seleccionar(idLocalidadSeleccionada);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombreLocalidad.Text = localidadSeleccionada.nombre_localidad;

                //seleccionar el ComboBox segun la unidad
                this.departamentoSeleccionado = await DataLayer.Tasks.Departamento.seleccionar(localidadSeleccionada.id_departamento);
                int i = 1;
                foreach (DataLayer.ComboboxItem item in cmbBoxDepartamentosItems)
                {
                    if (departamentoSeleccionado.id_departamento == item.ID)
                        cmbDepartamento.SelectedIndex = i;
                    i++;
                }
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbDepartamento.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxDepartamentosItems[cmbDepartamento.SelectedIndex - 1];
                foreach (DataLayer.Models.Departamento departamento in this.departamentos)
                    if (departamento.id_departamento == selectedItem.ID)
                        this.departamentoSeleccionado = departamento;
            }
            else if (cmbDepartamento.SelectedIndex == 0)
                this.departamentoSeleccionado = new DataLayer.Models.Departamento();
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombreLocalidad.Enabled = false;
                    cmbDepartamento.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvLocalidades.ReadOnly = false;
                    dgvLocalidades.ClearSelection();
                    break;
                case "agregar":
                    tbNombreLocalidad.Enabled = true;
                    tbNombreLocalidad.Text = String.Empty;
                    cmbDepartamento.Enabled = true;
                    cmbDepartamento.SelectedIndex = 0;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvLocalidades.ClearSelection();
                    dgvLocalidades.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombreLocalidad.Enabled = true;
                    cmbDepartamento.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvLocalidades.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViLocalidad> localidades)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(localidades[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < localidades.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(localidades[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_localidad"].SetOrdinal(0);
            dtDatos.Columns["id_departamento"].SetOrdinal(1);
            dtDatos.Columns["nombre_localidad"].SetOrdinal(2);

            dgvLocalidades.DataSource = dtDatos;
            dgvLocalidades.Columns[2].HeaderText = "Nombre Localidad";
            dgvLocalidades.Columns[0].Width = 0;
            dgvLocalidades.Columns[1].Width = 0;
            dgvLocalidades.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLocalidades.Refresh();
            dgvLocalidades.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViLocalidad> localidades = await DataLayer.Tasks.Localidad.listar();
            CreateDataSource(localidades);
        }
        #endregion

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
