using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class PresentacionProducto
    {
        public static async Task<List<Models.ViPresentacionUnidad>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_PRESENTACION_PRODUCTO,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViPresentacionUnidad> presentacionesProductos = JsonConvert.DeserializeObject<List<Models.ViPresentacionUnidad>>(responseText);
            return presentacionesProductos;
        }

        public static async Task<int> insertar(Models.PresentacionProducto presentacionProducto)
        {
            string jsonBody = JsonConvert.SerializeObject(presentacionProducto);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_PRESENTACION_PRODUCTO,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.PresentacionProducto presentacionProducto, int idPresentacionProducto)
        {
            string jsonBody = JsonConvert.SerializeObject(presentacionProducto);
            string url = Globals.URL_PRESENTACION_PRODUCTO + "/" + idPresentacionProducto.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViPresentacionProducto> seleccionar(int idPresentacionProducto)
        {
            string url = Globals.URL_PRESENTACION_PRODUCTO + "/" + idPresentacionProducto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViPresentacionProducto>(responseText);
        }

        public static async Task<int> eliminar(int idPresentacionProducto)
        {
            string url = Globals.URL_PRESENTACION_PRODUCTO + "/" + idPresentacionProducto.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
