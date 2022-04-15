using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Producto
    {
        public static async Task<List<Models.ViProductoPresentacionUnidad>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_VI_PRODUCTOS,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViProductoPresentacionUnidad> productos = JsonConvert.DeserializeObject<List<Models.ViProductoPresentacionUnidad>>(responseText);
            return productos;
        }

        public static async Task<int> insertar(Models.Producto producto)
        {
            string jsonBody = JsonConvert.SerializeObject(producto);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_PRODUCTOS,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Producto producto, int idProducto)
        {
            string jsonBody = JsonConvert.SerializeObject(producto);
            string url = DataLayer.Globals.URL_PRODUCTOS + "/" + idProducto.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViProducto> seleccionar(int idProducto)
        {
            string url = Globals.URL_PRODUCTOS + "/" + idProducto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataLayer.Models.ViProducto>(responseText);
        }

        public static async Task<Models.ViProductoPresentacionUnidad> seleccionarPresentacionUnidad(int idProducto)
        {
            string url = Globals.URL_VI_PRODUCTOS + "/" + idProducto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("producto no encontrado"))
                return new Models.ViProductoPresentacionUnidad(); //devuelve objeto vacio
            return JsonConvert.DeserializeObject<Models.ViProductoPresentacionUnidad>(responseText);
        }

        public static async Task<List<Models.ViProductoPresentacionUnidad>> buscar(string query)
        {
            string url = Globals.URL_PRODUCTOS_BUSCAR + "/" + query;
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("producto no encontrado"))
                return new List<Models.ViProductoPresentacionUnidad>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViProductoPresentacionUnidad>>(responseText);
            }
            catch
            {
                return new List<Models.ViProductoPresentacionUnidad> { JsonConvert.DeserializeObject<Models.ViProductoPresentacionUnidad>(responseText) };
            }
        }

        public static async Task<int> eliminar(int idProducto)
        {
            string url = Globals.URL_PRODUCTOS + "/" + idProducto.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
