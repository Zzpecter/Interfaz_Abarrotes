using System.Data;

namespace UI
{
    public partial class FrmContactos : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private String currentSelection = "correos";
        private DataLayer.Models.ViLocalidad localidadSeleccionada;
        private DataLayer.Models.Departamento departamentoSeleccionado;

        private DataLayer.Models.ViEntidadContactoCorreo contactoCorreoSeleccionado;
        private DataLayer.Models.ViEntidadContactoDireccion contactoDireccionSeleccionado;
        private DataLayer.Models.ViEntidadContactoTelefono contactoTelefonoSeleccionado;

        private List<DataLayer.Models.Departamento> departamentos;
        private List<DataLayer.Models.ViLocalidad> localidades;
        private List<DataLayer.ComboboxItem> cmbBoxDepartamentosItems;
        private List<DataLayer.ComboboxItem> cmbBoxLocalidadesItems;

        private int id_entidad;

        private bool loading;

        public FrmContactos(int id_entidad)
        {
            InitializeComponent();
            this.id_entidad = id_entidad;
            //Buscar la entidad en clientes, proveedores y usuarios
            this.cmbBoxDepartamentosItems = new List<DataLayer.ComboboxItem>();
            this.cmbBoxLocalidadesItems = new List<DataLayer.ComboboxItem>();
        }
        

        private async void FrmContactos_Load(object sender, EventArgs e)
        {
            //await DataLayer.Tasks.Authentication.BuildAuthHeaders(); // Esto se hará en el login, cuando exista.

            BuscarEntidad();

            this.departamentos = await DataLayer.Tasks.Departamento.listar();
            cmbDepartamentos.Items.Clear();
            cmbDepartamentos.Items.Add("Seleccione un departamento...");

            foreach (DataLayer.Models.Departamento departamento in departamentos)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                {
                    ID = departamento.id_departamento,
                    Text = departamento.nombre_departamento
                };
                cmbDepartamentos.Items.Add(cmbBoxItem);
                this.cmbBoxDepartamentosItems.Add(cmbBoxItem);
            }

            cmbDepartamentos.SelectedIndex = 0;
            cmbDepartamentos.Enabled = false;

            cmbLocalidades.Items.Clear();
            cmbLocalidades.Items.Add("Seleccione un departamento primero...");

            this.rbTelefono.Checked = true;
        }
        #endregion

        #region Botones y Controles
        private void radioButtonCheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "rbCorreo":
                    if(rbCorreo.Checked)
                    {
                        CargarCorreos();
                        this.currentSelection = "correos";
                    }
                    break;
                case "rbTelefono":
                    if(rbTelefono.Checked)
                    {
                        CargarTelefonos();
                        this.currentSelection = "telefonos";
                    }
                    break;
                case "rbDireccion":
                    if(rbDireccion.Checked)
                    {
                        CargarDirecciones();
                        this.currentSelection = "direcciones";
                    }                    
                    break;
            }
            this.formState = "init";
            ChangeState();
            this.SwitchControls(this.currentSelection);
        }

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
            if (dgvContactos.SelectedRows.Count == 1)
            {
                int statusCode = 500;
                switch (this.currentSelection)
                {
                    case "correos":
                        statusCode = await DataLayer.Tasks.ContactoCorreo.eliminar(contactoCorreoSeleccionado.id_contacto_correo);
                        break;
                    case "direcciones":
                        statusCode = await DataLayer.Tasks.ContactoDireccion.eliminar(contactoDireccionSeleccionado.id_contacto_direccion);
                        break;
                    case "telefonos":
                        statusCode = await DataLayer.Tasks.ContactoTelefono.eliminar(contactoTelefonoSeleccionado.id_contacto_telefono);
                        break;
                }
                if (statusCode < 300)
                    RefreshData();
                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            bool error = false;
            int statusCode = 500;


            switch (formState)
            {
                case "agregar":
                    //Crear e insertar el contacto
                    switch (currentSelection)
                    {
                        case "correos":
                            if (tbCorreoCodigoCalle.Text == String.Empty)
                            {
                                error = true;
                                break;
                            }

                            //Crear e insertar el contacto_correo
                            DataLayer.Models.Contacto contacto_1 = new DataLayer.Models.Contacto()
                            {
                                id_entidad = this.id_entidad,
                                usuario_registro = Sesion.login_usuario
                    };
                            contacto_1 = await DataLayer.Tasks.Contacto.insertar(contacto_1);
                            DataLayer.Models.ContactoCorreo contactoCorreo = new DataLayer.Models.ContactoCorreo()
                            {
                                id_contacto = contacto_1.id_contacto,
                                correo = this.tbCorreoCodigoCalle.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoCorreo.insertar(contactoCorreo);

                            if (statusCode == 201)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;

                        case "telefonos":
                            if (tbCorreoCodigoCalle.Text == String.Empty || tbNumeros.Text == String.Empty)
                            {
                                error = true;
                                break;
                            }

                            //Crear e insertar el contacto_telefono
                            DataLayer.Models.Contacto contacto_2 = new DataLayer.Models.Contacto()
                            {
                                id_entidad = this.id_entidad,
                                usuario_registro = Sesion.login_usuario
                            };
                            contacto_2 = await DataLayer.Tasks.Contacto.insertar(contacto_2);
                            DataLayer.Models.ContactoTelefono contactoTelefono = new DataLayer.Models.ContactoTelefono()
                            {
                                id_contacto = contacto_2.id_contacto,
                                codigo_pais = this.tbCorreoCodigoCalle.Text,
                                numero = this.tbNumeros.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoTelefono.insertar(contactoTelefono);

                            if (statusCode == 201)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;

                        case "direcciones":
                            if (tbCorreoCodigoCalle.Text == String.Empty || tbNumeros.Text == String.Empty || cmbDepartamentos.SelectedIndex == 0 || cmbLocalidades.SelectedIndex == 0)
                            {
                                error = true;
                                break;
                            }
                            //Crear e insertar el contacto_correo
                            DataLayer.Models.Contacto contacto_3 = new DataLayer.Models.Contacto()
                            {
                                id_entidad = this.id_entidad,
                                usuario_registro = Sesion.login_usuario
                            };
                            contacto_3 = await DataLayer.Tasks.Contacto.insertar(contacto_3);

                            DataLayer.Models.ContactoDireccion contactoDireccion = new DataLayer.Models.ContactoDireccion()
                            {
                                id_contacto = contacto_3.id_contacto,
                                id_localidad = this.localidadSeleccionada.id_localidad,
                                calle = tbCorreoCodigoCalle.Text,
                                numero_casa = this.tbNumeros.Text,
                                zona = tbZona.Text,
                                detalles = tbDetalles.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoDireccion.insertar(contactoDireccion);

                            if (statusCode == 201)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;
                    }
                    break;
                case "actualizar":
                    switch (currentSelection)
                    {
                        case "correos":
                            if (tbCorreoCodigoCalle.Text == String.Empty)
                            {
                                error = true;
                                break;
                            }

                            //Crear e insertar el contacto_correo
                            DataLayer.Models.ContactoCorreo contactoCorreo = new DataLayer.Models.ContactoCorreo()
                            {
                                id_contacto = this.contactoCorreoSeleccionado.id_contacto,
                                correo = this.tbCorreoCodigoCalle.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoCorreo.actualizar(contactoCorreo, contactoCorreoSeleccionado.id_contacto_correo);

                            if (statusCode == 200)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;

                        case "telefonos":
                            if (tbCorreoCodigoCalle.Text == String.Empty || tbNumeros.Text == String.Empty)
                            {
                                error = true;
                                break;
                            }

                            //Crear e insertar el contacto_telefono
                            DataLayer.Models.ContactoTelefono contactoTelefono = new DataLayer.Models.ContactoTelefono()
                            {
                                id_contacto = this.contactoTelefonoSeleccionado.id_contacto,
                                codigo_pais = this.tbCorreoCodigoCalle.Text,
                                numero = this.tbNumeros.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoTelefono.actualizar(contactoTelefono, contactoTelefonoSeleccionado.id_contacto_telefono);

                            if (statusCode == 200)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;

                        case "direcciones":
                            if (tbCorreoCodigoCalle.Text == String.Empty || tbNumeros.Text == String.Empty || cmbDepartamentos.SelectedIndex == 0 || cmbLocalidades.SelectedIndex == 0)
                            {
                                error = true;
                                break;
                            }
                            //Crear e insertar el contacto_correo
                            DataLayer.Models.ContactoDireccion contactoDireccion = new DataLayer.Models.ContactoDireccion()
                            {
                                id_contacto = this.contactoDireccionSeleccionado.id_contacto,
                                id_localidad = this.localidadSeleccionada.id_localidad,
                                calle = tbCorreoCodigoCalle.Text,
                                numero_casa = this.tbNumeros.Text,
                                zona = tbZona.Text,
                                detalles = tbDetalles.Text,
                                usuario_registro = Sesion.login_usuario
                            };
                            statusCode = await DataLayer.Tasks.ContactoDireccion.actualizar(contactoDireccion, contactoDireccionSeleccionado.id_contacto_direccion);

                            if (statusCode == 200)
                                RefreshData();
                            formState = "init";
                            ChangeState();
                            break;
                    }
                    break;
            }
            if (error)
                MessageBox.Show("Ingrese todos los campos requeridos para guardar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (statusCode>300)
                MessageBox.Show("Error al guardar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbDepartamentos.SelectedIndex > 0)
            {

                DataLayer.ComboboxItem selectedItem = cmbBoxDepartamentosItems[cmbDepartamentos.SelectedIndex - 1];
                foreach (DataLayer.Models.Departamento departamento in this.departamentos)
                    if (departamento.id_departamento == selectedItem.ID)
                        this.departamentoSeleccionado = departamento;

                this.cmbBoxLocalidadesItems.Clear();
                this.localidades = await DataLayer.Tasks.Localidad.seleccionarPorDepartamento(departamentoSeleccionado.id_departamento);
                cmbLocalidades.Items.Clear();
                cmbLocalidades.Items.Add("Seleccione una localidad...");

                foreach (DataLayer.Models.ViLocalidad localidad in localidades)
                {
                    DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem()
                    {
                        ID = localidad.id_localidad,
                        Text = localidad.nombre_localidad
                    };
                    cmbLocalidades.Items.Add(cmbBoxItem);
                    this.cmbBoxLocalidadesItems.Add(cmbBoxItem);
                }

                cmbLocalidades.SelectedIndex = 0;

            }
            else if (cmbDepartamentos.SelectedIndex == 0)
                this.departamentoSeleccionado = new DataLayer.Models.Departamento();
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbLocalidades.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxLocalidadesItems[cmbLocalidades.SelectedIndex - 1];
                foreach (DataLayer.Models.ViLocalidad localidad in this.localidades)
                    if (localidad.id_localidad == selectedItem.ID)
                        this.localidadSeleccionada = localidad;
            }
            else if (cmbLocalidades.SelectedIndex == 0)
                this.localidadSeleccionada = new DataLayer.Models.ViLocalidad();
        }

        private async void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvContactos.SelectedRows.Count == 1)
            {
                if (rbCorreo.Checked)
                {
                    int idContactoCorreoSeleccionado = Convert.ToInt32(dgvContactos.SelectedRows[0].Cells[1].Value);
                    this.contactoCorreoSeleccionado = await DataLayer.Tasks.ContactoCorreo.seleccionar(idContactoCorreoSeleccionado);
                    tbCorreoCodigoCalle.Text = this.contactoCorreoSeleccionado.correo; 
                }
                else if (rbTelefono.Checked)
                {
                    int idContactoTelefonoSeleccionado = Convert.ToInt32(dgvContactos.SelectedRows[0].Cells[1].Value);
                    this.contactoTelefonoSeleccionado = await DataLayer.Tasks.ContactoTelefono.seleccionar(idContactoTelefonoSeleccionado);
                    tbCorreoCodigoCalle.Text = this.contactoTelefonoSeleccionado.codigo_pais;
                    tbNumeros.Text = this.contactoTelefonoSeleccionado.numero;
                }
                else
                {
                    int idContactoDireccionSeleccionado = Convert.ToInt32(dgvContactos.SelectedRows[0].Cells[1].Value);
                    this.contactoDireccionSeleccionado = await DataLayer.Tasks.ContactoDireccion.seleccionar(idContactoDireccionSeleccionado);
                    tbCorreoCodigoCalle.Text = this.contactoDireccionSeleccionado.calle;
                    tbNumeros.Text = this.contactoDireccionSeleccionado.numero_casa;
                    tbZona.Text = this.contactoDireccionSeleccionado.zona;
                    tbDetalles.Text = this.contactoDireccionSeleccionado.detalles;

                    //seleccionar el ComboBox segun el departamento -> localidad
                    this.localidadSeleccionada = await DataLayer.Tasks.Localidad.seleccionar(this.contactoDireccionSeleccionado.id_localidad);
                    int i = 1;
                    foreach (DataLayer.ComboboxItem item in cmbBoxLocalidadesItems)
                    {
                        if (localidadSeleccionada.id_localidad == item.ID)
                        {
                            cmbLocalidades.SelectedIndex = i; 
                            break;
                        }
                        i++;
                    }
                }
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
            }
        }
        #endregion

        #region Metodos Auxiliares
        private async void CargarCorreos()
        {
            List<DataLayer.Models.ViEntidadContactoCorreo> correos = await DataLayer.Tasks.ContactoCorreo.listarPorEntidad(this.id_entidad);
            if (correos.Count > 0)
                CreateDataSource(correos);
            else
                dgvContactos.DataSource = null;
        }

        private async void CargarTelefonos()
        {
            List<DataLayer.Models.ViEntidadContactoTelefono> telefonos = await DataLayer.Tasks.ContactoTelefono.listarPorEntidad(this.id_entidad);
            if (telefonos.Count > 0)
                CreateDataSource(telefonos);
            else
                dgvContactos.DataSource = null;
        }

        private async void CargarDirecciones()
        {
            List<DataLayer.Models.ViEntidadContactoDireccion> direcciones = await DataLayer.Tasks.ContactoDireccion.listarPorEntidad(this.id_entidad);
            if (direcciones.Count > 0)
                CreateDataSource(direcciones);
            else
                dgvContactos.DataSource = null;
        }

        private void CreateDataSource(List<DataLayer.Models.ViEntidadContactoCorreo> contactos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < contactos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_entidad"].SetOrdinal(0);
            dtDatos.Columns["id_contacto_correo"].SetOrdinal(1);
            dtDatos.Columns["id_contacto"].SetOrdinal(2);
            dtDatos.Columns["correo"].SetOrdinal(3);

            dgvContactos.DataSource = dtDatos;
            dgvContactos.Columns[3].HeaderText = "Correo";
            dgvContactos.Columns[0].Width = 0;
            dgvContactos.Columns[1].Width = 0;
            dgvContactos.Columns[2].Width = 0;
            dgvContactos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContactos.Refresh();
            dgvContactos.ClearSelection();
            this.loading = false;
        }

        private void CreateDataSource(List<DataLayer.Models.ViEntidadContactoTelefono> contactos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < contactos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_entidad"].SetOrdinal(0);
            dtDatos.Columns["id_contacto_telefono"].SetOrdinal(1);
            dtDatos.Columns["id_contacto"].SetOrdinal(2);
            dtDatos.Columns["codigo_pais"].SetOrdinal(3);
            dtDatos.Columns["numero"].SetOrdinal(4);

            dgvContactos.DataSource = dtDatos;
            dgvContactos.Columns[3].HeaderText = "Código";
            dgvContactos.Columns[4].HeaderText = "Número";
            dgvContactos.Columns[0].Width = 0;
            dgvContactos.Columns[1].Width = 0;
            dgvContactos.Columns[2].Width = 0;
            dgvContactos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContactos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContactos.Refresh();
            dgvContactos.ClearSelection();
            this.loading = false;
        }

        private void CreateDataSource(List<DataLayer.Models.ViEntidadContactoDireccion> contactos)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < contactos.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(contactos[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_entidad"].SetOrdinal(0);
            dtDatos.Columns["id_contacto_direccion"].SetOrdinal(1);
            dtDatos.Columns["id_contacto"].SetOrdinal(2);
            dtDatos.Columns["id_localidad"].SetOrdinal(3);
            dtDatos.Columns["id_departamento"].SetOrdinal(4);
            dtDatos.Columns["nombre_departamento"].SetOrdinal(5);
            dtDatos.Columns["nombre_localidad"].SetOrdinal(6);
            dtDatos.Columns["calle"].SetOrdinal(7);
            dtDatos.Columns["numero_casa"].SetOrdinal(8);
            dtDatos.Columns["zona"].SetOrdinal(9);
            dtDatos.Columns["detalles"].SetOrdinal(10);

            dgvContactos.DataSource = dtDatos;
            dgvContactos.Columns[5].HeaderText = "Departamento";
            dgvContactos.Columns[6].HeaderText = "Localidad";
            dgvContactos.Columns[7].HeaderText = "Calle";
            dgvContactos.Columns[8].HeaderText = "# Casa";
            dgvContactos.Columns[9].HeaderText = "Zona";
            dgvContactos.Columns[10].HeaderText = "Detalles";
            dgvContactos.Columns[0].Width = 0;
            dgvContactos.Columns[1].Width = 0;
            dgvContactos.Columns[2].Width = 0;
            dgvContactos.Columns[3].Width = 0;
            dgvContactos.Columns[4].Width = 0;
            dgvContactos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContactos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvContactos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvContactos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvContactos.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvContactos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContactos.Refresh();
            dgvContactos.ClearSelection();
            this.loading = false;
        }

        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbCorreoCodigoCalle.Enabled = false;
                    tbDetalles.Enabled = false;
                    tbNumeros.Enabled = false;
                    tbZona.Enabled = false;
                    cmbDepartamentos.Enabled = false;
                    cmbLocalidades.Enabled = false;
                    tbCorreoCodigoCalle.Text = String.Empty;
                    tbDetalles.Text = String.Empty;
                    tbNumeros.Text = String.Empty;
                    tbZona.Text = String.Empty;
                    cmbDepartamentos.SelectedIndex = 0;
                    cmbLocalidades.SelectedIndex = 0;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    rbCorreo.Enabled = true;
                    rbDireccion.Enabled = true;
                    rbTelefono.Enabled = true;

                    dgvContactos.ReadOnly = false;
                    dgvContactos.ClearSelection();
                    break;
                case "agregar":
                    tbCorreoCodigoCalle.Enabled = true;
                    tbDetalles.Enabled = true;
                    tbNumeros.Enabled = true;
                    tbZona.Enabled = true;
                    cmbDepartamentos.Enabled = true;
                    cmbLocalidades.Enabled = true;
                    tbCorreoCodigoCalle.Text = String.Empty;
                    tbDetalles.Text = String.Empty;
                    tbNumeros.Text = String.Empty;
                    tbZona.Text = String.Empty;
                    cmbDepartamentos.SelectedIndex = 0;
                    cmbLocalidades.SelectedIndex = 0;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    rbCorreo.Enabled = false;
                    rbDireccion.Enabled = false;
                    rbTelefono.Enabled = false;

                    dgvContactos.ClearSelection();
                    dgvContactos.ReadOnly = true;
                    break;
                case "actualizar":
                    tbCorreoCodigoCalle.Enabled = true;
                    tbDetalles.Enabled = true;
                    tbNumeros.Enabled = true;
                    tbZona.Enabled = true;
                    cmbDepartamentos.Enabled = true;
                    cmbLocalidades.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    rbCorreo.Enabled = false;
                    rbDireccion.Enabled = false;
                    rbTelefono.Enabled = false;

                    dgvContactos.ReadOnly = true;
                    break;
            }
        }

        private async void RefreshData()
        {
            if (this.rbCorreo.Checked)
            {
                List<DataLayer.Models.ViEntidadContactoCorreo> correos = await DataLayer.Tasks.ContactoCorreo.listarPorEntidad(this.id_entidad);
                CreateDataSource(correos);
            }
            else if (this.rbTelefono.Checked)
            {
                List<DataLayer.Models.ViEntidadContactoTelefono> telefonos = await DataLayer.Tasks.ContactoTelefono.listarPorEntidad(this.id_entidad);
                CreateDataSource(telefonos);
            }
            else
            {
                List<DataLayer.Models.ViEntidadContactoDireccion> direcciones = await DataLayer.Tasks.ContactoDireccion.listarPorEntidad(this.id_entidad);
                CreateDataSource(direcciones);
            }
        }

        private void SwitchControls(String state)
        {
            switch (state)
            {
                case "correos":
                    lblDepartamento.Visible = false;
                    lblLocalidad.Visible = false;
                    cmbDepartamentos.Visible = false;
                    cmbLocalidades.Visible = false;
                    lblNumeros.Visible = false;
                    tbNumeros.Visible = false;
                    lblZona.Visible = false;
                    tbZona.Visible = false;
                    lblDetalles.Visible = false;
                    tbDetalles.Visible = false;


                    lblCorreoCodigoCalle.Text = "Correo:";
                    tbCorreoCodigoCalle.Text = String.Empty;
                    break;
                case "telefonos":
                    lblDepartamento.Visible = false;
                    lblLocalidad.Visible = false;
                    cmbDepartamentos.Visible = false;
                    cmbLocalidades.Visible = false;
                    lblZona.Visible = false;
                    tbZona.Visible = false;
                    lblDetalles.Visible = false;
                    tbDetalles.Visible = false;

                    lblNumeros.Visible = true;
                    tbNumeros.Visible = true;

                    lblCorreoCodigoCalle.Text = "Código:";
                    tbCorreoCodigoCalle.Text = String.Empty;
                    tbNumeros.Text = String.Empty;

                    break;
                case "direcciones":
                    lblDepartamento.Visible = true;
                    lblLocalidad.Visible = true;
                    cmbDepartamentos.Visible = true;
                    cmbLocalidades.Visible = true;
                    lblZona.Visible = true;
                    tbZona.Visible = true;
                    lblDetalles.Visible = true;
                    tbDetalles.Visible = true;
                    lblNumeros.Visible = true;
                    tbNumeros.Visible = true;

                    lblCorreoCodigoCalle.Text = "Calle:";
                    tbCorreoCodigoCalle.Text = String.Empty;
                    tbNumeros.Text = String.Empty;
                    tbZona.Text = String.Empty;
                    tbDetalles.Text = String.Empty;
                    break;
            }
        }


        private async void BuscarEntidad()
        {
            bool found = false;
            DataLayer.Models.ViCliente cliente_temp = await DataLayer.Tasks.Cliente.seleccionar(this.id_entidad);
            if (cliente_temp != null)
            {
                this.Text += " - Cliente - " + cliente_temp.razon_social;
                found = true;
            }
            if (!found)
            {
                DataLayer.Models.ViUsuario usuario_temp = await DataLayer.Tasks.Usuario.seleccionar(this.id_entidad);
                if (usuario_temp != null)
                {
                    this.Text += " - Usuario - " + usuario_temp.login_usuario;
                    found = true;
                }
                    
            }

            if (!found)
            {
                DataLayer.Models.ViProveedor proveedor_temp = await DataLayer.Tasks.Proveedor.seleccionar(this.id_entidad);
                if (proveedor_temp != null)
                {
                    this.Text += " - Proveedor - " + proveedor_temp.nombre;
                    found = true;
                }
            }
        }
        #endregion
    }
}
