using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TellMeMoreBlazor
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
                    webBuilder.UseKestrel(s => s.AddServerHeader = false);
					#if DEBUG
						webBuilder.UseUrls("http://*:80");
					#else
						webBuilder.UseUrls("http://*:443");
					#endif
                    
					webBuilder.UseStartup<Startup>();
				});
	}
}
