namespace DataLayer.Models
{
    public class ViProductoAlmacen
    {
        public int id_producto_almacen { get; set; }
        public int id_almacen { get; set; }
        public int id_producto { get; set; }
        public int stock_actual { get; set; }
    }

    public class ProductoAlmacen : ViProductoAlmacen
    {
        public string usuario_registro { get; set; }
    }
}
