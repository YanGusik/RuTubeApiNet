using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category_url")]
        public string CategoryUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }


}
