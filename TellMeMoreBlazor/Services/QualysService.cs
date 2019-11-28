using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SslLabsLib;
using SslLabsLib.Enums;
using SslLabsLib.Objects;
using TellMeMoreBlazor.Interfaces;

namespace TellMeMoreBlazor.Services
{
	/// <summary>
	/// Class to handle interactions with Qualys API using Qualys .NET SDK
	/// Credit - https://github.com/lordmike/ssllabslib
	/// </summary>
	public class QualysService : IQualysService
	{
		/// <summary>
		/// Takes in host URL and returns Qualys SSL Labs API result
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public Task<Analysis> QualysReport(string domainUrl)
		{
			try
			{
				if (string.IsNullOrEmpty(domainUrl)) throw new ArgumentNullException("Host URL was null or empty.");

				var client = new SslLabsClient();
				var result = client.GetAnalysisBlocking(domainUrl, 24, AnalyzeOptions.FromCache | AnalyzeOptions.ReturnAll);

				return Task.FromResult(result);
			}
			catch (HttpRequestException ex)
			{
				throw ex;
			}
			catch (Exception ex)
			{
				// TODO: log this exception
				throw ex;
			}
		}
	}
}
