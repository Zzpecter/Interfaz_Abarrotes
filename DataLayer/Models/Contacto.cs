namespace DataLayer.Models
{
    public class ViContacto
    {
        public int id_contacto { get; set; }
        public int id_entidad { get; set; }
    }

    public class Contacto : ViContacto
    {
        public string usuario_registro { get; set; }
    }

    public class ViContactoUnified
    {
        public int id_contacto { get; set; }
        public string contacto { get; set; }
    }
}
