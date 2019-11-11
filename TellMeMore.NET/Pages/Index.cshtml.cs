using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Interfaces;
using TellMeMore.Models;
using TellMeMore.Services;

namespace TellMeMore.Pages
{
	[ValidateAntiForgeryToken]
	public class IndexModel : PageModel
	{
		private readonly IBuiltWithService _builtWithSerivce;
		private readonly IDnsDumpsterService _dnsDumpsterService;
		private readonly IQualysService _qualysService;
		private readonly IUrlScanIoService _urlScanIoService;
		public IndexModel(IBuiltWithService builtWithService, IDnsDumpsterService dnsDumpsterService,
						  IQualysService qualysService, IUrlScanIoService urlScanIoService)
		{
			_builtWithSerivce = builtWithService;
			_dnsDumpsterService = dnsDumpsterService;
			_qualysService = qualysService;
			_urlScanIoService = urlScanIoService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public CombindedModel combindedModel { get; set; }
		public void OnGet()
		{

		}

		public async Task<IActionResult> OnPostAsync()
		{
			try
			{

				combindedModel.builtWithModel = await _builtWithSerivce.GetAsync(HostUrl);
				combindedModel.dnsDumpsterModel = await _dnsDumpsterService.GetAsync(HostUrl);
				combindedModel.analysis = await _qualysService.QualysReport(HostUrl);

				var res = await _urlScanIoService.PostAsync(HostUrl);
				combindedModel.urlScanIo = await _urlScanIoService.GetStatusAsync(res.uuid);

				return Page();
			}
			catch (Exception)
			{
				TempData["Error"] = "One or more errors occurred. Please try again later.";
				return Page();
			}
		}
	}
}
