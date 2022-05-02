using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViDetalleSalida
    {
        public int id_detalle_salida { get; set; }
        public int id_salida_producto { get; set; }
        public int id_producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio_unidad { get; set; }
    }

    public class ViDetalleSalidaProducto : ViDetalleSalida
    {
        public int id_presentacion_producto { get; set; }
        public int id_unidad_presentacion { get; set; }
        public string producto { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
    }

    public class DetalleSalida : ViDetalleSalida
    {
        public string usuario_registro { get; set; }
    }
}
