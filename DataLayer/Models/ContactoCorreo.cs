namespace DataLayer.Models
{

    public class ViContactoCorreo
    {
        public int id_contacto_correo { get; set; }
        public int id_contacto { get; set; }
        public string correo { get; set; }
    }

    public class ContactoCorreo : ViContactoCorreo
    {
        public string usuario_registro { get; set; }
    }
}
