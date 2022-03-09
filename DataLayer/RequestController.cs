using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class RequestController
    {
        private static readonly HttpClient _Client = new HttpClient();

        public static async Task<HttpResponseMessage> SendHttpRequest(HttpMethod httpMethod, string endpoint, string jsonContent, Dictionary<string, string> pHeaders)
        {
            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = httpMethod;
            httpRequestMessage.RequestUri = new Uri(endpoint);
            foreach (var head in pHeaders)
            {
                httpRequestMessage.Headers.Add(head.Key, head.Value);
            }
            if (httpMethod == HttpMethod.Post || httpMethod == HttpMethod.Put)
            {
                HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;
            }

            return await _Client.SendAsync(httpRequestMessage);
        }
    }
}
