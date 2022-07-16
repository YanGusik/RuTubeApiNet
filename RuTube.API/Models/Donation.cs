using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class Donation
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("link_label")]
        public string? LinkLabel { get; set; }

        [JsonProperty("link_label_short")]
        public string? LinkLabelShort { get; set; }
    }
}
