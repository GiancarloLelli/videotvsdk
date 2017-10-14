using GL.Sdk.VideoTV.Models.Discovery;
using GL.Sdk.VideoTV.Models.Search;
using System.Threading.Tasks;

namespace GL.Sdk.VideoTV.Models.Interfaces
{
	public interface IVideoTVService
	{
		Task<DiscoveryResponse> GetSpotlightAsync();
		Task<DiscoveryResponse> GetMovieTrailersAsync(int skip, int top);
		Task<DiscoveryResponse> GetNewlyReleasedMoviesAsync(int skip, int top);
		Task<DiscoveryResponse> GetNewlyReleasedTvShowsAsync(int skip, int top);
		Task<DiscoveryResponse> GetFeaturedMoviesAsync(int skip, int top);
		Task<DiscoveryResponse> GetFeaturedTvShowsAsync(int skip, int top);
		Task<DiscoveryResponse> GetTopRentedMoviesAsync(int skip, int top);
		Task<DiscoveryResponse> GetTopSellingTvShowsAsync(int skip, int top);
		Task<QueryResponse> SearchAsync(string query, SearchScope scope);
		Task<SearchResponse> GetByIdAsync(string productId);
		Task<SearchResponse> GetAllByIdAsync(params string[] productId);
	}
}
