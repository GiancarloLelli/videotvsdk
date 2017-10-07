using System;
using System.Collections.Generic;
using System.Text;

namespace GL.VideoTV.Sdk.Models.Search
{
    public class Trailer
    {
		public string TrailerName { get; set; }
		public string Uri { get; set; }
		public int DurationInSeconds { get; set; }
		public string VideoEncoding { get; set; }
		public string ResolutionFormat { get; set; }
		public string ResolutionDetail { get; set; }
		public string DeliveryFormat { get; set; }
		public IEnumerable<AudioTrack> AudioTracks { get; set; }
	}

	public class AudioTrack
	{
		public string LocaleCode { get; set; }
		public string AudioEncoding { get; set; }
	}
}
