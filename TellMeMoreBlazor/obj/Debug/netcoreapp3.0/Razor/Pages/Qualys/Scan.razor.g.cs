#pragma checksum "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f7e7db3ed0007b775eedfa231303e352d6fd43"
// <auto-generated/>
#pragma warning disable 1591
namespace TellMeMoreBlazor.Pages.Qualys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using TellMeMoreBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\_Imports.razor"
using TellMeMoreBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Qualys/scan")]
    public class Scan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""col-md-12"" style=""margin-top:2%;margin-bottom:2%;"">
	<div class=""alert alert-info alert-dismissible fade show"">
		Note - Scan may take a couple of minutes. Please do not refresh page.
		<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
			<span aria-hidden=""true"">&times;</span>
		</button>
	</div>
</div>

");
            __builder.AddMarkupContent(1, "<h1>Qualys SSLlabs Scan</h1>\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
 if (!string.IsNullOrEmpty(Error))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.AddAttribute(5, "style", "margin-top:2%;margin-bottom:2%;");
            __builder.AddMarkupContent(6, "\r\n\t\t");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "alert alert-danger alert-dismissible fade show");
            __builder.AddMarkupContent(9, "\r\n\t\t\t");
            __builder.AddContent(10, 
#nullable restore
#line 20 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
             Error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n\t\t\t");
            __builder.AddMarkupContent(12, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t</button>\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 26 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 28 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
 if (!string.IsNullOrEmpty(Loading))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\t");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-12");
            __builder.AddAttribute(19, "style", "margin-top:2%;margin-bottom:2%;");
            __builder.AddMarkupContent(20, "\r\n\t\t");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "alert alert-info alert-dismissible fade show");
            __builder.AddMarkupContent(23, "\r\n\t\t\t");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
             Loading

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.AddMarkupContent(26, "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t</button>\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 38 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n\t");
            __builder.AddMarkupContent(33, "<label style=\"font-size:large;font-weight:bold\">Host URL</label>\r\n\t");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "placeholder", "URL");
            __builder.AddAttribute(37, "class", "input-group");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                   HostUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HostUrl = __value, HostUrl));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t<br>\r\n\t");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                       LoadResultsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "type", "submit");
            __builder.AddAttribute(44, "class", "btn btn-dark");
            __builder.AddContent(45, "Scan");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n");
#nullable restore
#line 48 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
 if (Analysis?.Host != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "\t");
            __builder.OpenElement(49, "p");
            __builder.AddMarkupContent(50, "<strong>Host name:</strong> ");
            __builder.AddContent(51, 
#nullable restore
#line 50 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                    Analysis.Host

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t");
            __builder.OpenElement(53, "p");
            __builder.AddMarkupContent(54, "<strong>Certificate Issuer Label:</strong> ");
            __builder.AddContent(55, 
#nullable restore
#line 51 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                   Analysis.Endpoints[0].Details.Cert.IssuerLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t");
            __builder.OpenElement(57, "p");
            __builder.AddMarkupContent(58, "<strong>Certificate Signature Algorithm:</strong> ");
            __builder.AddContent(59, 
#nullable restore
#line 52 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                          Analysis.Endpoints[0].Details.Cert.SigAlg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 53 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"

	foreach (var item in Analysis.Endpoints)
	{
		switch (item.Grade)
		{
			case "A+":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "\t\t\t\t");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "style", "color:lightgreen;");
            __builder.OpenElement(64, "strong");
            __builder.AddContent(65, "Host ");
            __builder.AddContent(66, 
#nullable restore
#line 59 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                           item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(67, " Grade: ");
            __builder.AddContent(68, 
#nullable restore
#line 59 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                                  item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 60 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "A":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "\t\t\t\t");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "style", "color:lightgreen;");
            __builder.OpenElement(73, "strong");
            __builder.AddContent(74, "Host ");
            __builder.AddContent(75, 
#nullable restore
#line 62 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                           item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, " Grade: ");
            __builder.AddContent(77, 
#nullable restore
#line 62 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                                  item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 63 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "B":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "\t\t\t\t");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "style", "color:lightblue;");
            __builder.OpenElement(82, "strong");
            __builder.AddContent(83, "Host ");
            __builder.AddContent(84, 
#nullable restore
#line 65 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                          item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, " Grade: ");
            __builder.AddContent(86, 
#nullable restore
#line 65 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                                 item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 66 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "C":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "\t\t\t\t");
            __builder.OpenElement(89, "p");
            __builder.AddAttribute(90, "style", "color:lightyellow;");
            __builder.OpenElement(91, "strong");
            __builder.AddContent(92, "Host ");
            __builder.AddContent(93, 
#nullable restore
#line 68 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                            item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " Grade: ");
            __builder.AddContent(95, 
#nullable restore
#line 68 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                                   item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 69 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "D":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "\t\t\t\t");
            __builder.OpenElement(98, "p");
            __builder.AddAttribute(99, "style", "color:yellow;");
            __builder.OpenElement(100, "strong");
            __builder.AddContent(101, "Host ");
            __builder.AddContent(102, 
#nullable restore
#line 71 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                       item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(103, " Grade: ");
            __builder.AddContent(104, 
#nullable restore
#line 71 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                              item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 72 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "E":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(106, "\t\t\t\t");
            __builder.OpenElement(107, "p");
            __builder.AddAttribute(108, "style", "color:darkred;");
            __builder.OpenElement(109, "strong");
            __builder.AddContent(110, "Host ");
            __builder.AddContent(111, 
#nullable restore
#line 74 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                        item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(112, " Grade: ");
            __builder.AddContent(113, 
#nullable restore
#line 74 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                               item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 75 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			case "F":

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "\t\t\t\t");
            __builder.OpenElement(116, "p");
            __builder.AddAttribute(117, "style", "color:red;");
            __builder.OpenElement(118, "strong");
            __builder.AddContent(119, "Host ");
            __builder.AddContent(120, 
#nullable restore
#line 77 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                    item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(121, " Grade: ");
            __builder.AddContent(122, 
#nullable restore
#line 77 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                           item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 78 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;
			default:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(124, "\t\t\t\t");
            __builder.OpenElement(125, "p");
            __builder.AddAttribute(126, "style", "color:gray;");
            __builder.OpenElement(127, "strong");
            __builder.AddContent(128, "Host ");
            __builder.AddContent(129, 
#nullable restore
#line 80 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                     item.IpAddress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(130, " Grade: ");
            __builder.AddContent(131, 
#nullable restore
#line 80 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                            item.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 81 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
				break;

		}
	}


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(133, "\t<br>\r\n\t<br>\r\n");
            __builder.AddMarkupContent(134, "\t");
            __builder.OpenElement(135, "p");
            __builder.AddMarkupContent(136, "\r\n\r\n\t\t");
            __builder.AddMarkupContent(137, "<button style=\"margin-top:1%;margin-bottom:1%;\" class=\"btn btn-dark\" data-toggle=\"collapse\" data-target=\"#cipers\"><strong>Show Server ciphers</strong></button>\r\n\r\n\t\t");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "id", "cipers");
            __builder.AddAttribute(140, "class", "collapse");
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 94 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
             foreach (var item in Analysis.Endpoints)
			{
				foreach (var cipher in item.Details.Suites.List)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, "\t\t\t");
            __builder.OpenElement(143, "p");
            __builder.AddMarkupContent(144, "<strong>Name:</strong> ");
            __builder.AddContent(145, 
#nullable restore
#line 98 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                       cipher.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n\t\t\t");
            __builder.OpenElement(147, "p");
            __builder.AddMarkupContent(148, "<strong>Cipher Strength:</strong> ");
            __builder.AddContent(149, 
#nullable restore
#line 99 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                  cipher.CipherStrength

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n\t\t\t");
            __builder.OpenElement(151, "p");
            __builder.AddMarkupContent(152, "<strong>Dh Strength:</strong> ");
            __builder.AddContent(153, 
#nullable restore
#line 100 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                               cipher.DhStrength ?? "Not Found"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n\t\t\t");
            __builder.OpenElement(155, "p");
            __builder.AddMarkupContent(156, "<strong>Dh bits:</strong> ");
            __builder.AddContent(157, 
#nullable restore
#line 101 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                           cipher.DhYs ?? "Not Found"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n\t\t\t");
            __builder.OpenElement(159, "p");
            __builder.AddMarkupContent(160, "<strong>ECDH Strength:</strong> ");
            __builder.AddContent(161, 
#nullable restore
#line 102 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                cipher.EcdhStrength

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n\t\t\t");
            __builder.OpenElement(163, "p");
            __builder.AddMarkupContent(164, "<strong>ECDH bits:</strong> ");
            __builder.AddContent(165, 
#nullable restore
#line 103 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                            cipher.EcdhStrength

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 104 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
		}
	}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(167, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n\r\n\t\t\t");
            __builder.AddMarkupContent(169, "<button style=\"margin-top:1%;margin-bottom:1%;\" class=\"btn btn-dark\" data-toggle=\"collapse\" data-target=\"#protocols\"><strong>Show Protocols</strong></button>\r\n\r\n\t\t\t");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "id", "protocols");
            __builder.AddAttribute(172, "class", "collapse");
            __builder.AddMarkupContent(173, "\r\n");
#nullable restore
#line 111 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                 foreach (var item in Analysis.Endpoints)
				{
					foreach (var proto in item.Details.Protocols)
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(174, "\t\t\t\t\t\t");
            __builder.OpenElement(175, "p");
            __builder.AddMarkupContent(176, "<strong>Name:</strong> ");
            __builder.AddContent(177, 
#nullable restore
#line 115 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                   proto.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(179, "p");
            __builder.AddMarkupContent(180, "<strong>V2 Suites Disabled:</strong> ");
            __builder.AddContent(181, 
#nullable restore
#line 116 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                                  proto.V2SuitesDisabled ?? "Not Found"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(183, "p");
            __builder.AddMarkupContent(184, "<strong>Version:</strong> ");
            __builder.AddContent(185, 
#nullable restore
#line 117 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
                                                      proto.Version

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n");
#nullable restore
#line 118 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
					}
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(187, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n");
#nullable restore
#line 122 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
		}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "C:\Users\A_Justin.Midler\source\repos\TellMeMore\TellMeMoreBlazor\Pages\Qualys\Scan.razor"
 
	public string Error { get; set; }
	public string Loading { get; set; }
	public string HostUrl { get; set; }
	public SslLabsLib.Objects.Analysis Analysis { get; set; } = new SslLabsLib.Objects.Analysis();

	async Task LoadResultsAsync()
	{
		try
		{
			Loading = "Scan running .. Please Wait...";
			Analysis = await IQualysService.QualysReport(HostUrl);

			Loading = string.Empty;
		}
		catch (HttpRequestException ex)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TellMeMoreBlazor.Interfaces.IQualysService IQualysService { get; set; }
    }
}
#pragma warning restore 1591
