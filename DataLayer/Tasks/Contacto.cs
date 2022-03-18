using Newtonsoft.Json;


namespace DataLayer.Tasks
{
    public class Contacto
    {
        public static async Task<int> insertar(Models.Contacto contacto)
        {
            string jsonBody = JsonConvert.SerializeObject(contacto);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_CONTACTOS,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> eliminar(int idContacto)
        {
            string url = Globals.URL_CONTACTOS + "/" + idContacto.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> eliminarPorEntidad(int idEntidad)
        {
            string url = Globals.URL_CONTACTOS_UNIFIED + "/" + idEntidad.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<List<Models.ViContactoUnified>> listarUnified(int idContacto)
        {
            string url = Globals.URL_CONTACTOS_UNIFIED + "/" + idContacto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViContactoUnified> contactos = JsonConvert.DeserializeObject<List<Models.ViContactoUnified>>(responseText);
            return contactos;
        }
    }
}
