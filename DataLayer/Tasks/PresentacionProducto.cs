using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class PresentacionProducto
    {
        public static async Task<List<Models.ViMotivo>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_MOTIVOS,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViMotivo> motivos = JsonConvert.DeserializeObject<List<Models.ViMotivo>>(responseText);
            return motivos;
        }

        public static async Task<int> insertar(Models.Motivo motivo)
        {
            string jsonBody = JsonConvert.SerializeObject(motivo);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_MOTIVOS,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Motivo motivo, int idMotivo)
        {
            string jsonBody = JsonConvert.SerializeObject(motivo);
            string url = Globals.URL_MOTIVOS + "/" + idMotivo.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViMotivo> seleccionar(int idMotivo)
        {
            string url = Globals.URL_MOTIVOS + "/" + idMotivo.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViMotivo>(responseText);
        }

        public static async Task<int> eliminar(int idMotivo)
        {
            string url = Globals.URL_MOTIVOS + "/" + idMotivo.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
