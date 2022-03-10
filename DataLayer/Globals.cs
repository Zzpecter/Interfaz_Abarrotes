using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Globals
    {
        public static string URL_AUTH = "http://192.168.1.3:5000/auth/login";
        public static string URL_MOTIVOS = "http://192.168.1.3:5000/api/v1/motivos";
        public static string URL_CLIENTES = "http://192.168.1.3:5000/api/v1/clientes";
        public static string URL_NIVELES = "http://192.168.1.3:5000/api/v1/niveles";
        public static string URL_USUARIO = "http://192.168.1.3:5000/api/v1/users";

        public static string ACTUAL_API_TOKEN = String.Empty;

        public static Dictionary<string, string> HTTP_HEADERS = new Dictionary<string, string>()
                {
                    { "Authorization", ""}
                };
    }
}
