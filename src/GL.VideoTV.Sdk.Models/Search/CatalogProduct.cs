﻿using System;
using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class CatalogProduct
	{
		public DateTime LastModifiedDate { get; set; }

		public IEnumerable<CatalogProductProperties> LocalizedProperties { get; set; }

		public string ProductId { get; set; }

		public bool IsMicrosoftProduct { get; set; }

		public string PreferredSkuId { get; set; }

		public string ProductType { get; set; }

		public string ProductFamily { get; set; }

		public string ProductKind { get; set; }
	}
}
