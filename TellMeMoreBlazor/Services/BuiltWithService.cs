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
	public class BuiltWithService : IBuiltWithService
	{
		private readonly IHttpClientFactory _client;
		private readonly ITellMeMoreLogger _config;
		const string BaseUrl = "https://api.builtwith.com/free1/api.json?KEY=";
		public BuiltWithService(IHttpClientFactory httpClientFactory, ITellMeMoreLogger configuration)
		{
			_client = httpClientFactory;
			_config = configuration;
		}

		public async Task<BuiltWithModel> GetAsync(string hostUrl)
		{
			try
			{
				if (string.IsNullOrEmpty(hostUrl))
				{
					throw new ArgumentNullException($"param {hostUrl} was null.");
				}

				var client = _client.CreateClient();
				string apiKey = await _config.ReadConfiguration(TellMeMoreLogger.BuiltWithApiKey);

				var res = await client.GetAsync($"{BaseUrl}{apiKey}&LOOKUP={hostUrl}");

				if (res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<BuiltWithModel>(await res?.Content?.ReadAsStringAsync());
					return json;
				}
				else if (res.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
				{
					throw new urlScanIoException("We're quite busy at the moment, please try again in a minute or so.");
				}
				else
				{
					throw new HttpRequestException($"Request to end-point {BaseUrl} failed. Code was: {res?.StatusCode}");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
