namespace DataLayer.Models
{
    public class ViFactura
    {
        public int id_factura { get; set; }
        public string codigo_control { get; set; }
        public string datos_codigo_QR { get; set; }
    }

    public class Factura : ViFactura
    {
        public string usuario_registro { get; set; }
    }
}
