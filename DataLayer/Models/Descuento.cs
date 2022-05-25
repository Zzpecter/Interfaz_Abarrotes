using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViDescuento
    {
        public int id_descuento { get; set; }
        public int id_producto { get; set; }
        public decimal precio_oferta { get; set; }
        public DateTime fecha_expiracion { get; set; }
    }

    public class ViDescuentoProducto : ViDescuento
    {
        public int id_presentacion_producto { get; set; }
        public int id_unidad_presentacion { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta_original { get; set; }
    }

    public class Descuento : ViDescuento
    {
        public string usuario_registro { get; set; }
    }
}
