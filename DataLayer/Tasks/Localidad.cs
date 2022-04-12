using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Localidad
    {
        public static async Task<List<Models.ViLocalidad>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_LOCALIDAD,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViLocalidad> localidades = JsonConvert.DeserializeObject<List<Models.ViLocalidad>>(responseText);
            return localidades;
        }

        public static async Task<int> insertar(Models.Localidad localidad)
        {
            string jsonBody = JsonConvert.SerializeObject(localidad);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_LOCALIDAD,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Localidad localidad, int idLocalidad)
        {
            string jsonBody = JsonConvert.SerializeObject(localidad);
            string url = Globals.URL_LOCALIDAD + "/" + idLocalidad.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViLocalidad> seleccionar(int idLocalidad)
        {
            string url = Globals.URL_LOCALIDAD + "/" + idLocalidad.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViLocalidad>(responseText);
        }

        public static async Task<List<Models.ViLocalidad>> seleccionarPorDepartamento(int idDepartamento)
        {
            string url = Globals.URL_LOCALIDAD_DEPARTAMENTO + "/" + idDepartamento.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("localidad no encontrada"))
                return new List<Models.ViLocalidad>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViLocalidad>>(responseText);
            }
            catch
            {
                return new List<Models.ViLocalidad> { JsonConvert.DeserializeObject<Models.ViLocalidad>(responseText) };
            }
        }

        public static async Task<int> eliminar(int idLocalidad)
        {
            string url = Globals.URL_LOCALIDAD + "/" + idLocalidad.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
