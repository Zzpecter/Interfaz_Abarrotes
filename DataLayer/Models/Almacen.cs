namespace DataLayer.Models
{
    public class ViAlmacen
    {
        public int id_almacen { get; set; }
        public string descripcion { get; set; }
    }

    public class Almacen : ViAlmacen
    {
        public string usuario_registro { get; set; }
    }
}
