#pragma checksum "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c37d6b7e7ad49c1d33eda4796e520b061605dd"
// <auto-generated/>
#pragma warning disable 1591
namespace TellMeMoreBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using TellMeMoreBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/_Imports.razor"
using TellMeMoreBlazor.Shared;

#line default
#line hidden
#nullable disable
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenComponent<TellMeMoreBlazor.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "/mnt/c/Users/fitbi/code-projects/TellMeMore/TellMeMoreBlazor/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
