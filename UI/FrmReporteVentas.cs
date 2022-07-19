using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmGeneradorReportes : Form
    {

        private DateTime fechaInicial;
        private DateTime fechaFinal;
        private Button botonSeleccionado;
        private string tipoReporte; 

        public FrmGeneradorReportes()
        {
            InitializeComponent();
            fechaInicial = DateTime.Now;
            fechaFinal = DateTime.Now;
            fechaFinal.AddDays(-1);
            this.tipoReporte = "Venta"; //Venta-Compra-Ganancia
            bReporteVentas.BackColor = Color.Aquamarine;
        }

        private async void bGenerar_Click(object sender, EventArgs e)
        {
            DataLayer.Models.ReporteResponse reporte = new DataLayer.Models.ReporteResponse() 
            { 
                status_code=0, report_url="None"
            };
            if(this.tipoReporte == "Venta")
            {
                reporte = await DataLayer.Tasks.Reportes.listarReporteVentasSinProducto(this.fechaInicial, this.fechaFinal);
            }
            else if (this.tipoReporte == "Compra")
            {
                reporte = await DataLayer.Tasks.Reportes.listarReporteComprasSinProducto(this.fechaInicial, this.fechaFinal);
            }
            else if (this.tipoReporte == "Ganancia")
            {
                reporte = await DataLayer.Tasks.Reportes.listarReporteGananciasSinProducto(this.fechaInicial, this.fechaFinal);
            }

            Process process = new Process();

            process.StartInfo.FileName = reporte.report_url;
            process.StartInfo.UseShellExecute = true;
            process.Start();

            process.WaitForExit();
            process.Kill();
        }

        private void FrmGeneradorReportes_Load(object sender, EventArgs e)
        {

        }


        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbPredeterminados":
                        ChangeState("predeterminados");
                        break;
                    case "rbFiltrarFecha":
                        ChangeState("filtrar_fecha");
                        break;
                }
            }
        }

        private void ChangeState(string state)
        {
            if (state == "predeterminados")
            {
                bReporteDiarioHoy.Visible = true;
                bReporteDiarioAyer.Visible = true;
                bReporteSemanalActual.Visible = true;
                bReporteSemanalPasada.Visible = true;
                bReporteMensualActual.Visible = true;
                bReporteMensualPasado.Visible = true;
                bReporteAnualActual.Visible = true;
                bReporteAnualPasado.Visible = true;

                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
            }
            else
            {
                bReporteDiarioHoy.Visible = false;
                bReporteDiarioAyer.Visible = false;
                bReporteSemanalActual.Visible = false;
                bReporteSemanalPasada.Visible = false;
                bReporteMensualActual.Visible = false;
                bReporteMensualPasado.Visible = false;
                bReporteAnualActual.Visible = false;
                bReporteAnualPasado.Visible = false;

                lblDesde.Visible = true;
                lblHasta.Visible = true;
                dtpDesde.Visible = true;
                dtpHasta.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                lblProducto.Visible = true;
                bBuscar.Visible = true;
            }
            else
            {
                lblProducto.Visible = false;
                bBuscar.Visible = false;
            }
        }

        private void bTiposReporteClick(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            bReporteCompras.BackColor = Color.White;
            bReporteVentas.BackColor = Color.White;
            bReporteGanancias.BackColor = Color.White;
            switch (bt.Name)
            {
                case "bReporteVentas":
                    this.tipoReporte = "Venta";
                    bReporteVentas.BackColor = Color.Aquamarine;
                    break;
                case "bReporteCompras":
                    this.tipoReporte = "Compra";
                    bReporteCompras.BackColor = Color.Aquamarine;
                    break;
                case "bReporteGanancias":
                    this.tipoReporte = "Ganancia";
                    bReporteGanancias.BackColor = Color.Aquamarine;
                    break;
            }
        }
        private void cambioFechasClick(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "Button")
            {
                var bt = (Button)sender;
                bReporteDiarioHoy.BackColor = Color.White;
                bReporteDiarioAyer.BackColor = Color.White;
                bReporteSemanalActual.BackColor = Color.White;
                bReporteSemanalPasada.BackColor = Color.White;
                bReporteMensualActual.BackColor = Color.White;
                bReporteMensualPasado.BackColor = Color.White;
                bReporteAnualActual.BackColor = Color.White;
                bReporteAnualPasado.BackColor = Color.White;

                bt.BackColor = Color.Aquamarine;
                switch (bt.Name)
                {
                    case "bReporteDiarioHoy":
                        this.fechaInicial = DateTime.Today;
                        this.fechaFinal = DateTime.Today.AddDays(1);
                        break;
                    case "bReporteDiarioAyer":
                        this.fechaInicial = DateTime.Today.AddDays(-1);
                        this.fechaFinal = DateTime.Today;
                        break;
                    case "bReporteSemanalActual":
                        this.fechaInicial = DateTime.Today.AddDays(-Convert.ToInt32(DateTime.Today.DayOfWeek));
                        this.fechaFinal = DateTime.Today;
                        break;
                    case "bReporteSemanalPasada":
                        this.fechaInicial = DateTime.Today.AddDays(-Convert.ToInt32(DateTime.Today.DayOfWeek) - 7);
                        this.fechaFinal = DateTime.Today.AddDays(-Convert.ToInt32(DateTime.Today.DayOfWeek));
                        break;
                    case "bReporteMensualActual":
                        this.fechaInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        this.fechaFinal = DateTime.Now;
                        break;
                    case "bReporteMensualPasado":
                        this.fechaInicial = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
                        this.fechaFinal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                        break;
                    case "bReporteAnualActual":
                        this.fechaInicial = new DateTime(DateTime.Today.Year, 1, 1);
                        this.fechaFinal = DateTime.Now;
                        break;
                    case "bReporteAnualPasado":
                        this.fechaInicial = new DateTime(DateTime.Today.Year - 1, 1, 1);
                        this.fechaFinal = new DateTime(DateTime.Today.Year, 1, 1);
                        break;
                }
            }
            else if (sender.GetType().Name == "DateTimePicker")
            {
                this.fechaInicial = dtpDesde.Value;
                this.fechaFinal = dtpHasta.Value;
            }
        }
    }
}
