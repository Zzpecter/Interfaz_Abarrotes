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
    public partial class FrmListadoVentas : Form
    {
        #region Variables y Carga
        private DataTable dtDatos;
        private List<DataLayer.Models.ViVentaCliente> listaVentas = new List<DataLayer.Models.ViVentaCliente>();
        private DataLayer.Models.ViVentaCliente ventaSeleccionada;
        private DateTime MAX_DATE = new DateTime(2200, 12, 31);
        private DateTime MIN_DATE = new DateTime(2000, 1, 1);
        private bool loading;
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
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
                        listaVentas = await DataLayer.Tasks.Venta.listarVentaCliente();
                        if (listaVentas.Count > 0)
                            CreateDataSource();
                        else
                        {
                            dgvVentas.DataSource = null;
                            dgvVentas.Refresh();
                        }
                        break;
                    case "rbFiltrarFecha":
                        ChangeState("filtrar_fecha");
                        listaVentas = await DataLayer.Tasks.Venta.buscarPorFecha(dtpDesde.Value, dtpHasta.Value);
                        if (listaVentas.Count > 0)
                            CreateDataSource();
                        else
                        {
                            dgvVentas.DataSource = null;
                            dgvVentas.Refresh();
                        }
                        break;
                    case "rbFiltrarCliente":
                        ChangeState("filtrar_cliente");
                        listaVentas = await DataLayer.Tasks.Venta.listarVentaCliente();
                        if (listaVentas.Count > 0)
                            CreateDataSource();
                        else
                        {
                            dgvVentas.DataSource = null;
                            dgvVentas.Refresh();
                        }
                        break;
                }
            }
        }

        private async void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                listaVentas = await DataLayer.Tasks.Venta.buscarPorFecha(dtpDesde.Value, dtpHasta.Value);
                if (listaVentas.Count > 0)
                    CreateDataSource();
                else
                {
                    dgvVentas.DataSource = null;
                    dgvVentas.Refresh();
                }
            }
        }

        private async void tbNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbNombreCliente.Text == String.Empty)
                listaVentas = await DataLayer.Tasks.Venta.listarVentaCliente();
            else
                listaVentas = await DataLayer.Tasks.Venta.buscarPorCliente(tbNombreCliente.Text);
            if (listaVentas.Count > 0)
                CreateDataSource();
            else
            {
                dgvVentas.DataSource = null;
                dgvVentas.Refresh();
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
                    tbNombreCliente.Visible = false;
                    lblNombreCliente.Visible = false;
                    break;
                case "filtrar_fecha":
                    cbDesde.Visible = true;
                    cbHasta.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                    tbNombreCliente.Visible = false;
                    lblNombreCliente.Visible = false;
                    break;
                case "filtrar_cliente":
                    cbDesde.Visible = false;
                    cbHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                    tbNombreCliente.Visible = true;
                    lblNombreCliente.Visible = true;
                    break;
            }
        }

        private void CreateDataSource()
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.listaVentas[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < this.listaVentas.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.listaVentas[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }

            loading = true;
            dtDatos.Columns.Remove("id_usuario");
            dtDatos.Columns.Remove("id_cliente");

            dtDatos.Columns["id_venta"].SetOrdinal(0);
            dtDatos.Columns["id_factura"].SetOrdinal(1);
            dtDatos.Columns["fecha"].SetOrdinal(2);
            dtDatos.Columns["nit_ci"].SetOrdinal(3);
            dtDatos.Columns["cliente"].SetOrdinal(4);
            dtDatos.Columns["usuario"].SetOrdinal(5);
            dtDatos.Columns["monto_total"].SetOrdinal(6);

            dgvVentas.DataSource = dtDatos;
            dgvVentas.Columns[0].Width = 0;
            dgvVentas.Columns[1].Width = 0;
            dgvVentas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVentas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVentas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVentas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVentas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVentas.Refresh();
            dgvVentas.ClearSelection();
            loading = false;
        }

        #endregion

        private async void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (loading == false && dgvVentas.SelectedRows.Count == 1)
            {
                int idVentaSeleccionada = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells[0].Value);
                this.ventaSeleccionada = await DataLayer.Tasks.Venta.seleccionarVentaCliente(idVentaSeleccionada);
                bDetalles.Enabled = true;
            }
            else
                bDetalles.Enabled = false;
        }

        private void bDetalles_Click(object sender, EventArgs e)
        {
            //abrir FrmDetallesVenta
            FrmDetallesVenta frm = new FrmDetallesVenta(this.ventaSeleccionada.id_venta);
            frm.ShowDialog();
        }
    }
}