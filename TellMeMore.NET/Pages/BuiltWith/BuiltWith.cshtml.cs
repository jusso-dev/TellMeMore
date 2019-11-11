using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Exceptions;
using TellMeMore.Interfaces;

namespace TellMeMore.Pages.BuiltWith
{
	[ValidateAntiForgeryToken]
    public class BuiltWithModel : PageModel
    {
		private IBuiltWithService _builtWithService;
		public BuiltWithModel(IBuiltWithService builtWithService)
		{
			_builtWithService = builtWithService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public Models.BuiltWithModel.BuiltWithModel builtWithModel { get; set; }

		public IActionResult OnGetAsync()
        {
			return Page();
        }
		public async Task<IActionResult> OnPostAsync()
		{
			try
			{
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