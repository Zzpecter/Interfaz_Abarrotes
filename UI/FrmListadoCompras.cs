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
    public partial class FrmListadoCompras : Form
    {
        #region Variables y Carga
        private DataTable dtDatos;
        private List<DataLayer.Models.ViCompraProveedor> listaCompras = new List<DataLayer.Models.ViCompraProveedor>();
        private DataLayer.Models.ViCompraProveedor compraSeleccionada;
        private DateTime MAX_DATE = new DateTime(2200, 12, 31);
        private DateTime MIN_DATE = new DateTime(2000, 1, 1);
        private bool loading;

        public FrmListadoCompras()
        {
            InitializeComponent();
        }

        private void FrmListadoCompras_Load(object sender, EventArgs e)
        {
            rbFiltrarTodo.Checked = true;
            loading = true;
            dtpHasta.Value = MAX_DATE;
            dtpDesde.Value = MIN_DATE;
            loading = false;
        }
        #endregion

        #region Botones y Controles
        private async void rbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbFiltrarTodo":
                        ChangeState("filtrar_todo");
                        listaCompras = await DataLayer.Tasks.Compra.listarCompraProveedor();
                        break;
                    case "rbFiltrarFecha":
                        ChangeState("filtrar_fecha");
                        listaCompras = await DataLayer.Tasks.Compra.buscarPorFecha(dtpDesde.Value, dtpHasta.Value);
                        break;
                    case "rbFiltrarProveedor":
                        ChangeState("filtrar_cliente");
                        listaCompras = await DataLayer.Tasks.Compra.listarCompraProveedor();
                        break;
                }

                if (listaCompras.Count > 0)
                    CreateDataSource();
                else
                {
                    dgvCompras.DataSource = null;
                    dgvCompras.Refresh();
                }
            }
        }

        private async void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                listaCompras = await DataLayer.Tasks.Compra.buscarPorFecha(dtpDesde.Value, dtpHasta.Value);
                if (listaCompras.Count > 0)
                    CreateDataSource();
                else
                {
                    dgvCompras.DataSource = null;
                    dgvCompras.Refresh();
                }
            }
        }

        private async void tbNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbNombreProveedor.Text == String.Empty)
                listaCompras = await DataLayer.Tasks.Compra.listarCompraProveedor();
            else
                listaCompras = await DataLayer.Tasks.Compra.buscarPorProveedor(tbNombreProveedor.Text);
            if (listaCompras.Count > 0)
                CreateDataSource();
            else
            {
                dgvCompras.DataSource = null;
                dgvCompras.Refresh();
            }
        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbDesde.Checked)
            {
                dtpDesde.Value = MIN_DATE;
                dtpDesde.Enabled = false;
            }
            else
                dtpDesde.Enabled = true;
            if (!cbHasta.Checked)
            {
                dtpHasta.Value = MAX_DATE;
                dtpHasta.Enabled = false;
            }
            else
                dtpHasta.Enabled = true;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
        #endregion

        #region Métodos Auxiliares
        private void ChangeState(string formState)
        {
            switch (formState)
            {
                case "filtrar_todo":
                    cbDesde.Visible = false;
                    cbHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                    tbNombreProveedor.Visible = false;
                    lblNombreCliente.Visible = false;
                    break;
                case "filtrar_fecha":
                    cbDesde.Visible = true;
                    cbHasta.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                    tbNombreProveedor.Visible = false;
                    lblNombreCliente.Visible = false;
                    break;
                case "filtrar_cliente":
                    cbDesde.Visible = false;
                    cbHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                    tbNombreProveedor.Visible = true;
                    lblNombreCliente.Visible = true;
                    break;
            }
        }

        private void CreateDataSource()
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.listaCompras[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < this.listaCompras.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.listaCompras[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }

            loading = true;
            dtDatos.Columns.Remove("id_usuario");
            dtDatos.Columns.Remove("id_proveedor");

            dtDatos.Columns["id_compra"].SetOrdinal(0);
            dtDatos.Columns["fecha"].SetOrdinal(1);
            dtDatos.Columns["proveedor"].SetOrdinal(2);
            dtDatos.Columns["usuario"].SetOrdinal(3);
            dtDatos.Columns["monto_total"].SetOrdinal(4);

            dgvCompras.DataSource = dtDatos;
            dgvCompras.Columns[0].Width = 0;
            dgvCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompras.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCompras.Refresh();
            dgvCompras.ClearSelection();
            loading = false;
        }


        #endregion

        private void bDetalles_Click(object sender, EventArgs e)
        {
            FrmDetallesCompra frm = new FrmDetallesCompra(this.compraSeleccionada.id_compra);
            frm.ShowDialog();
        }

        private async void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (loading == false && dgvCompras.SelectedRows.Count == 1)
            {
                int idCompraSeleccionada = Convert.ToInt32(dgvCompras.SelectedRows[0].Cells[0].Value);
                this.compraSeleccionada = await DataLayer.Tasks.Compra.seleccionarCompraProveedor(idCompraSeleccionada);
                bDetalles.Enabled = true;
            }
            else
                bDetalles.Enabled = false;
        }
    }
}
