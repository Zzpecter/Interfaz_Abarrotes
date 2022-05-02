using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class DetalleSalida
    {
        public static async Task<List<Models.ViDetalleSalida>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_DETALLE_SALIDA,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViDetalleSalida> detalles = JsonConvert.DeserializeObject<List<Models.ViDetalleSalida>>(responseText);
            return detalles;
        }

        public static async Task<int> insertar(Models.DetalleSalida detalleSalida)
        {
            string jsonBody = JsonConvert.SerializeObject(detalleSalida);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_DETALLE_SALIDA,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.DetalleSalida detalleSalida, int idDetalleSalida)
        {
            string jsonBody = JsonConvert.SerializeObject(detalleSalida);
            string url = Globals.URL_DETALLE_SALIDA + "/" + idDetalleSalida.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViDetalleSalida> seleccionar(int idDetalleSalida)
        {
            string url = Globals.URL_DETALLE_SALIDA + "/" + idDetalleSalida.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViDetalleSalida>(responseText);
        }

        public static async Task<List<Models.ViDetalleSalidaProducto>> seleccionarPorVenta(int idVenta)
        {
            string url = Globals.URL_DETALLE_SALIDA + "/venta/" + idVenta.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("detalle_salida no encontrado"))
                return new List<Models.ViDetalleSalidaProducto>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViDetalleSalidaProducto>>(responseText);
            }
            catch
            {
                return new List<Models.ViDetalleSalidaProducto> { JsonConvert.DeserializeObject<Models.ViDetalleSalidaProducto>(responseText) };
            }
        }

        public static async Task<int> eliminar(int idDetalleSalida)
        {
            string url = Globals.URL_DETALLE_SALIDA + "/" + idDetalleSalida.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
