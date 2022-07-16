using Newtonsoft.Json;

namespace RuTube.API.Models
{
    public class ResultVideoAnalitic
    {
        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("relatedData")]
        public RelatedData RelatedData { get; set; }

        [JsonProperty("metaData")]
        public MetaData MetaData { get; set; }

        [JsonProperty("playlist")]
        public object Playlist { get; set; }

        [JsonProperty("seasonsCount")]
        public int SeasonsCount { get; set; }

        [JsonProperty("currentSeason")]
        public object CurrentSeason { get; set; }

        [JsonProperty("schedule")]
        public object Schedule { get; set; }

        [JsonProperty("donations")]
        public List<Donation> Donations { get; set; }
    }
}
