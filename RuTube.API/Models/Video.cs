using Newtonsoft.Json;
using System;

namespace RuTube.API.Models
{
    public class Video
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("is_audio")]
        public bool IsAudio { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("duration")]
        public int DurationInSecond { get; set; }

        [JsonIgnore]
        public TimeSpan Duration { get => TimeSpan.FromSeconds(DurationInSecond); }

        [JsonProperty("is_livestream")]
        public bool IsLivestream { get; set; }

        [JsonProperty("stream_type")]
        public object StreamType { get; set; }

        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("is_adult")]
        public bool IsAdult { get; set; }

        [JsonProperty("pg_rating")]
        public PgRating PgRating { get; set; }

        [JsonProperty("publication_ts")]
        public DateTime PublicationTs { get; set; }

        [JsonProperty("extra_params")]
        public ExtraParams ExtraParams { get; set; }

        [JsonProperty("future_publication")]
        public object FuturePublication { get; set; }

        [JsonProperty("is_classic")]
        public bool IsClassic { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("product_id")]
        public object ProductId { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("is_official")]
        public bool IsOfficial { get; set; }

        [JsonProperty("action_reason")]
        public ActionReason ActionReason { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("pepper")]
        public object Pepper { get; set; }

        [JsonProperty("music")]
        public object Music { get; set; }

        [JsonProperty("hashtags")]
        public List<string> Hashtags { get; set; }

        [JsonProperty("feed_url")]
        public string FeedUrl { get; set; }

        [JsonProperty("feed_name")]
        public string FeedName { get; set; }

        [JsonProperty("feed_subscribers_count")]
        public int FeedSubscribersCount { get; set; }

        [JsonProperty("episode")]
        public object Episode { get; set; }

        [JsonProperty("season")]
        public object Season { get; set; }

        [JsonProperty("tv_show_id")]
        public object TvShowId { get; set; }

        [JsonProperty("hide_comments")]
        public bool HideComments { get; set; }

        [JsonProperty("hide_chat")]
        public bool HideChat { get; set; }

        [JsonProperty("hide_likes")]
        public bool HideLikes { get; set; }

        [JsonProperty("hide_dislikes")]
        public bool HideDislikes { get; set; }

        [JsonProperty("is_original_content")]
        public bool IsOriginalContent { get; set; }

        [JsonProperty("kind_sign_for_user")]
        public bool KindSignForUser { get; set; }

        [JsonProperty("kindType")]
        public bool KindType { get; set; }
    }


}
