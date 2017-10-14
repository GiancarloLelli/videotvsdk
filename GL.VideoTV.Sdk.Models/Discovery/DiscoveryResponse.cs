using GL.Sdk.VideoTV.Models.Common;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GL.Sdk.VideoTV.Models.Discovery
{
	[DataContract(Namespace = "Microsoft.Xbox.Discovery.ChannelProviderDataContracts", Name = "DiscoveryChannelResponse")]
	public class DiscoveryResponse
	{
		[DataMember(Name = "__type")]
		private string Type { get; set; }

		public string Description { get; set; }

		public string Id { get; set; }

		public string Name { get; set; }

		public string Title { get; set; }

		public PagingInfo PagingInfo { get; set; }

		public IEnumerable<DiscoveryItem> Items { get; set; }
	}
}
