namespace DataLayer.Models
{
    public class ViCompra
    {
        public int id_compra { get; set; }
        public int id_usuario { get; set; }
        public int id_proveedor { get; set; }
        public decimal monto_total { get; set; }
        public DateTime fecha { get; set; }
    }

    public class Compra : ViCompra
    {
        public string usuario_registro { get; set; }
    }
}
