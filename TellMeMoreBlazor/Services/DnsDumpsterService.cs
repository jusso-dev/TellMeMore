using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TellMeMoreBlazor.Exceptions;
using TellMeMoreBlazor.Interfaces;
using TellMeMoreBlazor.Models;
using TellMeMoreBlazor.Shared.ConfigurationLogger;
using TellMeMoreBlazor.Shared.Interfaces;

namespace TellMeMoreBlazor.Services
{
	public class DnsDumpsterService : IDnsDumpsterService
	{
		private readonly IHttpClientFactory _client;
		private readonly ITellMeMoreLogger _config;
		static string BaseUrl = string.Empty;
		public DnsDumpsterService(IHttpClientFactory httpClientFactory, ITellMeMoreLogger configuration)
		{
			_client = httpClientFactory;
			_config = configuration;

			BaseUrl = _config.ReadConfiguration(TellMeMoreLogger.DnsDumpsterBaseUrl)?.Result;
		}

		public async Task<DnsDumpsterModel> GetAsync(string hostUrl)
		{
			try
			{
				if (string.IsNullOrEmpty(hostUrl))
				{
					throw new ArgumentNullException($"param {hostUrl} was null.");
				}

				var client = _client.CreateClient();

				var res = await client.GetAsync($"{BaseUrl}{hostUrl}");

				if (res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<DnsDumpsterModel>(await res?.Content?.ReadAsStringAsync());
					return json;
				}
				else
				{
					throw new DnsDumpsterException($"Request to end-point {BaseUrl} failed. Code was: {res?.StatusCode}");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
