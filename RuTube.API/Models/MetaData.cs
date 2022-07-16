using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class MetaData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("extrahead")]
        public string Extrahead { get; set; }

    }


}
