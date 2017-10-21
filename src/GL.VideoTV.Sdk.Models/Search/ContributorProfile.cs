using System.Collections.Generic;

namespace GL.Sdk.VideoTV.Models.Search
{
	public class ContributorProfile
	{
		public string Name { get; set; }
		public string Role { get; set; }
		public List<ProductImage> Images { get; set; }
		public string ContributorId { get; set; }
		public string RoleType { get; set; }
		public int Order { get; set; }
	}
}
