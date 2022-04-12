using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Usuario
    {
        public static async Task<List<Models.ViUsuario>> listar()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_USUARIO,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViUsuario> usuarios = JsonConvert.DeserializeObject<List<Models.ViUsuario>>(responseText);
            return usuarios;
        }
        public static async Task<List<Models.ViUsuarioNivel>> listarUsuarioNivel()
        {
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                Globals.URL_USUARIO_NIVEL,
                String.Empty,
                Globals.HTTP_HEADERS);

            string responseText = await response.Content.ReadAsStringAsync();
            List<Models.ViUsuarioNivel> usuarios = JsonConvert.DeserializeObject<List<Models.ViUsuarioNivel>>(responseText);
            return usuarios;
        }

        public static async Task<int> insertar(Models.Usuario usuario)
        {
            string jsonBody = JsonConvert.SerializeObject(usuario);

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Post,
                Globals.URL_USUARIO,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<int> actualizar(Models.Usuario usuario, int idUsuario)
        {
            string jsonBody = JsonConvert.SerializeObject(usuario);
            string url = Globals.URL_USUARIO + "/" + idUsuario.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Put,
                url,
                jsonBody,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }

        public static async Task<Models.ViUsuario> seleccionar(int idUsuario)
        {
            string url = Globals.URL_USUARIO + "/" + idUsuario.ToString();
            var response = await RequestController.SendHttpRequest(
                HttpMethod.Get,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);


            string responseText = await response.Content.ReadAsStringAsync();
            if (responseText.Contains("contacto no encontrado"))
                return new Models.ViUsuario(); //devuelve lista vacia
            return JsonConvert.DeserializeObject<Models.ViUsuario>(responseText);
        }

        public static async Task<int> eliminar(int idUsuario)
        {
            string url = Globals.URL_USUARIO + "/" + idUsuario.ToString();

            var response = await RequestController.SendHttpRequest(
                HttpMethod.Delete,
                url,
                String.Empty,
                Globals.HTTP_HEADERS);
            return ((int)response.StatusCode);
        }
    }
}
