using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class ContactoTelefono
    {
        public static async Task<List<Models.ViContactoTelefono>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_CONTACTO_TELEFONO,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViContactoTelefono> contactoTelefono = JsonConvert.DeserializeObject<List<Models.ViContactoTelefono>>(responseText);
            return contactoTelefono;
        }

        public static async Task<int> insertar(Models.ContactoTelefono contactoTelefono)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoTelefono);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_CONTACTO_TELEFONO,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.ContactoTelefono contactoTelefono, int idContactoTelefono)
        {
            string jsonBody = JsonConvert.SerializeObject(contactoTelefono);
            string url = Globals.URL_CONTACTO_TELEFONO + "/" + idContactoTelefono.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViContactoTelefono> seleccionar(int idContactoTelefono)
        {
            string url = Globals.URL_CONTACTO_TELEFONO + "/" + idContactoTelefono.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViContactoTelefono>(responseText);
        }

        public static async Task<int> eliminar(int idContactoTelefono)
        {
            string url = Globals.URL_CONTACTO_TELEFONO + "/" + idContactoTelefono.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
