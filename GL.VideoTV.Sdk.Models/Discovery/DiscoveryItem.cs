﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Discovery
{
	[DataContract(Namespace = "Microsoft.Xbox.Discovery.ChannelProviderDataContracts", Name = "DiscoveryChannelItem")]
	public class DiscoveryItem
    {
		[DataMember(Name = "__type")]
		private string Type { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public string Id { get; set; }

		public string ItemType { get; set; }

		public string CollectionContents { get; set; }
	}
}
