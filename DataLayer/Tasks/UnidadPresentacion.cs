using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class UnidadPresentacion
    {
        public static async Task<List<Models.ViUnidadPresentacion>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_UNIDAD_PRESENTACION,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViUnidadPresentacion> unidadPresentacion = JsonConvert.DeserializeObject<List<Models.ViUnidadPresentacion>>(responseText);
            return unidadPresentacion;
        }

        public static async Task<int> insertar(Models.UnidadPresentacion unidadPresentacion)
        {
            string jsonBody = JsonConvert.SerializeObject(unidadPresentacion);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_UNIDAD_PRESENTACION,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.UnidadPresentacion unidadPresentacion, int idUnidadPresentacion)
        {
            string jsonBody = JsonConvert.SerializeObject(unidadPresentacion);
            string url = Globals.URL_UNIDAD_PRESENTACION + "/" + idUnidadPresentacion.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViUnidadPresentacion> seleccionar(int idUnidadPresentacion)
        {
            string url = Globals.URL_UNIDAD_PRESENTACION + "/" + idUnidadPresentacion.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViUnidadPresentacion>(responseText);
        }

        public static async Task<int> eliminar(int idUnidadPresentacion)
        {
            string url = Globals.URL_UNIDAD_PRESENTACION + "/" + idUnidadPresentacion.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
