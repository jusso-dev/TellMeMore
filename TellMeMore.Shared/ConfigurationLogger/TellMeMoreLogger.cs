using System;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Shared.ConfigurationLogger
{
	public class TellMeMoreLogger : ITellMeMoreLogger
	{
		private readonly IConfiguration _config;
		private static string keyVaultUri = string.Empty;
		public TellMeMoreLogger(IConfiguration configuration)
		{
			_config = configuration ?? throw new ArgumentNullException($"{nameof(IConfiguration)} was null.");
			keyVaultUri = Environment.GetEnvironmentVariable(KeyVaultUri);
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
		public const string KeyVaultUri = "KeyVaultUri";
#endif

		/// <summary>
		/// If debugging, check application.Development.json file, if not, check environment variables on machine.
		/// </summary>
		/// <param name="keyName"> The name of the configuration key </param>
		/// <returns> string value of configuration key </returns>
		public async Task<string> ReadConfiguration(string keyName)
		{
			try
			{
				string key = string.Empty;

#if DEBUG
				key = _config[keyName]?.ToString() ?? throw new ArgumentNullException($"Key {keyName} was not found. Please check the key is present in your application.Development.json file.");
#else
				AzureServiceTokenProvider azureServiceTokenProvider = new AzureServiceTokenProvider();
				var keyVaultClient = new KeyVaultClient(
					new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
				key = Environment.GetEnvironmentVariable(keyName);
				
				if(string.IsNullOrEmpty(key))
				{
					var sec = await keyVaultClient.GetSecretAsync(vaultBaseUrl: keyVaultUri, secretName: keyName);
					key = sec?.Value;
				}
#endif
				return key ?? throw new ArgumentNullException($"Key name of {keyName} was not found. Please check the key is present Azure Key Vault for Vault {keyVaultUri}.");
			}

			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
