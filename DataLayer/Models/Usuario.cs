namespace DataLayer.Models
{

    public class ViUsuario
    {
        public int id_entidad { get; set; }
        public int id_nivel { get; set; }
        public string login_usuario { get; set; }
        public string password_usuario { get; set; }
    }

    public class Usuario : ViUsuario
    {
        public string usuario_registro { get; set; }
    }
    public class ViUsuarioNivel : ViUsuario
    {
        public string nivel { get; set; }
    }
}
