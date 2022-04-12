using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Cliente
    {
        public static async Task<List<Models.ViCliente>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_CLIENTES,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViCliente> clientes = JsonConvert.DeserializeObject<List<Models.ViCliente>>(responseText);
            return clientes;
        }

        public static async Task<int> insertar(Models.Cliente cliente)
        {
            string jsonBody = JsonConvert.SerializeObject(cliente);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_CLIENTES,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Cliente cliente, int idCliente)
        {
            string jsonBody = JsonConvert.SerializeObject(cliente);
            string url = DataLayer.Globals.URL_CLIENTES + "/" + idCliente.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViCliente> seleccionar(int idCliente)
        {
            string url = Globals.URL_CLIENTES + "/" + idCliente.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new Models.ViCliente(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<Models.ViCliente>(responseText);
        }

        public static async Task<int> eliminar(int idCliente)
        {
            string url = Globals.URL_CLIENTES + "/" + idCliente.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
