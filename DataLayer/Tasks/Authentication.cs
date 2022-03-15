using DataLayer.Models;
using Newtonsoft.Json;
using DataLayer;

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
            string loginUrl = "http://192.168.74.99:5000/auth/login";
            LoginUser loginUser = new LoginUser() { login_usuario = "admin", password_usuario = "admin" };
            string jsonUser = JsonConvert.SerializeObject(loginUser);
            var loginResponse = await RequestController.SendHttpRequest(HttpMethod.Post, loginUrl, jsonUser, new Dictionary<string, string>());
            string loginResponseText = await loginResponse.Content.ReadAsStringAsync();
            Token loginToken = JsonConvert.DeserializeObject<Token>(loginResponseText);

            DataLayer.Globals.ACTUAL_API_TOKEN = loginToken.access_token;
            DataLayer.Globals.HTTP_HEADERS["Authorization"] = "Bearer " + loginToken.access_token;
        }
    }
}
