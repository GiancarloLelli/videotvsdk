using GL.Sdk.VideoTV.Models.Common;
using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Discovery
{
	public class DiscoveryResponse
	{
		public string Description { get; set; }

		public string Id { get; set; }

		public string Name { get; set; }

		public string Title { get; set; }

		public PagingInfo PagingInfo { get; set; }

		public IEnumerable<DiscoveryItem> Items { get; set; }
	}
}