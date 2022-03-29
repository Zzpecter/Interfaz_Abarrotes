using System.Data;

namespace UI
{
    public partial class FrmProveedor : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViProveedor proveedorSeleccionado;
        private bool loading;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private async void FrmProveedor_Load(object sender, EventArgs e)
        {
            await DataLayer.Tasks.Authentication.BuildAuthHeaders();
            List<DataLayer.Models.ViProveedor> proveedores = await DataLayer.Tasks.Proveedor.listar();
            CreateDataSource(proveedores);
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
            if (dgvProveedores.SelectedRows.Count == 1)
            {
                // Eliminar Entidad->Contacto->usuario
                int statusCode = await DataLayer.Tasks.Entidad.eliminar(proveedorSeleccionado.id_entidad);
                statusCode = await DataLayer.Tasks.Contacto.eliminarPorEntidad(proveedorSeleccionado.id_entidad);
                statusCode = await DataLayer.Tasks.Proveedor.eliminar(proveedorSeleccionado.id_entidad);

                if (statusCode == 204)
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
                    if (tbNombre.Text != String.Empty)
                    {

                        //Insertar nueva entidad para generar el ID.
                        DataLayer.Models.Entidad entidad = await DataLayer.Tasks.Entidad.insertar();

                        DataLayer.Models.Proveedor _proveedor = new DataLayer.Models.Proveedor()
                        {
                            id_entidad = entidad.id_entidad,
                            nombre = tbNombre.Text,
                            usuario_registro = "dev" //esto vamos a sacar de los globales, donde registraremos el usuario activo

                        };
                        int statusCode = await DataLayer.Tasks.Proveedor.insertar(_proveedor);

                        if (statusCode == 201)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese nombre del proveedor.", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbNombre.Text != String.Empty)
                    {
                        DataLayer.Models.Proveedor _proveedor = new DataLayer.Models.Proveedor()
                        {
                            nombre = tbNombre.Text,
                            usuario_registro = "dev" //esto vamos a sacar de los globales, donde registraremos el usuario activo

                        };
                        int statusCode = await DataLayer.Tasks.Proveedor.actualizar(_proveedor, proveedorSeleccionado.id_entidad);

                        if (statusCode == 200)
                        {
                            RefreshData();
                        }
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese el nombre del proveedor.", "Error!", MessageBoxButtons.OK);
                    break;

            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (loading == false && dgvProveedores.SelectedRows.Count == 1)
            {
                int idEntidadSeleccionada = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[0].Value);
                proveedorSeleccionado = await DataLayer.Tasks.Proveedor.seleccionar(idEntidadSeleccionada);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombre.Text = proveedorSeleccionado.nombre;

                // Cargar datos de contacto
                List<DataLayer.Models.ViContactoUnified> datosContacto = await DataLayer.Tasks.Contacto.listarUnified(idEntidadSeleccionada);
                if (datosContacto.Count > 0)
                    RefreshContactData(datosContacto);
                else
                {
                    dgvContactos.DataSource = null;
                    dgvContactos.Refresh();
                }
            }
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombre.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvProveedores.ReadOnly = false;
                    break;
                case "agregar":
                    tbNombre.Enabled = true;
                    tbNombre.Text = String.Empty;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvProveedores.ClearSelection();
                    dgvProveedores.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombre.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvProveedores.ReadOnly = true;
                    break;
            }
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

        private void CreateDataSource(List<DataLayer.Models.ViProveedor> proveedores)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(proveedores[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < proveedores.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(proveedores[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            loading = true;
            dgvProveedores.DataSource = dtDatos;
            dgvProveedores.Refresh();
            dgvProveedores.ClearSelection();
            dgvProveedores.Columns[0].HeaderText = "ID";
            dgvProveedores.Columns[1].HeaderText = "Nombre Proveedor";
            dgvProveedores.Columns[0].Width = 0;
            dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loading = false;
        }
        private async void RefreshData()
        {
            List<DataLayer.Models.ViProveedor> proveedores = await DataLayer.Tasks.Proveedor.listar();
            CreateDataSource(proveedores);
        }
        #endregion
    }
}
