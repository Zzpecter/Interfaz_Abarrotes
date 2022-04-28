using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Venta
    {
        public static async Task<List<Models.ViVenta>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_VENTAS,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViVenta> ventas = JsonConvert.DeserializeObject<List<Models.ViVenta>>(responseText);
            return ventas;
        }

        public static async Task<Models.ViVenta> insertar(Models.Venta venta)
        {
            string jsonBody = JsonConvert.SerializeObject(venta);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_VENTAS,
                jsonBody,
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViVenta>(responseText);
        }

        public static async Task<int> actualizar(Models.Venta venta, int idVenta)
        {
            string jsonBody = JsonConvert.SerializeObject(venta);
            string url = Globals.URL_VENTAS + "/" + idVenta.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViVenta> seleccionar(int idVenta)
        {
            string url = Globals.URL_VENTAS + "/" + idVenta.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViVenta>(responseText);
        }

        public static async Task<int> eliminar(int idVenta)
        {
            string url = Globals.URL_VENTAS + "/" + idVenta.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
