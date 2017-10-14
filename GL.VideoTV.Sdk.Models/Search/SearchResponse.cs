using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class SearchResponse
	{
		public bool HasMorePages { get; set; }

		public IEnumerable<SearchResult> Results { get; set; }

		public int TotalFamilyCount { get; set; }
	}
}
