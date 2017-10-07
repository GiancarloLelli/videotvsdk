using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Search
{
    public class SearchResult
    {
		public string ProductFamilyName { get; set; }
		public IEnumerable<string> ProductIds { get; set; }
		public IEnumerable<CatalogProduct> Products { get; set; }
		public int TotalProductCount { get; set; }
	}
}
