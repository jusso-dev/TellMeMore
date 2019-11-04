using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TellMeMore.Interfaces;
using TellMeMore.Models;

namespace TellMeMore.Services
{
	public class MxtoolboxService : IMxtoolboxService
	{
		private IHttpClientFactory _httpClientFactory;

		static string BaseUrl = string.Empty;
		public MxtoolboxService(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<MxToolboxModel> GetAsync(string hostUrl)
		{
			throw new NotImplementedException();
		}
	}
}
