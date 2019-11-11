using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Exceptions;
using TellMeMore.Interfaces;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Pages.BuiltWith
{
	[ValidateAntiForgeryToken]
    public class BuiltWithModel : PageModel
    {
		private readonly IBuiltWithService _builtWithService;
		private readonly ITellMeMoreLogger _tellMeMoreLogger;
		public BuiltWithModel(IBuiltWithService builtWithService, ITellMeMoreLogger tellMeMoreLogger)
		{
			_builtWithService = builtWithService;
			_tellMeMoreLogger = tellMeMoreLogger;
		}

		[BindProperty]
		public string RecaptchaKey { get; set; }

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public Models.BuiltWithModel.BuiltWithModel builtWithModel { get; set; }

		public IActionResult OnGetAsync()
        {
			RecaptchaKey = _tellMeMoreLogger.ReadConfiguration(TellMeMoreLogger.RecapchaKey);
			return Page();
        }
		public async Task<IActionResult> OnPostAsync()
		{
			try
			{
				RecaptchaKey = _tellMeMoreLogger.ReadConfiguration(TellMeMoreLogger.RecapchaKey);

				builtWithModel = await _builtWithService.GetAsync(HostUrl);
				return Page();
			}
			catch (HttpRequestException ex)
			{
				TempData["Error"] = ex.Message;
				return Page();
			}
			catch (BuiltWithException ex)
			{
				TempData["Error"] = ex.Message;
				return Page();
			}
			catch (Exception)
			{
				TempData["Error"] = "An error occurred. Please try again later.";
				return Page();
			}
		}
    }
}