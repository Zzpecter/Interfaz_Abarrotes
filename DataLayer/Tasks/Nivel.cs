using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tasks
{
    public class Nivel
    {
        public static async Task<List<Models.Nivel>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_NIVELES,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.Nivel> niveles = JsonConvert.DeserializeObject<List<Models.Nivel>>(responseText);
            return niveles;
        }

        public static async Task<Models.Nivel> seleccionar(int idMotivo)
        {
            string url = Globals.URL_NIVELES + "/" + idMotivo.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Nivel>(responseText);
        }

    }
}
