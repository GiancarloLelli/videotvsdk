using GL.Sdk.VideoTV.Client.Commons;
using GL.Sdk.VideoTV.Client.Http;
using GL.Sdk.VideoTV.Models.Discovery;
using GL.Sdk.VideoTV.Models.Interfaces;
using GL.Sdk.VideoTV.Models.Search;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL.Sdk.VideoTV.Client
{
	public class VideoTVService : IVideoTVService
	{
		private readonly CultureInfo m_culture;
		private readonly CultureInfo m_market;
		private readonly VideoTvHttpClient m_client;

		private StringBuilder m_localization;
		private string LocalizationSegment
		{
			get
			{
				var returnText = string.Empty;

				if (m_localization == null)
				{
					var marketName = m_market.Name.Split('-').ElementAt(1);
					m_localization = new StringBuilder();
					m_localization.Append($"?Languages={m_culture.TwoLetterISOLanguageName}&");
					m_localization.Append($"Market={marketName}&");
					returnText = m_localization.ToString();
				}
				else
				{
					returnText = m_localization.ToString();
				}

				return returnText;
			}
		}

		public VideoTVService(CultureInfo culture, CultureInfo market)
		{
			m_culture = culture ?? throw new ArgumentNullException(nameof(culture));
			m_market = market ?? throw new ArgumentNullException(nameof(market));
			m_client = new VideoTvHttpClient();
		}

		public async Task<SearchResponse> GetAllByIdAsync(params string[] productId)
		{
			if (productId.Length == 0) throw new ArgumentException(nameof(productId), "must contain at least one value");
			if (productId.Any(p => string.IsNullOrEmpty(p?.Trim()))) throw new ArgumentException(nameof(productId), "the parameter array contains one invalid value");

			var listOfProductIdsSeparatedByComma = productId.Aggregate((x, y) => string.Concat(x, ",", y));
			var url = $"v6.0/Products/bulk{LocalizationSegment}fieldsTemplate=Full&productIds={listOfProductIdsSeparatedByComma}";
			var result = await m_client.QueryDisplayService<SearchResponse>(url);
			return result;
		}

		public async Task<SearchResponse> GetByIdAsync(string productId)
		{
			if (string.IsNullOrEmpty(productId?.Trim())) throw new ArgumentNullException(nameof(productId), "cannot be null or empty");
			var url = $"v6.0/Products/bulk{LocalizationSegment}fieldsTemplate=Full&productIds={productId}";
			var result = await m_client.QueryDisplayService<SearchResponse>(url);
			return result;
		}

		public async Task<QueryResponse> SearchAsync(string query, SearchScope scope)
		{
			if (string.IsNullOrEmpty(query?.Trim())) throw new ArgumentNullException(nameof(query), "cannot be null or empty");
			var familyName = scope == SearchScope.VideoTV ? "Movies,TV" : scope.ToString();
			var url = $"v7.0/productFamilies/products{LocalizationSegment}fieldsTemplate=details&query={query}&productFamilyNames={familyName}";
			var result = await m_client.QueryDisplayService<QueryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetFeaturedMoviesAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.featuredsets{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetFeaturedTvShowsAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.featured.tv{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetMovieTrailersAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.movietrailers{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetNewlyReleasedMoviesAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.newreleases.movies{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetNewlyReleasedTvShowsAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.newreleases.tv{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetSpotlightAsync()
		{
			var url = $"v1.0/channels/video.spotlight{LocalizationSegment}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetTopRentedMoviesAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.topRented.movies{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}

		public async Task<DiscoveryResponse> GetTopSellingTvShowsAsync(int skip, int top)
		{
			var url = $"v1.0/channels/video.topSelling.tv{LocalizationSegment}{SearchParametersHelper.GeneratePagingSegment(skip, top)}";
			var result = await m_client.QueryMediaDiscoveryService<DiscoveryResponse>(url);
			return result;
		}
	}
}
