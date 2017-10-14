using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class CatalogProductProperties
	{
		public IEnumerable<string> TVGenres { get; set; }
		public string ShortDescription { get; set; }
		public IEnumerable<ContributorProfile> Contributors { get; set; }
		public IEnumerable<Trailer> Trailers { get; set; }
		public IEnumerable<Award> Awards { get; set; }
		public IEnumerable<ReviewItem> ReviewSets { get; set; }
		public IEnumerable<SearchTitle> SearchTitles { get; set; }
		public IEnumerable<ProductImage> Images { get; set; }
		public string ProductDescription { get; set; }
		public string ProductTitle { get; set; }
		public string Language { get; set; }
		public List<string> Markets { get; set; }
	}
}
