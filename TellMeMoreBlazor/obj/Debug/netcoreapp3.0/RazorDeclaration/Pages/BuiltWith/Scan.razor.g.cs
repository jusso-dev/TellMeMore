// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TellMeMoreBlazor.Pages.BuiltWith
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using TellMeMoreBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using TellMeMoreBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BuiltWith/scan")]
    public partial class Scan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\fitbi\code-projects\TellMeMore\TellMeMoreBlazor\Pages\BuiltWith\Scan.razor"
 
	public string Error { get; set; }
	public string Loading { get; set; }
	public string HostUrl { get; set; }
	public TellMeMoreBlazor.Models.BuiltWithModel builtWithModel { get; set; } = new Models.BuiltWithModel();

	async Task LoadResultsAsync()
	{
		try
		{
			Loading = "Scan running .. Please Wait...";

			builtWithModel = await IBuiltWithService.GetAsync(HostUrl);

			Loading = string.Empty;
		}
		catch (HttpRequestException ex)
		{
			Loading = string.Empty;
			Error = ex.Message;
		}
		catch (TellMeMoreBlazor.Exceptions.BuiltWithException ex)
		{
			Loading = string.Empty;
			Error = ex.Message;
		}
		catch (Exception)
		{
			Loading = string.Empty;
			Error = "An error occurred. Please try again later.";
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TellMeMoreBlazor.Interfaces.IBuiltWithService IBuiltWithService { get; set; }
    }
}
#pragma warning restore 1591
