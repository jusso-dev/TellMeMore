using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TellMeMore.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public string HostUrl { get; set; }
		public void OnGet()
		{

		}
	}
}
