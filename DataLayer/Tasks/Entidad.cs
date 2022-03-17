using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Entidad
    {
        public static async Task<Models.Entidad> insertar()
        {

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_ENTIDADES,
                "{}",
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Entidad>(responseText);
        }

        public static async Task<int> eliminar(int idEntidad)
        {
            string url = Globals.URL_ENTIDADES + "/" + idEntidad.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
