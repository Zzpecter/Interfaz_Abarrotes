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
    public partial class FrmPresentacionProducto : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViPresentacionProducto presentacionSeleccionada;
        private DataLayer.Models.ViUnidadPresentacion unidadSeleccionada;
        private List<DataLayer.Models.ViUnidadPresentacion> unidades;
        private List<DataLayer.ComboboxItem> cmbBoxUnidadesItems;
        private bool loading;

        public FrmPresentacionProducto()
        {
            InitializeComponent();
            this.cmbBoxUnidadesItems = new List<DataLayer.ComboboxItem>();
        }

        private async void FrmPresentacionProducto_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.ViPresentacionUnidad> presentaciones = await DataLayer.Tasks.PresentacionProducto.listar();
            CreateDataSource(presentaciones);


            unidades = await DataLayer.Tasks.UnidadPresentacion.listar();  // listar las unidades para el cmbBox
            cmbUnidades.Items.Clear();
            cmbUnidades.Items.Add("Seleccione una unidad...");

            foreach (DataLayer.Models.ViUnidadPresentacion unidad in unidades)
            {
                DataLayer.ComboboxItem cmbBoxItem = new DataLayer.ComboboxItem() 
                { 
                    ID = unidad.id_unidad_presentacion, 
                    Text = unidad.nombre_medida
                };
                cmbUnidades.Items.Add(cmbBoxItem);
                this.cmbBoxUnidadesItems.Add(cmbBoxItem);    
            }

            cmbUnidades.SelectedIndex = 0;
            cmbUnidades.Enabled = false;
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
            if (dgvPresentaciones.SelectedRows.Count == 1)
            {
                int statusCode = await DataLayer.Tasks.PresentacionProducto.eliminar(presentacionSeleccionada.id_presentacion_producto);

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
                    if (tbNombrePresentacion.Text != String.Empty && cmbUnidades.SelectedIndex > 0)
                    {
                        //Crear e insertar la unidad de presentacion
                        DataLayer.Models.PresentacionProducto presentacionProducto = new DataLayer.Models.PresentacionProducto()
                        {
                            id_unidad_presentacion = this.unidadSeleccionada.id_unidad_presentacion,
                            nombre_presentacion = tbNombrePresentacion.Text,
                            permite_cantidad_fraccionada = this.cbCantidadFraccionada.Checked,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.PresentacionProducto.insertar(presentacionProducto);

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
                    if (tbNombrePresentacion.Text != String.Empty && cmbUnidades.SelectedIndex > 0)
                    {
                        DataLayer.Models.PresentacionProducto presentacionProducto = new DataLayer.Models.PresentacionProducto()
                        {
                            id_unidad_presentacion = this.unidadSeleccionada.id_unidad_presentacion,
                            nombre_presentacion = tbNombrePresentacion.Text,
                            permite_cantidad_fraccionada = this.cbCantidadFraccionada.Checked,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.PresentacionProducto.actualizar(presentacionProducto, presentacionSeleccionada.id_presentacion_producto);

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

        private async void dgvPresentaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvPresentaciones.SelectedRows.Count == 1)
            {
                int idPresentacionSeleccionada = Convert.ToInt32(dgvPresentaciones.SelectedRows[0].Cells[0].Value);
                this.presentacionSeleccionada = await DataLayer.Tasks.PresentacionProducto.seleccionar(idPresentacionSeleccionada);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbNombrePresentacion.Text = presentacionSeleccionada.nombre_presentacion;

                //seleccionar el ComboBox segun la unidad
                this.unidadSeleccionada = await DataLayer.Tasks.UnidadPresentacion.seleccionar(presentacionSeleccionada.id_unidad_presentacion);
                int i = 1;
                foreach (DataLayer.ComboboxItem item in cmbBoxUnidadesItems)
                {
                    if (unidadSeleccionada.id_unidad_presentacion == item.ID)
                        cmbUnidades.SelectedIndex = i;
                    i++;
                }
            }
        }

        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loading == false && cmbUnidades.SelectedIndex > 0)
            {
                DataLayer.ComboboxItem selectedItem = cmbBoxUnidadesItems[cmbUnidades.SelectedIndex - 1];
                foreach (DataLayer.Models.ViUnidadPresentacion unidad in this.unidades)
                    if (unidad.id_unidad_presentacion == selectedItem.ID)
                        this.unidadSeleccionada = unidad;
            }
            else if (cmbUnidades.SelectedIndex == 0)
                this.unidadSeleccionada = new DataLayer.Models.ViUnidadPresentacion();
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbNombrePresentacion.Enabled = false;
                    cmbUnidades.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvPresentaciones.ReadOnly = false;
                    dgvPresentaciones.ClearSelection();
                    break;
                case "agregar":
                    tbNombrePresentacion.Enabled = true;
                    tbNombrePresentacion.Text = String.Empty;
                    cmbUnidades.Enabled = true;
                    cmbUnidades.SelectedIndex = 0;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvPresentaciones.ClearSelection();
                    dgvPresentaciones.ReadOnly = true;
                    break;
                case "actualizar":
                    tbNombrePresentacion.Enabled = true;
                    cmbUnidades.Enabled= true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvPresentaciones.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViPresentacionUnidad> presentaciones)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(presentaciones[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < presentaciones.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(presentaciones[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_presentacion_producto"].SetOrdinal(0);
            dtDatos.Columns["id_unidad_presentacion"].SetOrdinal(1);
            dtDatos.Columns["nombre_presentacion"].SetOrdinal(2);
            dtDatos.Columns["nombre_medida"].SetOrdinal(3);
            dtDatos.Columns["multiplicador_kg"].SetOrdinal(4);

            dgvPresentaciones.DataSource = dtDatos;
            dgvPresentaciones.Columns[2].HeaderText = "Presentacion";
            dgvPresentaciones.Columns[3].HeaderText = "Medida";
            dgvPresentaciones.Columns[4].HeaderText = "Multiplicador Kg.";
            dgvPresentaciones.Columns[0].Width = 0;
            dgvPresentaciones.Columns[1].Width = 0;
            dgvPresentaciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPresentaciones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvPresentaciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPresentaciones.Refresh();
            dgvPresentaciones.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViPresentacionUnidad> presentaciones = await DataLayer.Tasks.PresentacionProducto.listar();
            CreateDataSource(presentaciones);
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
