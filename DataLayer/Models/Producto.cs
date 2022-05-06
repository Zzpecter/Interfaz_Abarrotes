using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{

    public class ViProducto
    {
        public int id_producto { get; set; }
        public int id_presentacion_producto { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
    }

    public class Producto : ViProducto
    {
        public string usuario_registro { get; set; }
    }

    public class ViProductoPresentacionUnidad : ViProducto
    {
        public int id_unidad_presentacion { get; set; }
        public string presentacion { get; set; }
        public bool permite_cantidad_fraccionada { get; set; }
        public string unidades { get; set; }
        public string multiplicador_kg { get; set; }
    }

    public class ViProductoEnAlmacen : ViProductoPresentacionUnidad
    {
        public int id_almacen { get; set; }
        public string almacen { get; set; }
        public decimal stock_actual { get; set; }
    }
    public class ViProductoVenta : ViProductoEnAlmacen
    {
        public decimal cantidad { get; set; }
        public decimal sub_total { get; set; }

    }
}
