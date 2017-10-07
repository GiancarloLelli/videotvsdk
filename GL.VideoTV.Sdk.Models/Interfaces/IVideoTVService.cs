using GL.VideoTV.Sdk.Models.Discovery;
using GL.VideoTV.Sdk.Models.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Interfaces
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
