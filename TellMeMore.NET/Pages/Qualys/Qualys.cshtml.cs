using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SslLabsLib.Objects;
using TellMeMore.Interfaces;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Pages.Qualys
{
	[ValidateAntiForgeryToken]
	public class QualysModel : PageModel
    {
		private readonly IQualysService _qualysService;
		private readonly ITellMeMoreLogger _tellMeMoreLogger;
		public QualysModel(IQualysService qualysService, ITellMeMoreLogger tellMeMoreLogger)
		{
			_qualysService = qualysService;
			_tellMeMoreLogger = tellMeMoreLogger;
		}

		[BindProperty]
		public string RecaptchaKey { get; set; }

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public Analysis Analysis { get; set; }

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

				if (string.IsNullOrEmpty(HostUrl))
				{
					TempData["Error"] = "URL is not valid. Please re-enter URL and try again.";
					return Page();
				}

				Analysis = await _qualysService.QualysReport(HostUrl);
				if(Analysis.Status == SslLabsLib.Enums.AnalysisStatus.ERROR)
				{
					TempData["Error"] = "An error occurred. Please only enter the domain name, remove www., http:// or https://";
				}

				return Page();
			}
			catch (Exception ex)
			{
				TempData["Error"] = ex.Message;
				return Page();
			}
		}
    }
}