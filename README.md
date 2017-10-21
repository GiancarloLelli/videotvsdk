# Video & TV Store Service .NET Standard SDK
This repo contains .NET Standard wrapper for the Video & TV Service used by the Microsoft Store app in Windows 10. This tiny SDK in available as NuGet package and it is provided with no warranties. This is an unofficial SDK built for fun and for the community. Windows 10 app can use this library to present their users with some basic informations about Movies & TV Shows that they might enjoy.

# Features available
Here's a list of the available service call that this API offers. All of this API method are localized (the service supports localization) and can be paged using the usual combination of *$skip* and *$top*.

* SearchAsync
* GetFeaturedMoviesAsync
* GetFeaturedTvShowsAsync
* GetMovieTrailersAsync
* GetNewlyReleasedMoviesAsync
* GetNewlyReleasedTvShowsAsync
* GetSpotlightAsync
* GetTopRentedMoviesAsync
* GetTopSellingTvShowsAsync
* GetByIdAsync
* GetAllByIdAsync

# Sample usage
Inside the .cs file "\videotvsdk\src\GL.Sdk.VideoTV.Test\Program.cs" you can find some examples of usage. For those who are too lazy to browse to that file, here's a snippet of that file.

```cs
class Program
{
    static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();

    static async Task MainAsync(string[] args)
    {
        var client = new VideoTVService(new CultureInfo("it-it"), new CultureInfo("en-us"));
        var spotlight = await client.GetSpotlightAsync();
        var new_releases = await client.GetNewlyReleasedMoviesAsync(0, 2);
        var movieDetail = await client.GetAllByIdAsync(new_releases.Items.Select(x => x.Id).ToArray());
        var search = await client.SearchAsync("star wars", SearchScope.VideoTV);
    }
}
```

# License and contact
This project is distributed under MIT License. If you have any question or you'd like to get involved in the project write to [gcarlo.lelli@live.com](mailto:gcarlo.lelli@live.com)
