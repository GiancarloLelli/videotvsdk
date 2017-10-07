using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Common
{
	[DataContract(Namespace = "Microsoft.Marketplace.ChannelCommon.Contracts", Name = "Microsoft.Marketplace.ChannelCommon.Contracts.V3.Response.PagingInfo")]
	public class PagingInfo
    {
		[DataMember(Name = "__type")]
		public string Type { get; set; }

		public int TotalItems { get; set; }
	}
}
