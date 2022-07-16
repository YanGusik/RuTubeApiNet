namespace RuTube.API.Exception
{
    [Serializable]
    public class VideoNotFoundException : System.Exception
    {
        const string videoNotFoundMessage = "The video not found.";

        public VideoNotFoundException() : base()
        {

        }

        public VideoNotFoundException(string videoId) : base(String.Format("{0} - {1}", videoNotFoundMessage, videoId))
        {
            
        }
    }
}
