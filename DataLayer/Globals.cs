using Newtonsoft.Json;
using System.IO;

namespace DataLayer
{
    public static class Globals
    {
        public const string IP = "192.168.1.2";
        public const string PORT = "5000";
        public static string API_URL = IP + ":" + PORT + "/api/v1/";
        public static string URL_AUTH = "http://" + IP + ":" + PORT + "/auth/login";
        public static string URL_MOTIVOS = "http://" + API_URL + "motivos";
        public static string URL_CLIENTES = "http://" + API_URL + "clientes";
        public static string URL_NIVELES = "http://" + API_URL + "niveles";
        public static string URL_USUARIO = "http://" + API_URL + "users";
        public static string URL_USUARIO_NIVEL = "http://" + API_URL + "usuario-nivel";
        public static string URL_CONTACTOS = "http://" + API_URL + "contactos";
        public static string URL_CONTACTO_CORREO = "http://" + API_URL + "contactos_correo";
        public static string URL_CONTACTO_TELEFONO = "http://" + API_URL + "contactos_telefono";
        public static string URL_DEPARTAMENTO = "http://" + API_URL + "departamentos";
        public static string URL_LOCALIDAD = "http://" + API_URL + "localidades";
        public static string URL_CONTACTO_DIRECCION = "http://" + API_URL + "contactos_direccion";

        public static string ACTUAL_API_TOKEN = String.Empty;

        public static Dictionary<string, string> HTTP_HEADERS = new Dictionary<string, string>()
                {
                    { "Authorization", ""}
                };
    }
}
