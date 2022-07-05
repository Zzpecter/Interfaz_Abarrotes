using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmListadoReportes : Form
    {
        #region Variables y Carga
        private DataTable dtDatos;
        private bool loading;
        private List<DataLayer.Models.DocumentoReporte> reportes = new List<DataLayer.Models.DocumentoReporte>();
        private DataLayer.Models.DocumentoReporte reporteSeleccionado;

        public FrmListadoReportes()
        {
            InitializeComponent();
            this.reporteSeleccionado = new DataLayer.Models.DocumentoReporte();
        }

        private void FrmListadoReportes_Load(object sender, EventArgs e)
        {
            this.ListarReportes();
            this.CreateDataSource();
        }
        #endregion

        #region Botones y Controles
        private void bVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            //Imprimir
            Process process = new Process();

            process.StartInfo.FileName = this.reporteSeleccionado.filePath;
            process.StartInfo.Verb = "print";
            process.StartInfo.UseShellExecute = true;
            process.Start();

            process.WaitForInputIdle();
            process.Kill();
        }

        private void bAbrir_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            process.StartInfo.FileName = this.reporteSeleccionado.filePath;
            process.StartInfo.UseShellExecute = true;
            process.Start();

            process.WaitForExit();
            process.Kill();
        }

        private void dgvReportes_SelectionChanged(object sender, EventArgs e)
        {
            if (loading == false && dgvReportes.SelectedRows.Count == 1)
            {
                int idReporte = Convert.ToInt32(dgvReportes.SelectedRows[0].Cells[0].Value);
                this.reporteSeleccionado = GetReporte(idReporte);
                bImprimir.Enabled = true;
                bAbrir.Enabled = true;
            }
            else
            {
                bImprimir.Enabled = false;
                bAbrir.Enabled = false;
            }
        }

        #endregion
        
        #region Metodos de Apoyo
        private void CreateDataSource()
        {
            dtDatos = new DataTable();
            dtDatos.Clear();

            //metodo de ayuda para convertir las propiedades de una instancia en un dict.
            Dictionary<string, object> propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.reportes[0]);

            //Agregamos columnas segun los atributos del objeto 
            foreach (var item in propertyDict)
                dtDatos.Columns.Add(item.Key);
            //Agregamos filas
            for (int i = 0; i < this.reportes.Count; i++)
            {
                propertyDict = DataLayer.Helpers.DictionaryFromInstance(this.reportes[i]);
                DataRow _tempRow = dtDatos.NewRow();
                foreach (var item in propertyDict)
                    _tempRow[item.Key] = item.Value;
                dtDatos.Rows.Add(_tempRow);
            }

            loading = true;
            dtDatos.Columns.Remove("filepath");

            dtDatos.Columns["id"].SetOrdinal(0);
            dtDatos.Columns["tipo"].SetOrdinal(1);
            dtDatos.Columns["fechaDesde"].SetOrdinal(2);
            dtDatos.Columns["fechaHasta"].SetOrdinal(3);

            dgvReportes.DataSource = dtDatos;
            dgvReportes.Columns[0].Width = 0;
            dgvReportes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Refresh();
            dgvReportes.ClearSelection();
            loading = false;
        }

        private void ListarReportes()
        {
            //Listar reportes
            string reportsFolder = ConfigurationManager.AppSettings["FILEPATH_REPORTES"];
            string[] filenamesReportes = Directory.GetFiles(reportsFolder, "*.pdf", SearchOption.TopDirectoryOnly);

            int newID = 1;
            foreach (string filename in filenamesReportes)
            {
                string[] folders = filename.Split(new[] { "\\" }, StringSplitOptions.None);
                string reportName = folders[folders.Length - 1];
                string[] reportDetails = reportName.Split(new[] { "_" }, StringSplitOptions.None);

                DateTime fechaDesde = DataLayer.Helpers.DateFromString(reportDetails[2]);
                string[] fechaHastaAux = reportDetails[4].Split(new[] { "." }, StringSplitOptions.None);
                DateTime fechaHasta = DataLayer.Helpers.DateFromString(fechaHastaAux[0]);

                DataLayer.Models.DocumentoReporte doc = new DataLayer.Models.DocumentoReporte()
                {
                    id = newID,
                    tipo = reportDetails[0],
                    fechaDesde = fechaDesde,
                    fechaHasta = fechaHasta,
                    filePath = filename
                };

                this.reportes.Add(doc);
                newID++;
            }
        }

        private DataLayer.Models.DocumentoReporte GetReporte(int idReporte)
        {
            foreach( DataLayer.Models.DocumentoReporte reporte in this.reportes)
                if (reporte.id == idReporte)
                    return reporte;
            return new DataLayer.Models.DocumentoReporte() { id = -1 };
        }
        #endregion
    }
}
