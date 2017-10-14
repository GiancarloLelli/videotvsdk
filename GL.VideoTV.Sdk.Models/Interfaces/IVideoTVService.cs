using GL.Sdk.VideoTV.Models.Discovery;
using GL.Sdk.VideoTV.Models.Search;

namespace GL.Sdk.VideoTV.Models.Interfaces
{
	public interface IVideoTVService
	{
		DiscoveryResponse GetSpotlight();
		DiscoveryResponse GetMovieTrailers(int skip, int top);
		DiscoveryResponse GetNewlyReleasedMovies(int skip, int top);
		DiscoveryResponse GetNewlyReleasedTvShows(int skip, int top);
		DiscoveryResponse GetFeaturedMovies(int skip, int top);
		DiscoveryResponse GetFeaturedTvShows(int skip, int top);
		DiscoveryResponse GetTopRentedMovies(int skip, int top);
		DiscoveryResponse GetTopSellingTvShows(int skip, int top);
		SearchResponse Search(string query, SearchScope scope);
		SearchResponse GetById(string productId);
		SearchResponse GetAllById(params string[] productId);
	}
}
