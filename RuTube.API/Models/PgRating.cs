using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class PgRating
    {
        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }


}
