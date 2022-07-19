using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Reportes
    {
        public static async Task<Models.ReporteResponse> listarReporteVentasSinProducto(DateTime desde, DateTime hasta)
        {
            string url = Globals.URL_REPORTE_VENTAS + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy");
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("datos de reporte no encontrados"))
                return new Models.ReporteResponse() { status_code = 404};
            return JsonConvert.DeserializeObject<Models.ReporteResponse>(responseText); ;
        }

        public static async Task<List<Models.ReporteVentas>> listarReporteVentasConProducto(DateTime desde, DateTime hasta, int idProducto)
        {
            string url = Globals.URL_REPORTE_VENTAS + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy" + "/" + idProducto.ToString());
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("datos de reporte no encontrados"))
                return new List<Models.ReporteVentas>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ReporteVentas>>(responseText);
            }
            catch
            {
                return new List<Models.ReporteVentas> { JsonConvert.DeserializeObject<Models.ReporteVentas>(responseText) };
            }
        }

        public static async Task<Models.ReporteResponse> listarReporteGananciasSinProducto(DateTime desde, DateTime hasta)
        {
            string url = Globals.URL_REPORTE_GANANCIAS + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy");
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("datos de reporte no encontrados"))
                return new Models.ReporteResponse() { status_code = 404 };
            return JsonConvert.DeserializeObject<Models.ReporteResponse>(responseText); ;
        }

        public static async Task<List<Models.ReporteVentas>> listarReporteGananciasConProducto(DateTime desde, DateTime hasta, int idProducto)
        {
            string url = Globals.URL_REPORTE_GANANCIAS + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy" + "/" + idProducto.ToString());
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("datos de reporte no encontrados"))
                return new List<Models.ReporteVentas>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ReporteVentas>>(responseText);
            }
            catch
            {
                return new List<Models.ReporteVentas> { JsonConvert.DeserializeObject<Models.ReporteVentas>(responseText) };
            }
        }

        public static async Task<Models.ReporteResponse> listarReporteComprasSinProducto(DateTime desde, DateTime hasta)
        {
            string url = Globals.URL_REPORTE_COMPRAS + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy");
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("datos de reporte no encontrados"))
                return new Models.ReporteResponse() { status_code = 404 };
            return JsonConvert.DeserializeObject<Models.ReporteResponse>(responseText); ;
        }
    }
}
