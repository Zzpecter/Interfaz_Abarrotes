using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Factura
    {
        public static async Task<List<Models.ViFactura>> listar()
        {
            string url = Globals.URL_FACTURA;
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("factura no encontrada"))
                return new List<Models.ViFactura>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViFactura>>(responseText);
            }
            catch
            {
                return new List<Models.ViFactura> { JsonConvert.DeserializeObject<Models.ViFactura>(responseText) };
            }
        }

        public static async Task<Models.Factura> insertar(Models.Factura factura)
        {
            string jsonBody = JsonConvert.SerializeObject(factura);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_FACTURA,
                jsonBody,
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Factura>(responseText);
        }

        public static async Task<int> actualizar(Models.Factura factura, int idFactura)
        {
            string jsonBody = JsonConvert.SerializeObject(factura);
            string url = Globals.URL_FACTURA + "/" + idFactura.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViFactura> seleccionar(int idFactura)
        {
            string url = Globals.URL_FACTURA + "/" + idFactura.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViFactura>(responseText);
        }

        public static async Task<int> eliminar(int idFactura)
        {
            string url = Globals.URL_FACTURA + "/" + idFactura.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
