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
        public static async Task<List<Models.ViVentaCliente>> listarVentaCliente()
        { 
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_VENTA_CLIENTE,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("venta no encontrada"))
                return new List<Models.ViVentaCliente>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViVentaCliente>>(responseText);
        }

        public static async Task<List<Models.ViVentaCliente>> buscarPorFecha(DateTime desde, DateTime hasta)
        {
            string url = Globals.URL_VENTA_CLIENTE + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy");
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("venta no encontrada"))
                return new List<Models.ViVentaCliente>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViVentaCliente>>(responseText);
        }

        public static async Task<List<Models.ViVentaCliente>> buscarPorCliente(string query)
        {
            string url = Globals.URL_VENTA_CLIENTE + "/" + query;
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("venta no encontrada"))
                return new List<Models.ViVentaCliente>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViVentaCliente>>(responseText);
        }


        public static async Task<Models.ViVentaCliente> seleccionarVentaCliente(int idVenta)
        {
            string url = Globals.URL_VENTA_CLIENTE + "/" + idVenta.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("venta no encontrada"))
                return new Models.ViVentaCliente() { id_salida_producto = -1}; //devuelve lista vacia
            return JsonConvert.DeserializeObject<Models.ViVentaCliente>(responseText);
        }
    }
}
