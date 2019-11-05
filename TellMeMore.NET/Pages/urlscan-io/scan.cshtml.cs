using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Interfaces;
using TellMeMore.Models;

namespace TellMeMore.Pages.urlscan_io
{
	[ValidateAntiForgeryToken]
	public class scanModel : PageModel
    {
		private IUrlScanIoService _urlScanIoService;
		public scanModel(IUrlScanIoService urlScanIoService)
		{
			_urlScanIoService = urlScanIoService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public UrlScanIo UrlScanIo { get; set; }

		public IActionResult OnGetAsync()
		{
			return Page();
		}
		
		public async Task<PageResult> OnPostAsync()
		{
			try
			{
				var res = await _urlScanIoService.PostAsync(HostUrl);
				UrlScanIo = await _urlScanIoService.GetStatusAsync(res.uuid);

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