using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViVenta
    {
        public int id_salida_producto { get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public int id_factura { get; set; }
        public decimal monto_total { get; set; }
        public DateTime fecha { get; set; }
    }
    public class ViVentaCliente : ViVenta
    {
        public int id_venta { get; set; }
        public string usuario { get; set; }
        public string cliente { get; set; }
        public string nit_ci { get; set; }
    }
    public class Venta : ViVenta
    {
        public string usuario_registro { get; set; }
    }
}
