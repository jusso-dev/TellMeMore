using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Exceptions;
using TellMeMore.Interfaces;
using TellMeMore.Models.DnsDumpster;
using TellMeMore.Shared.ConfigurationLogger;
using TellMeMore.Shared.Interfaces;

namespace TellMeMore.Pages.dnsdumpster
{
	[ValidateAntiForgeryToken]
	public class scanModel : PageModel
    {
		private readonly IDnsDumpsterService _dnsDumpsterService;
		private readonly ITellMeMoreLogger _tellMeMoreLogger;
		public scanModel(IDnsDumpsterService dnsDumpsterService, ITellMeMoreLogger tellMeMoreLogger)
		{
			_dnsDumpsterService = dnsDumpsterService;
			_tellMeMoreLogger = tellMeMoreLogger;
		}

		[BindProperty]
		public string RecaptchaKey { get; set; }

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public DnsDumpsterModel dnsDumpsterModel { get; set; }

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

				dnsDumpsterModel = await _dnsDumpsterService.GetAsync(HostUrl);
				return Page();
			}
			catch(DnsDumpsterException ex)
			{
				// Safe to return to user
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