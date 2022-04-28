using DataLayer.Models;
using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Authentication
    {
        public static async Task<bool> TryApiConnection()
        {
            var apiResponse = await RequestController.SendHttpRequest(
                HttpMethod.Get, 
                Globals.URL_STATUS, 
                String.Empty, 
                new Dictionary<string, string>());
            string apiResponseText = await apiResponse.Content.ReadAsStringAsync();
            if (apiResponseText.Contains("API conectada correctamente"))
                return true;
            return false;
        }
        public static async Task<bool> authenticateUser(LoginUser usuario)
        {
            string jsonUser = JsonConvert.SerializeObject(usuario);
            var loginResponse = await RequestController.SendHttpRequest(HttpMethod.Post, Globals.URL_AUTH, jsonUser, new Dictionary<string, string>());
            string loginResponseText = await loginResponse.Content.ReadAsStringAsync();
            if (loginResponseText.Contains("access_token"))
            {
                Token loginToken = JsonConvert.DeserializeObject<Token>(loginResponseText);

                Globals.ACTUAL_API_TOKEN = loginToken.access_token;
                Globals.HTTP_HEADERS["Authorization"] = "Bearer " + loginToken.access_token;
                return true;
            }
            return false;
                
            
        }
    }
}
