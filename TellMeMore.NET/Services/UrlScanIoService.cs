using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TellMeMore.Constants;
using TellMeMore.Exceptions;
using TellMeMore.Interfaces;
using TellMeMore.Models;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Services
{
	public class UrlScanIoService : IUrlScanIoService
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ITellMeMoreLogger _config;

		const string BaseUrlScan = "https://urlscan.io/api/v1/scan/";
		const string BaseUrlUUID = "https://urlscan.io/api/v1/result/";
		public UrlScanIoService(IHttpClientFactory httpClientFactory, ITellMeMoreLogger configuration)
		{
			_httpClientFactory = httpClientFactory;
			_config = configuration;
		}

		/// <summary>
		/// Submit scan job to urlscan.io
		/// </summary>
		/// <param name="hostName"></param>
		/// <returns></returns>
		public async Task<urlScanIoNewScanResponse> PostAsync(string hostName)
		{
			try
			{
				var client = _httpClientFactory.CreateClient(HttpClientNames.urlScanIoHttpClient);
				string apiKey = await _config.ReadConfiguration(TellMeMoreLogger.UrlScanApiKey);

				client.DefaultRequestHeaders.Add("API-Key", apiKey);

				var reqObject = new urlScanIoRequestObject() { url = hostName };

				var res = await client.PostAsync(BaseUrlScan,
					new StringContent(
							JsonConvert.SerializeObject(reqObject), Encoding.UTF8, "application/json")
						);

				if (res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<urlScanIoNewScanResponse>(await res?.Content?.ReadAsStringAsync());
					return json;
				}
				else if(res.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
				{
					throw new urlScanIoException("We're quite busy at the moment, please try again in a minute or so.");
				}
				else
				{
					throw new HttpRequestException($"Failed request to {BaseUrlScan}. Failed to start scan for URL: {hostName}");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Get current scan by UUID
		/// </summary>
		/// <param name="uuid">UUID of previously preformed scan</param>
		/// <returns></returns>
		public async Task<urlScanIo> GetStatusAsync(string uuid)
		{
			try
			{
				var client = _httpClientFactory.CreateClient(HttpClientNames.urlScanIoHttpClient);
				var res = await client.GetAsync(BaseUrlUUID + uuid);

				if(res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<urlScanIo>(await res?.Content?.ReadAsStringAsync());
					return json;
				}
				else
				{
					throw new HttpRequestException($"Failed request to {BaseUrlUUID}. Failed to check job ID: {uuid ?? "UUID was blank."}");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
