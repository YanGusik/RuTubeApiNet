using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class Root
    {
        [JsonProperty("result")]
        public ResultVideoAnalitic ResultVideoAnalitic { get; set; }
    }
}
