using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Interfaces;
using TellMeMore.Models;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Pages.urlscan_io
{
	[ValidateAntiForgeryToken]
	public class scanModel : PageModel
    {
		private readonly IUrlScanIoService _urlScanIoService;
		private readonly ITellMeMoreLogger _tellMeMoreLogger;
		public scanModel(IUrlScanIoService urlScanIoService, ITellMeMoreLogger tellMeMoreLogger)
		{
			_urlScanIoService = urlScanIoService;
			_tellMeMoreLogger = tellMeMoreLogger;
		}

		[BindProperty]
		public string RecaptchaKey { get; set; }

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public urlScanIo UrlScanIo { get; set; }

		public IActionResult OnGetAsync()
		{
			RecaptchaKey = _tellMeMoreLogger.ReadConfiguration(TellMeMoreLogger.RecapchaKey);
			return Page();
		}
		
		public async Task<PageResult> OnPostAsync()
		{
			try
			{
				RecaptchaKey = _tellMeMoreLogger.ReadConfiguration(TellMeMoreLogger.RecapchaKey);

				var res = await _urlScanIoService.PostAsync(HostUrl);
				UrlScanIo = await _urlScanIoService.GetStatusAsync(res.uuid);

				return Page();
			}
			catch (HttpRequestException ex)
			{
				TempData["Error"] = ex.Message;
				return Page();
			}
			catch (Exception)
			{
				TempData["Error"] = "An error occurred. Please try different URL formats, ie. http://, https:// or www.";
				return Page();
			}
		}
	}
}