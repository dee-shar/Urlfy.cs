using System.Net.Http;
using System.Net.Http.Json;

namespace UrlfyApi
{
    public class Urlfy
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://urlfy.org/api/v1";
        public Urlfy()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> ShortenUrl(string url)
        {
            var data = JsonContent.Create(new { url = url });
            var response = await httpClient.PostAsync($"{apiUrl}/shorten", data);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
