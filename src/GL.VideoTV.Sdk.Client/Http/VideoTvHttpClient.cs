using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GL.VideoTV.Sdk.Client.Http
{
	internal class VideoTvHttpClient : IDisposable
	{
		private static HttpClient _discoveryHttpClient;
		private static HttpClient _displayHttpClient;

		public VideoTvHttpClient()
		{
			_discoveryHttpClient = new HttpClient() { BaseAddress = new Uri("https://mediadiscovery.microsoft.com/") };
			_displayHttpClient = new HttpClient() { BaseAddress = new Uri("https://displaycatalog.mp.microsoft.com/") };
			_displayHttpClient.DefaultRequestHeaders.TryAddWithoutValidation("MS-CV", "Xfsr1aKAmU+iWzN1.11");
		}

		public async Task<T> QueryMediaDiscoveryService<T>(string query)
		{
			var response = await _discoveryHttpClient.GetAsync(query);
			string json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(json);
		}

		public async Task<T> QueryDisplayService<T>(string query)
		{
			var response = await _displayHttpClient.GetAsync(query);
			string json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(json);
		}

		public void Dispose()
		{
			_discoveryHttpClient?.Dispose();
			_displayHttpClient?.Dispose();
		}
	}
}