using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class DetalleEntrada
    {
        public static async Task<List<Models.ViDetalleEntrada>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_DETALLE_ENTRADA,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViDetalleEntrada> detalles = JsonConvert.DeserializeObject<List<Models.ViDetalleEntrada>>(responseText);
            return detalles;
        }

        public static async Task<int> insertar(Models.DetalleEntrada detalleEntrada)
        {
            string jsonBody = JsonConvert.SerializeObject(detalleEntrada);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_DETALLE_ENTRADA,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.DetalleEntrada detalleEntrada, int idDetalleEntrada)
        {
            string jsonBody = JsonConvert.SerializeObject(detalleEntrada);
            string url = Globals.URL_DETALLE_ENTRADA + "/" + idDetalleEntrada.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViDetalleEntrada> seleccionar(int idDetalleEntrada)
        {
            string url = Globals.URL_DETALLE_ENTRADA + "/" + idDetalleEntrada.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViDetalleEntrada>(responseText);
        }

        public static async Task<List<Models.ViDetalleEntradaProducto>> seleccionarPorCompra(int idCompra)
        {
            string url = Globals.URL_DETALLE_ENTRADA + "/compra/" + idCompra.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("detalle_entrada no encontrado"))
                return new List<Models.ViDetalleEntradaProducto>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViDetalleEntradaProducto>>(responseText);
            }
            catch
            {
                return new List<Models.ViDetalleEntradaProducto> { JsonConvert.DeserializeObject<Models.ViDetalleEntradaProducto>(responseText) };
            }
        }

        public static async Task<int> eliminar(int idDetalleEntrada)
        {
            string url = Globals.URL_DETALLE_ENTRADA + "/" + idDetalleEntrada.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
