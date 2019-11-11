using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly.Extensions.Http;
using Polly;
using TellMeMore.Interfaces;
using TellMeMore.Services;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;
using Microsoft.Extensions.Hosting;
using TellMeMore.Constants;
using Microsoft.AspNetCore.CookiePolicy;

namespace TellMeMore
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }
		
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				options.MinimumSameSitePolicy = SameSiteMode.None;
				options.HttpOnly = HttpOnlyPolicy.Always;
				options.Secure = CookieSecurePolicy.Always;
			});

			// Register polly enabled http clients
			static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
			{
				return HttpPolicyExtensions
					.HandleTransientHttpError()
					.OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
					.OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.InternalServerError)
					.OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.BadGateway)
					.OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
					.WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
			}

			// Register urlscanio client polly implementation
			services.AddHttpClient(HttpClientNames.UrlScanIoHttpClient)
				.SetHandlerLifetime(TimeSpan.FromMinutes(1))
				.AddPolicyHandler(GetRetryPolicy());

			// Add services
			services.AddSingleton<IQualysService, QualysService>();
			services.AddSingleton<IUrlScanIoService, UrlScanIoService>();
			services.AddSingleton<IBuiltWithService, BuiltWithService>();
			services.AddSingleton<IDnsDumpsterService, DnsDumpsterService>();
			
			// Add Configuration Logger
			services.AddSingleton<ITellMeMoreLogger, TellMeMoreLogger>();

			services.AddMvc(e =>
			{
				e.EnableEndpointRouting = false;

			}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
		}
		
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts(hsts => hsts.MaxAge(365).IncludeSubdomains());
			}

			
			app.UseXContentTypeOptions();
			app.UseReferrerPolicy(opts => opts.NoReferrer());
			app.UseXXssProtection(options => options.EnabledWithBlockMode());
			app.UseXfo(options => options.Deny());

			app.UseCsp(opts => opts
				.FontSources(s => s.Self().CustomSources("https://fonts.gstatic.com/"))
				.FormActions(s => s.Self())
				.FrameAncestors(s => s.Self()
				.CustomSources("https://www.google.com/recaptcha/api.js", "https://www.gstatic.com/"))
			);

#if DEBUG
#else
			app.UseHttpsRedirection();
#endif
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc();
		}
	}
}
