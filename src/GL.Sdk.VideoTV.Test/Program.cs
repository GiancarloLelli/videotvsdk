using GL.Sdk.VideoTV.Client;
using GL.Sdk.VideoTV.Models.Search;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GL.Sdk.VideoTV.Test
{
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
}
