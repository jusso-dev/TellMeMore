using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

		public async Task<PageResult> OnPostAsync()
		{
			try
			{
				builtWithModel = await _builtWithService.GetAsync(HostUrl);

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