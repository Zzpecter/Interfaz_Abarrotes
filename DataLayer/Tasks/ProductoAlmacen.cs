using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class ProductoAlmacen
    {
        public static async Task<List<Models.ViProductoAlmacen>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_PRODUCTO_ALMACEN,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViProductoAlmacen> productosAlmacen = JsonConvert.DeserializeObject<List<Models.ViProductoAlmacen>>(responseText);
            return productosAlmacen;
        }

        public static async Task<int> insertar(Models.ProductoAlmacen productoAlmacen)
        {
            string jsonBody = JsonConvert.SerializeObject(productoAlmacen);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_PRODUCTO_ALMACEN,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.ProductoAlmacen productoAlmacen, int idProductoAlmacen)
        {
            string jsonBody = JsonConvert.SerializeObject(productoAlmacen);
            string url = Globals.URL_PRODUCTO_ALMACEN + "/" + idProductoAlmacen.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViProductoAlmacen> seleccionar(int idProductoAlmacen)
        {
            string url = Globals.URL_PRODUCTO_ALMACEN + "/" + idProductoAlmacen.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataLayer.Models.ViProductoAlmacen>(responseText);
        }

        public static async Task<Models.ViProductoAlmacen> seleccionarProducto(int idProducto)
        {
            string url = Globals.URL_PRODUCTO_ALMACEN_PRODUCTO + "/" + idProducto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("producto no encontrado"))
                return new Models.ViProductoAlmacen() { id_producto_almacen = -1}; //devuelve id-1 si no existe
            return JsonConvert.DeserializeObject<Models.ViProductoAlmacen>(responseText);
        }

        public static async Task<Models.ViProductoAlmacen> seleccionarAlmacen(int idAlmacen)
        {
            string url = Globals.URL_PRODUCTO_ALMACEN_ALMACEN + "/" + idAlmacen.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("almacen no encontrado"))
                return new Models.ViProductoAlmacen() { id_producto_almacen = -1 }; //devuelve id-1 si no existe
            return JsonConvert.DeserializeObject<Models.ViProductoAlmacen>(responseText);
        }

        public static async Task<int> eliminar(int idProductoAlmacen)
        {
            string url = Globals.URL_PRODUCTO_ALMACEN + "/" + idProductoAlmacen.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
