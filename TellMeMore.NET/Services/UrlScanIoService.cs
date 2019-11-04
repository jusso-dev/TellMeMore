﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TellMeMore.Interfaces;
using TellMeMore.Models;

namespace TellMeMore.Services
{
	public class UrlScanIoService : IUrlScanIoService
	{
		private IHttpClientFactory _httpClientFactory;
		private IConfiguration _config;

		const string BaseUrlScan = "https://urlscan.io/api/v1/scan/";
		const string BaseUrlUUID = "https://urlscan.io/api/v1/result/";
		public UrlScanIoService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
		{
			_httpClientFactory = httpClientFactory;
			_config = configuration;
		}

		/// <summary>
		/// Submit scan job to urlscan.io
		/// </summary>
		/// <param name="hostName"></param>
		/// <returns></returns>
		public async Task<UrlScanIoNewScanResponse> PostAsync(string hostName)
		{
			try
			{
				var client = _httpClientFactory.CreateClient();
				string apiKey = _config["UrlScanApiKey:ApiKey"]?.ToString();

				client.DefaultRequestHeaders.Add("API-Key", apiKey);

				var reqObject = new UrlScanIoRequestObject() { url = hostName };

				var res = await client.PostAsJsonAsync(BaseUrlScan, reqObject);

				if (res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<UrlScanIoNewScanResponse>(await res?.Content?.ReadAsStringAsync());
					return json;
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
		public async Task<UrlScanIo> GetStatusAsync(string uuid)
		{
			try
			{
				var client = _httpClientFactory.CreateClient("urlscanio");
				var res = await client.GetAsync(BaseUrlUUID + uuid);

				if(res.IsSuccessStatusCode)
				{
					var json = JsonConvert.DeserializeObject<UrlScanIo>(await res?.Content?.ReadAsStringAsync());
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
