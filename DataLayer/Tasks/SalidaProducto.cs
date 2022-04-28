using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class SalidaProducto
    {
        public static async Task<Models.SalidaProducto> insertar()
        {

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_SALIDA_PRODUCTO,
                "{}",
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.SalidaProducto>(responseText);
        }

        public static async Task<int> eliminar(int idEntidad)
        {
            string url = Globals.URL_SALIDA_PRODUCTO + "/" + idEntidad.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
