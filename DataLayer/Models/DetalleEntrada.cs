namespace DataLayer.Models
{
    public class ViDetalleEntrada
    {
        public int id_detalle_entrada { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio_unidad { get; set; }
    }


    public class ViDetalleEntradaProducto : ViDetalleEntrada
    {
        public int id_presentacion_producto { get; set; }
        public int id_unidad_presentacion { get; set; }
        public string producto { get; set; }
        public string presentacion { get; set; }
        public string unidades { get; set; }
    }

    public class DetalleEntrada : ViDetalleEntrada
    {
        public string usuario_registro { get; set; }
    }
}
