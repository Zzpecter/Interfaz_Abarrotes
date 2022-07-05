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
}
