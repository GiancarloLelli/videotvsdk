﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Search
{
    public class Award
    {
		public string CategoryName { get; set; }
		public bool IsWinner { get; set; }
		public string AwardOrganizationMediaId { get; set; }
		public string OrganizationName { get; set; }
		public string ProviderName { get; set; }
		public string AwardDate { get; set; }
	}
}
