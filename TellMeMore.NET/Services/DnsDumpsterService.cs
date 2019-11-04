using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TellMeMore.Interfaces;
using TellMeMore.Models;
using TellMeMore.Models.DnsDumpster;

namespace TellMeMore.Services
{
	public class DnsDumpsterService : IDnsDumpsterService
	{
		private readonly IHttpClientFactory _client;
		private readonly IConfiguration _config;
		static string BaseUrl = string.Empty;
		public DnsDumpsterService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
		{
			_client = httpClientFactory;
			_config = configuration;

			BaseUrl = _config["DnsDumpsterBaseUrl:Url"]?.ToString();
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
				
				var res = await client.GetAsync($"{BaseUrl}/scan/{hostUrl}");

				if (res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<DnsDumpsterModel>(await res?.Content?.ReadAsStringAsync());
					return json;
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
