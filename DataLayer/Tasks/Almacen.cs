using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Almacen
    {
        public static async Task<List<Models.ViAlmacen>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_ALMACENES,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViAlmacen> alamcenes = JsonConvert.DeserializeObject<List<Models.ViAlmacen>>(responseText);
            return alamcenes;
        }

        public static async Task<int> insertar(Models.Almacen almacen)
        {
            string jsonBody = JsonConvert.SerializeObject(almacen);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_ALMACENES,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Almacen almacen, int idAlmacen)
        {
            string jsonBody = JsonConvert.SerializeObject(almacen);
            string url = Globals.URL_ALMACENES + "/" + idAlmacen.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViAlmacen> seleccionar(int idAlmacen)
        {
            string url = Globals.URL_ALMACENES + "/" + idAlmacen.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViAlmacen>(responseText);
        }

        public static async Task<int> eliminar(int idAlmacen)
        {
            string url = Globals.URL_ALMACENES + "/" + idAlmacen.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
