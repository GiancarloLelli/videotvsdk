using GL.VideoTV.Sdk.Models.Discovery;
using GL.VideoTV.Sdk.Models.Interfaces;
using GL.VideoTV.Sdk.Models.Search;
using System;
using System.Globalization;

namespace GL.Sdk.VideoTV.Client
{
	public class VideoTVService : IVideoTVService
	{
		private readonly CultureInfo m_culture;
		private readonly CultureInfo m_market;

		public VideoTVService(CultureInfo culture, CultureInfo market)
		{
			m_culture = culture;
			m_market = market;
		}

		public SearchResponse GetAllById(params string[] productId)
		{
			// /v6.0/Products/bulk?Languages=en&Market=US&fieldsTemplate=Full&productIds=8D6KGWX78K32,<another>
			throw new NotImplementedException();
		}

		public SearchResponse GetById(string productId)
		{
			// /v6.0/Products/bulk?Languages=en&Market=US&fieldsTemplate=Full&productIds=8D6KGWX78K32
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetFeaturedMovies(int skip, int top)
		{
			// v1.0/channels/video.featuredsets?languages=en&market=US&$top=2
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetFeaturedTvShows(int skip, int top)
		{
			// v1.0/channels/video.featured.tv?languages=en&market=US&$top=25
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetMovieTrailers(int skip, int top)
		{
			// v1.0/channels/video.movietrailers?languages=en&market=US&$top=2
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetNewlyReleasedMovies(int skip, int top)
		{
			// v1.0/channels/video.newreleases.movies?languages=en&market=US&$top=2
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetNewlyReleasedTvShows(int skip, int top)
		{
			// v1.0/channels/video.newreleases.tv?languages=en&market=US&$top=2
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetSpotlight()
		{
			// v1.0/channels/video.spotlight?languages=en&market=US
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetTopRentedMovies(int skip, int top)
		{
			// v1.0/channels/video.topRented.movies?languages=en&market=US&$skip=50&$top=2
			throw new NotImplementedException();
		}

		public DiscoveryResponse GetTopSellingTvShows(int skip, int top)
		{
			// v1.0/channels/video.topSelling.tv?languages=en&market=US&$top=25
			throw new NotImplementedException();
		}

		public SearchResponse Search(string query, SearchScope scope)
		{
			// /v7.0/productFamilies/products?fieldsTemplate=details&languages=en&market=US&query=007&productFamilyNames=Movies,TV 
			throw new NotImplementedException();
		}
	}
}
