using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Proveedor
    {
        public static async Task<List<Models.ViProveedor>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_PROVEEDORES,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViProveedor> proveedores = JsonConvert.DeserializeObject<List<Models.ViProveedor>>(responseText);
            return proveedores;
        }

        public static async Task<int> insertar(Models.Proveedor proveedor)
        {
            string jsonBody = JsonConvert.SerializeObject(proveedor);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_PROVEEDORES,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Proveedor proveedor, int idProveedor)
        {
            string jsonBody = JsonConvert.SerializeObject(proveedor);
            string url = DataLayer.Globals.URL_PROVEEDORES + "/" + idProveedor.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViProveedor> seleccionar(int idProveedor)
        {
            string url = Globals.URL_PROVEEDORES + "/" + idProveedor.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DataLayer.Models.ViProveedor>(responseText);
        }

        public static async Task<int> eliminar(int idProveedor)
        {
            string url = Globals.URL_PROVEEDORES + "/" + idProveedor.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
