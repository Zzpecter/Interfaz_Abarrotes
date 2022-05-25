using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Descuento
    {
        public static async Task<List<Models.ViDescuentoProducto>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_DESCUENTOS,
                String.Empty,
                Globals.HTTP_HEADERS);


            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("descuento no encontrado"))
                return new List<Models.ViDescuentoProducto>(); //devuelve lista vacia
            try
            {
                return JsonConvert.DeserializeObject<List<Models.ViDescuentoProducto>>(responseText);
            }
            catch
            {
                return new List<Models.ViDescuentoProducto> { JsonConvert.DeserializeObject<Models.ViDescuentoProducto>(responseText) };
            }
        }

        public static async Task<Models.Descuento> insertar(Models.Descuento descuento)
        {
            string jsonBody = JsonConvert.SerializeObject(descuento);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_DESCUENTOS,
                jsonBody,
                Globals.HTTP_HEADERS);
            string responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Models.Descuento>(responseText);
        }

        public static async Task<int> actualizar(Models.Descuento descuento, int idDescuento)
        {
            string jsonBody = JsonConvert.SerializeObject(descuento);
            string url = Globals.URL_DESCUENTOS + "/" + idDescuento.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViDescuentoProducto> seleccionar(int idDescuento)
        {
            string url = Globals.URL_DESCUENTOS + "/" + idDescuento.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("descuento no encontrado"))
                return new Models.ViDescuentoProducto(){ id_descuento = -1}; //devuelve lista vacia
            return JsonConvert.DeserializeObject<Models.ViDescuentoProducto>(responseText);
        }

        public static async Task<Models.ViDescuentoProducto> seleccionarProducto(int idProducto)
        {
            string url = Globals.URL_DESCUENTOS + "/producto/" + idProducto.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("descuento no encontrado"))
                return new Models.ViDescuentoProducto() { id_descuento = -1 }; //devuelve id-1 si no existe
            return JsonConvert.DeserializeObject<Models.ViDescuentoProducto>(responseText);
        }

        public static async Task<int> eliminar(int idDescuento)
        {
            string url = Globals.URL_DESCUENTOS + "/" + idDescuento.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
