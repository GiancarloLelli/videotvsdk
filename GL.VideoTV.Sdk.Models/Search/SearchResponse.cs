using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Search
{
    public class SearchResponse
    {
		public bool HasMorePages { get; set; }

		public IEnumerable<SearchResult> Results { get; set; }

		public int TotalFamilyCount { get; set; }
	}
}
