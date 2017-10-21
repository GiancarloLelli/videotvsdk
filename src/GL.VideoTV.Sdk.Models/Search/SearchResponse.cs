using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class SearchResponse : SearchBase
	{
		public IEnumerable<CatalogProduct> Products { get; set; }
	}

	public class QueryResponse : SearchBase
	{
		public IEnumerable<SearchResult> Results { get; set; }
	}
}
