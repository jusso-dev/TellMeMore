using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Interfaces;
using TellMeMore.Models;

namespace TellMeMore.Pages.dnsdumpster
{
	[ValidateAntiForgeryToken]
	public class scanModel : PageModel
    {
		private IDnsDumpsterService _dnsDumpsterService;
		public scanModel(IDnsDumpsterService dnsDumpsterService)
		{
			_dnsDumpsterService = dnsDumpsterService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public DnsDumpsterModel dnsDumpsterModel { get; set; }

		public IActionResult OnGetAsync()
		{
			return Page();
		}

		public async Task<PageResult> OnPostAsync()
		{
			try
			{
				dnsDumpsterModel = await _dnsDumpsterService.GetAsync(HostUrl);

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