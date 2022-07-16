using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class Author
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }
    }
}
