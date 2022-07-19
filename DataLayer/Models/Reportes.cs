using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class DocumentoReporte
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public string filePath { get; set; }
    }

    public class ReporteResponse
    {
        public int status_code { get; set; }
        public string report_url { get; set; }
    }
    public class ReporteVentas
    {
        public int id_producto { get; set; }
        public string producto { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
        public decimal cantidad { get; set; }
        public decimal total_bs { get; set; }
        public DateTime fecha { get; set; }
    }

    public class ReporteCompras
    {
        public int id_producto { get; set; }
        public string producto { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
        public decimal cantidad { get; set; }
        public decimal total_bs { get; set; }
        public DateTime fecha { get; set; }
    }

    public class ReporteGanancias
    {
        public int id_producto { get; set; }
        public string producto { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
        public decimal unidades_compradas { get; set; }
        public decimal unidades_vendidas { get; set; }
        public decimal gasto_total { get; set; }
        public decimal ingreso_total { get; set; }
        public decimal ganancia_vendidos { get; set; }
        public decimal ganancia_total { get; set; }
        public DateTime fecha { get; set; }
    }
}
