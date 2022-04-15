using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Compra
    {
        public static async Task<List<Models.ViCompra>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_COMPRAS,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViCompra> compras = JsonConvert.DeserializeObject<List<Models.ViCompra>>(responseText);
            return compras;
        }

        public static async Task<Models.ViCompra> insertar(Models.Compra compra)
        {
            string jsonBody = JsonConvert.SerializeObject(compra);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_COMPRAS,
                jsonBody,
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViCompra>(responseText);
        }

        public static async Task<int> actualizar(Models.Compra compra, int idCompra)
        {
            string jsonBody = JsonConvert.SerializeObject(compra);
            string url = Globals.URL_COMPRAS + "/" + idCompra.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViCompra> seleccionar(int idCompra)
        {
            string url = Globals.URL_COMPRAS + "/" + idCompra.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViCompra>(responseText);
        }

        public static async Task<int> eliminar(int idCompra)
        {
            string url = Globals.URL_COMPRAS + "/" + idCompra.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
