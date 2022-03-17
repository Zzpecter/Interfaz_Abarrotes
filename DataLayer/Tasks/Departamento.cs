using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Departamento
    {
        public static async Task<List<Models.Departamento>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_DEPARTAMENTO,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.Departamento> departamentos = JsonConvert.DeserializeObject<List<Models.Departamento>>(responseText);
            return departamentos;
        }
       
        public static async Task<Models.Departamento> seleccionar(int idDepartamento)
        {
            string url = Globals.URL_DEPARTAMENTO + "/" + idDepartamento.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Departamento>(responseText);
        }
    }
}
