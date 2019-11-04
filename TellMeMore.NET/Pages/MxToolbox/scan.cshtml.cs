using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TellMeMore.Interfaces;
using TellMeMore.Models;

namespace TellMeMore.Pages.MxToolbox
{
	[ValidateAntiForgeryToken]
	public class scanModel : PageModel
    {
		private IMxtoolboxService _mxToolboxService;
		public scanModel(IMxtoolboxService mxtoolboxService)
		{
			_mxToolboxService = mxtoolboxService;
		}

		[BindProperty]
		public string HostUrl { get; set; }

		[BindProperty]
		public List<MxToolboxModel> MxToolboxModel { get; set; }

		public IActionResult OnGetAsync()
		{
			return Page();
		}
	}
}