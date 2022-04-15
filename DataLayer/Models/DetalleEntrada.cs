namespace DataLayer.Models
{
    public class ViDetalleEntrada
    {
        public int id_detalle_entrada { get; set; }
        public int id_compra { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unidad { get; set; }
    }

    public class DetalleEntrada : ViDetalleEntrada
    {
        public string usuario_registro { get; set; }
    }
}
