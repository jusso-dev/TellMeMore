using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SslLabsLib.Objects;
using TellMeMore.Interfaces;

namespace TellMeMore.Pages.Qualys
{
	[ValidateAntiForgeryToken]
	public class QualysModel : PageModel
    {
		private IQualysService _qualysService;
		public QualysModel(IQualysService qualysService)
		{
			_qualysService = qualysService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public Analysis Analysis { get; set; }

		public IActionResult OnGetAsync()
        {
			return Page();
        }

		public async Task<PageResult> OnPostAsync()
		{
			try
			{
				if(string.IsNullOrEmpty(HostUrl))
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