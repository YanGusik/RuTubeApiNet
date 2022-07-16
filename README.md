# RuTubeApiNet

C# API for RuTube - Russian video platform

### Download & Install (I plan to, have not released a package yet)

```powershell
Install-Package RuTubeApiNet
```

----
### Getting Started

#### Temporary, still changing

```csharp
var api = new API();

var idVideo = "3e6b9412253a9f9c28af4f2a5fb41620";
var idNotExistsVideo = "851022368d948354b32831ce1330c1dbDDDDDDDDD";

var videoKuplinov = api.GetVideoAsync(idVideo).Result;

api.IsVideoExistsAsync(idVideo).Result; // True
api.IsVideoExistsAsync(idNotExistsVideo).Result; // False

// en {0} - {1} views / {2} category / {3} author / {4} channel subscribers
// ru {0} - просмотров {1} / категория {2} / автор {3} / подписчиков канала {4}

Console.WriteLine("{0} - просмотров {1} / категория {2} / автор {3} / подписчиков канала {4}",
    videoKuplinov.Video.Title,
    videoKuplinov.Video.Hits,
    videoKuplinov.Video.Category.Name,
    videoKuplinov.Video.Author.Name,
    videoKuplinov.Video.FeedSubscribersCount);
```
