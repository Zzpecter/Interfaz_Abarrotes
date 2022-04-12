using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class ContactoCorreo
    {
        public static async Task<List<Models.ViContactoCorreo>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_CONTACTO_CORREO,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViContactoCorreo> contactoCorreo = JsonConvert.DeserializeObject<List<Models.ViContactoCorreo>>(responseText);
            return contactoCorreo;
        }

        public static async Task<List<Models.ViContactoCorreo>> listarPorContacto(int idContacto)
        {
            string url = Globals.URL_CONTACTO_CORREO_BY_CONTACTO + "/" + idContacto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new List<Models.ViContactoCorreo>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViContactoCorreo>>(responseText);
            }
            catch
            {
                return new List<Models.ViContactoCorreo> { JsonConvert.DeserializeObject<Models.ViContactoCorreo>(responseText) };
            }
        }

        public static async Task<List<Models.ViEntidadContactoCorreo>> listarPorEntidad(int idEntidad)
        {
            string url = Globals.URL_CONTACTO_CORREO_BY_ENTIDAD + "/" + idEntidad.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new List<Models.ViEntidadContactoCorreo>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViEntidadContactoCorreo>>(responseText);
            }
            catch
            {
                return new List<Models.ViEntidadContactoCorreo> { JsonConvert.DeserializeObject<Models.ViEntidadContactoCorreo>(responseText) };
            }
        }

        public static async Task<int> insertar(Models.ContactoCorreo contactoCorreo)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoCorreo);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_CONTACTO_CORREO,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.ContactoCorreo contactoCorreo, int idContactoCorreo)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoCorreo);
            string url = Globals.URL_CONTACTO_CORREO + "/" + idContactoCorreo.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViEntidadContactoCorreo> seleccionar(int idContactoCorreo)
        {
            string url = Globals.URL_CONTACTO_CORREO + "/" + idContactoCorreo.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViEntidadContactoCorreo>(responseText);
        }

        public static async Task<int> eliminar(int idContactoCorreo)
        {
            string url = Globals.URL_CONTACTO_CORREO + "/" + idContactoCorreo.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
