using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class ContactoDireccion
    {
        public static async Task<List<Models.ViContactoDireccion>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_CONTACTO_DIRECCION,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViContactoDireccion> contactoDireccion = JsonConvert.DeserializeObject<List<Models.ViContactoDireccion>>(responseText);
            return contactoDireccion;
        }

        public static async Task<List<Models.ViContactoDireccion>> listarPorContacto(int idContacto)
        {
            string url = Globals.URL_CONTACTO_DIRECCION_BY_CONTACTO + "/" + idContacto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new List<Models.ViContactoDireccion>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViContactoDireccion>>(responseText);
            }
            catch
            {
                return new List<Models.ViContactoDireccion> { JsonConvert.DeserializeObject<Models.ViContactoDireccion>(responseText) };
            }
        }

        public static async Task<List<Models.ViEntidadContactoDireccion>> listarPorEntidad(int idEntidad)
        {
            string url = Globals.URL_CONTACTO_DIRECCION_BY_ENTIDAD + "/" + idEntidad.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new List<Models.ViEntidadContactoDireccion>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViEntidadContactoDireccion>>(responseText);
            }
            catch
            {
                return new List<Models.ViEntidadContactoDireccion> { JsonConvert.DeserializeObject<Models.ViEntidadContactoDireccion>(responseText) };
            }
        }

        public static async Task<int> insertar(Models.ContactoDireccion contactoDireccion)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoDireccion);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_CONTACTO_DIRECCION,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.ContactoDireccion contactoDireccion, int idContactoDireccion)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoDireccion);
            string url = Globals.URL_CONTACTO_DIRECCION + "/" + idContactoDireccion.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViEntidadContactoDireccion> seleccionar(int idContactoDireccion)
        {
            string url = Globals.URL_CONTACTO_DIRECCION + "/" + idContactoDireccion.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViEntidadContactoDireccion>(responseText);
        }

        public static async Task<int> eliminar(int idContactoDireccion)
        {
            string url = Globals.URL_CONTACTO_DIRECCION + "/" + idContactoDireccion.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
