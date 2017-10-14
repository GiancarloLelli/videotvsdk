using System;

namespace GL.Sdk.VideoTV.Client.Commons
{
	internal class SearchParametersHelper
	{
		public static string GeneratePagingSegment(int skip, int top)
		{
			if (skip < 0) throw new ArgumentOutOfRangeException(nameof(skip), "must be greater or equal to 0");
			if (top < 0) throw new ArgumentOutOfRangeException(nameof(top), "must be greater or equal to 0");
			return $"$skip={skip}&$top={top}";
		}
	}
}
