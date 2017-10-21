using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class SearchResult
	{
		public string ProductFamilyName { get; set; }
		public IEnumerable<string> ProductIds { get; set; }
		public IEnumerable<CatalogProduct> Products { get; set; }
		public int TotalProductCount { get; set; }
	}
}
