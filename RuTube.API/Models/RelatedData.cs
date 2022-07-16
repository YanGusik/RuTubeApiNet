using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class RelatedData
    {
        [JsonProperty("genres")]
        public List<object> Genres { get; set; }

        [JsonProperty("countries")]
        public List<object> Countries { get; set; }

        [JsonProperty("contenttvs")]
        public object Contenttvs { get; set; }

        [JsonProperty("persons")]
        public List<object> Persons { get; set; }
    }


}
