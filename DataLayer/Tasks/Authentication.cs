using DataLayer.Models;
using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Authentication
    {
        public static async Task BuildAuthHeaders()
        {
            if (DataLayer.Globals.ACTUAL_API_TOKEN == String.Empty)
            {
                await authenticateUser().ConfigureAwait(false);
            }
        }
        public static async Task authenticateUser()
        {
            LoginUser loginUser = new LoginUser() { login_usuario = "admin", password_usuario = "admin" };
            string jsonUser = JsonConvert.SerializeObject(loginUser);
            var a = Globals.URL_AUTH;
            var loginResponse = await RequestController.SendHttpRequest(HttpMethod.Post, Globals.URL_AUTH, jsonUser, new Dictionary<string, string>());
            string loginResponseText = await loginResponse.Content.ReadAsStringAsync();
            Token loginToken = JsonConvert.DeserializeObject<Token>(loginResponseText);

            DataLayer.Globals.ACTUAL_API_TOKEN = loginToken.access_token;
            DataLayer.Globals.HTTP_HEADERS["Authorization"] = "Bearer " + loginToken.access_token;
        }
    }
}
