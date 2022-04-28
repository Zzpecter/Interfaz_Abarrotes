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
    public partial class FrmAlmacenes : Form
    {
        #region Inicializacion y Variables
        private DataTable dtDatos;
        private String formState = "init";
        private DataLayer.Models.ViAlmacen almacenSeleccionado;
        private bool loading;

        public FrmAlmacenes()
        {
            InitializeComponent();
        }

        private async void FrmAlmacenes_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.ViAlmacen> almacenes = await DataLayer.Tasks.Almacen.listar();
            CreateDataSource(almacenes);
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
            if (dgvAlmacenes.SelectedRows.Count == 1)
            {
                DataLayer.Models.ViProductoAlmacen productoAlmacen = await DataLayer.Tasks.ProductoAlmacen.seleccionarAlmacen(this.almacenSeleccionado.id_almacen);
                if (productoAlmacen.id_producto_almacen == -1)
                {
                    int statusCode = await DataLayer.Tasks.Almacen.eliminar(almacenSeleccionado.id_almacen);
                    if (statusCode == 200)
                        RefreshData();
                }
                else
                    MessageBox.Show(DataLayer.Globals.MSJ_ALMACEN_CONTIENE_PRODUCTOS, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                formState = "init";
                ChangeState();
            }
        }

        private async void bGuardar_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case "agregar":
                    if (tbAlmacen.Text != String.Empty)
                    {
                        //Crear e insertar el almacen
                        DataLayer.Models.Almacen almacen = new DataLayer.Models.Almacen()
                        {
                            descripcion = tbAlmacen.Text,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Almacen.insertar(almacen);

                        if (statusCode == 201)
                            RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese un nombre de almacen antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
                case "actualizar":
                    if (tbAlmacen.Text != String.Empty)
                    {
                        DataLayer.Models.Almacen almacen = new DataLayer.Models.Almacen()
                        {
                            descripcion = tbAlmacen.Text,
                            usuario_registro = Sesion.login_usuario
                        };
                        int statusCode = await DataLayer.Tasks.Almacen.actualizar(almacen, almacenSeleccionado.id_almacen);

                        if (statusCode == 200)
                            RefreshData();
                        formState = "init";
                        ChangeState();
                    }
                    else
                        MessageBox.Show("Ingrese un nombre de almacen antes de guardar!", "Error!", MessageBoxButtons.OK);
                    break;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            formState = "init";
            ChangeState();
        }
        
        private async void dgvAlmacenes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.loading == false && dgvAlmacenes.SelectedRows.Count == 1)
            {
                int idAlmacenSeleccionado = Convert.ToInt32(dgvAlmacenes.SelectedRows[0].Cells[0].Value);
                this.almacenSeleccionado = await DataLayer.Tasks.Almacen.seleccionar(idAlmacenSeleccionado);
                bActualizar.Enabled = true;
                bElimiar.Enabled = true;
                tbAlmacen.Text = almacenSeleccionado.descripcion;
            }
        }
        #endregion

        #region Metodos Auxiliares
        private void ChangeState()
        {
            switch (formState)
            {
                case "init":
                    tbAlmacen.Enabled = false;

                    bGuardar.Visible = false;
                    bCancelar.Visible = false;
                    bAgregar.Enabled = true;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvAlmacenes.ReadOnly = false;
                    dgvAlmacenes.ClearSelection();
                    break;
                case "agregar":
                    tbAlmacen.Enabled = true;
                    tbAlmacen.Text = String.Empty;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvAlmacenes.ClearSelection();
                    dgvAlmacenes.ReadOnly = true;
                    break;
                case "actualizar":
                    tbAlmacen.Enabled = true;

                    bGuardar.Visible = true;
                    bCancelar.Visible = true;
                    bAgregar.Enabled = false;
                    bActualizar.Enabled = false;
                    bElimiar.Enabled = false;

                    dgvAlmacenes.ReadOnly = true;
                    break;
            }
        }

        private void CreateDataSource(List<DataLayer.Models.ViAlmacen> almacenes)
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(almacenes[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < almacenes.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(almacenes[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }
            this.loading = true;
            dtDatos.Columns["id_almacen"].SetOrdinal(0);
            dtDatos.Columns["descripcion"].SetOrdinal(1);

            dgvAlmacenes.DataSource = dtDatos;
            dgvAlmacenes.Columns[0].HeaderText = "ID";
            dgvAlmacenes.Columns[1].HeaderText = "Descripcion";
            dgvAlmacenes.Columns[0].Width = 0;
            dgvAlmacenes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAlmacenes.Refresh();
            dgvAlmacenes.ClearSelection();
            this.loading = false;
        }

        private async void RefreshData()
        {
            List<DataLayer.Models.ViAlmacen> almacenes = await DataLayer.Tasks.Almacen.listar();
            CreateDataSource(almacenes);
        }
        #endregion
    }
}
