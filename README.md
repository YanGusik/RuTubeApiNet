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

Console.WriteLine("{0} \nViews - {1} \nCategory - {2} \nAuthor - {3} \nSubscribers - {4}",
    videoKuplinov.Video.Title,
    videoKuplinov.Video.Hits,
    videoKuplinov.Video.Category.Name,
    videoKuplinov.Video.Author.Name,
    videoKuplinov.Video.FeedSubscribersCount);
```

----
### Output
```
Скаймаг гайд Дота 2 Skywrath Mage dota 2.mp4
Views - 371
Category - Видеоигры
Author - Дота 2 для новичков
Subscribers - 2
```
