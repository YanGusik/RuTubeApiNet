using RuTube.API.Exception;
using System;
using System.Net;

namespace RuTube.API
{
    public class Client
    {
        private readonly string _baseUrl;

        public Client(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<string> GetJsonAsync(string uri)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.Timeout = TimeSpan.FromMinutes(30);
            return await client.GetStringAsync(uri);
        }
    }
}
