using System.Data;

namespace UI
{
    public partial class Form1 : Form
    {
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViCliente motivoSeleccionado;
        private bool loading;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            await DataLayer.Tasks.Authentication.BuildAuthHeaders();
            List<DataLayer.Models.ViCliente> motivos =  await DataLayer.Tasks.Motivo.listar();
            CreateDataSource(motivos);
            dgvDatos.Rows[0].Selected = true;
        }

        private void CreateDataSource(List<DataLayer.Models.ViCliente> motivos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(motivos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach ( var item in propertyDict )
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for(int i = 0; i < motivos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(motivos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            loading = true;
            dgvDatos.DataSource = dtDatos;
            dgvDatos.Refresh();
            dgvDatos.ClearSelection();
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDatos.Columns[0].HeaderText = "ID";
            dgvDatos.Columns[1].HeaderText = "Descripción Motivo";
            loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViCliente> motivos = await DataLayer.Tasks.Motivo.listar();
            CreateDataSource(motivos);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            formState = "agregar";
            ChangeState();
        }

        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbDescripcionMotivo.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDatos.ReadOnly = false;
                    break;
                case "agregar":
                    tbDescripcionMotivo.Enabled = true;
                    tbDescripcionMotivo.Text = String.Empty;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDatos.ClearSelection();
                    dgvDatos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbDescripcionMotivo.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvDatos.ReadOnly = true;
                    break;

            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            formState = "actualizar";
            ChangeState();
        }

        private async void bElimiar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 1)
            {
                int statusCode = await DataLayer.Tasks.Motivo.eliminar(motivoSeleccionado.id_motivo);
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
                    if (tbDescripcionMotivo.Text != String.Empty)
                    {
                        DataLayer.Models.Cliente motivo = new DataLayer.Models.Cliente() { descripcion_motivo = tbDescripcionMotivo.Text, usuario_registro = "dev" };
                        int statusCode = await DataLayer.Tasks.Motivo.insertar(motivo);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese una descripcion de motivo.", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbDescripcionMotivo.Text != String.Empty)
                    {
                        DataLayer.Models.Cliente _motivo = new DataLayer.Models.Cliente();

                        _motivo.descripcion_motivo = tbDescripcionMotivo.Text;
                        _motivo.usuario_registro = "dev"; //esto vamos a sacar de los globales, donde registraremos el usuario activo
                        int statusCode = await DataLayer.Tasks.Motivo.actualizar(_motivo, motivoSeleccionado.id_motivo);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese una descripcion de motivo.", "Error!", MessageBoxButtons.OK);
                    break;
                
            }
            
        }

        private async void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (loading == false && dgvDatos.SelectedRows.Count == 1)
            {
                var a = dgvDatos.SelectedRows[0].Index;
                int idMotivoSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                motivoSeleccionado = await DataLayer.Tasks.Motivo.seleccionar(idMotivoSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbDescripcionMotivo.Text = motivoSeleccionado.descripcion_motivo;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }
    }
}