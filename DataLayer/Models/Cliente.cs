namespace DataLayer.Models
{
    public class ViCliente
    {
        public int id_entidad { get; set; }
        public string razon_social { get; set; }
        public string nit_ci { get; set; }
    }

    public class Cliente : ViCliente
    {
        public string usuario_registro { get; set; }
    }
}
