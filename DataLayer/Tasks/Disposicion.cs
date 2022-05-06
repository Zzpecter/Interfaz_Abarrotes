using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Disposicion
    {
        public static async Task<List<Models.ViDisposicionCompleto>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_DISPOSICION + "/completo",
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("disposicion no encontrada"))
                return new List<Models.ViDisposicionCompleto>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViDisposicionCompleto>>(responseText);
            }
            catch
            {
                return new List<Models.ViDisposicionCompleto> { JsonConvert.DeserializeObject<Models.ViDisposicionCompleto>(responseText) };
            }
        }

        public static async Task<int> insertar(Models.Disposicion disposicion)
        {
            string jsonBody = JsonConvert.SerializeObject(disposicion);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_DISPOSICION,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViDisposicion> seleccionar(int idDisposicion)
        {
            string url = Globals.URL_DISPOSICION + "/" + idDisposicion.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.ViDisposicion>(responseText);
        }
    }
}
