using System.Net.Http;

namespace IMC.API.Extensions
{
    public static class HttpClientExtensions
    {
        public static HttpClient WithBearer(this HttpClient client, string apiKey)
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
            return client;
        }
    }
}
