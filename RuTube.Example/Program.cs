using RuTube.API;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");

        var api = new API();

        var idVideo = "8456b5b3421f54a44010e08e176617cb";
        var idNotExistsVideo = "851022368d948354b32831ce1330c1dbDDDDDDDDD";


        var videoKuplinov = api.GetVideoAsync(idVideo).Result; // ФИНАЛЬНЫЙ ФИНАЛ ► Cyberpunk 2077 #38

        var a = api.IsVideoExistsAsync(idVideo).Result; // ФИНАЛЬНЫЙ ФИНАЛ ► Cyberpunk 2077 #38
        var b = api.IsVideoExistsAsync(idNotExistsVideo).Result;

        Console.WriteLine("\nn{0} video is exists? - {1}", idVideo, a);
        Console.WriteLine("\n{0} video is exists? - {1}", idNotExistsVideo, b);

        Console.WriteLine("{0} - просмотров {1} / категория {2} / автор {3} / подписчиков канала {4}",
            videoKuplinov.Video.Title,
            videoKuplinov.Video.Hits,
            videoKuplinov.Video.Category.Name,
            videoKuplinov.Video.Author.Name,
            videoKuplinov.Video.FeedSubscribersCount);


        Console.ReadKey();
    }
}