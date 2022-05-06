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

        public static async Task<List<Models.ViCompraProveedor>> listarCompraProveedor()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_COMPRA_PROVEEDOR,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("compra no encontrada"))
                return new List<Models.ViCompraProveedor>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViCompraProveedor>>(responseText);
        }

        public static async Task<List<Models.ViCompraProveedor>> buscarPorFecha(DateTime desde, DateTime hasta)
        {
            string url = Globals.URL_COMPRA_PROVEEDOR + "/" + desde.ToString("MM-dd-yyyy") + "/" + hasta.ToString("MM-dd-yyyy");
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("compra no encontrada"))
                return new List<Models.ViCompraProveedor>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViCompraProveedor>>(responseText);
        }

        public static async Task<List<Models.ViCompraProveedor>> buscarPorProveedor(string query)
        {
            string url = Globals.URL_COMPRA_PROVEEDOR + "/" + query;
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("compra no encontrada"))
                return new List<Models.ViCompraProveedor>(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<List<Models.ViCompraProveedor>>(responseText);
        }


        public static async Task<Models.ViCompraProveedor> seleccionarCompraProveedor(int idCompra)
        {
            string url = Globals.URL_COMPRA_PROVEEDOR + "/" + idCompra.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("compra no encontrada"))
                return new Models.ViCompraProveedor() { id_compra = -1 }; //devuelve lista vacia
            return JsonConvert.DeserializeObject<Models.ViCompraProveedor>(responseText);
        }
    }
}
