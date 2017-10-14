using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class ReviewItem
	{
		public string ReviewerMediaId { get; set; }
		public string ProviderName { get; set; }
		public string ReviewCount { get; set; }
		public string ReviewScore { get; set; }
		public string ReviewType { get; set; }
		public string SourceUri { get; set; }
		public IEnumerable<Comment> Reviews { get; set; }
	}

	public class Comment
	{
		public string CriticName { get; set; }
		public string Date { get; set; }
		public string Publication { get; set; }
		public string ReviewUri { get; set; }
		public string Score { get; set; }
		public string ScoreDescription { get; set; }
		public string Text { get; set; }
	}
}
