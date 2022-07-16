using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class ActionReason
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
