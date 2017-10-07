using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Search
{
    public class ProductImage
    {
		public string Uri { get; set; }
		public string ImagePurpose { get; set; }
		public string BackgroundColor { get; set; }
		public string ForegroundColor { get; set; }
		public string ImagePositionInfo { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public string Caption { get; set; }
		public int FileSizeInBytes { get; set; }
		public string UnscaledImageSHA256Hash { get; set; }
		public IEnumerable<int> CropSafeZone { get; set; }
	}
}
