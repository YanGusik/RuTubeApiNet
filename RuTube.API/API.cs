using Newtonsoft.Json;
using RuTube.API.Exception;
using RuTube.API.Models;
using System.Net;

namespace RuTube.API
{
    public class API
    {
        const string URL_BASE = "https://rutube.ru";
        const string URL_VIDEO_ANALITIC = "pangolin/api/web/video/";
        private Client _client;

        public API()
        {
            _client = new Client(URL_BASE);
        }

        public async Task<bool> IsVideoExistsAsync(string id)
        {
            string url = URL_VIDEO_ANALITIC + id;

            try
            {
                _client.GetJsonAsync(url).Wait();
                return await Task.FromResult(true);
            }
            // this dont be Like
            catch (AggregateException exception)
            {
                foreach (var ex in exception.InnerExceptions)
                {
                    if (ex is HttpRequestException httpRequestException)
                    {
                        if (httpRequestException.StatusCode == HttpStatusCode.NotFound)
                        {
                            return await Task.FromResult(false);
                        }
                    }
                }
                throw;
            }
        }

        public async Task<ResultVideoAnalitic> GetVideoAsync(string id)
        {
            string url = URL_VIDEO_ANALITIC + id;

            try
            {
                var json = _client.GetJsonAsync(url).Result;
                var result = JsonConvert.DeserializeObject<Root>(json);

                if (result.ResultVideoAnalitic == null)
                    throw new System.Exception("dont deserialize object");

                return await Task.FromResult(result.ResultVideoAnalitic);
            }
            // this dont be Like
            catch (AggregateException exception)
            {
                foreach (var ex in exception.InnerExceptions)
                {
                    if (ex is HttpRequestException httpRequestException)
                    {
                        if (httpRequestException.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new VideoNotFoundException(id);
                        }
                    }
                }
                throw;
            }
        }
    }
}