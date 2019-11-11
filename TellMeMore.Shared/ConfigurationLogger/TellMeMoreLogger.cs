using System;
using Microsoft.Extensions.Configuration;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Shared.ConfigurationLogger
{
	public class TellMeMoreLogger : ITellMeMoreLogger
	{
		private readonly IConfiguration _config;
		public TellMeMoreLogger(IConfiguration configuration)
		{
			_config = configuration ?? throw new ArgumentNullException($"{nameof(IConfiguration)} was null.");
		}

		/// <summary>
		/// Common key names shared through-out application
		/// </summary
		/// 

#if DEBUG
		public const string UrlScanApiKey = "UrlScanApiKey:ApiKey";
		public const string BuiltWithApiKey = "BuiltWithApiKey:ApiKey";
		public const string DnsDumpsterBaseUrl = "DnsDumpsterBaseUrl:Url";
		public const string RecapchaKey = "Recaptcha:Key";
#else
		public const string UrlScanApiKey = "UrlScanApiKey";
		public const string BuiltWithApiKey = "BuiltWithApiKey";
		public const string DnsDumpsterBaseUrl = "DnsDumpsterBaseUrl"; 
		public const string RecapchaKey = "RecaptchaKey";
#endif

		/// <summary>
		/// If debugging, check application.Development.json file, if not, check environment variables on machine.
		/// </summary>
		/// <param name="keyName"> The name of the configuration key </param>
		/// <returns> string value of configuration key </returns>
		public string ReadConfiguration(string keyName)
		{
			try
			{
				string key = string.Empty;

#if DEBUG
				key = _config[keyName]?.ToString() ?? throw new ArgumentNullException($"Key {keyName} was not found. Please check the key is present in your application.Development.json file.");
#else
				key = Environment.GetEnvironmentVariable(keyName) ?? throw new ArgumentNullException($"Key name of {keyName} was not found. Please check the key is present in your environment variables.");
#endif
				return key;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
