#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2693eecaba341fdd4b48634fc1e59b94631794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TblGrundputzPartial), @"mvc.1.0.view", @"/Views/Shared/TblGrundputzPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
using MaterialStatus.Features.SWG.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
using MaterialStatus.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2693eecaba341fdd4b48634fc1e59b94631794", @"/Views/Shared/TblGrundputzPartial.cshtml")]
    public class Views_Shared_TblGrundputzPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<article class=""table-wrapper main-filter-item halle-g"">
    <h2>Grundputz</h2>
    <table class=""table-material"">
        <tr class=""table-material-row"">
            <th class=""table-material-header-item"">Rezept</th> <!-- => item.Material_Bez -->
            <th class=""table-material-header-item"">C. Soll</th> <!-- => item.chargenanzahl_soll -->
            <th class=""table-material-header-item"">C. Ist</th> <!-- => item.chargenanzahl_ist -->
            <th class=""table-material-header-item"">Soll, Kg</th> <!-- => item.auftrags_gewicht -->
            <th class=""table-material-header-item"">Ist, Kg </th> <!-- => item.auftrags_gewicht_ist -->

            <th class=""table-material-header-item"">LineId</th>
            <th class=""table-material-header-item"">StartTime</th>
        </tr>

");
#nullable restore
#line 18 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
         foreach (var item in ViewData["DispoG"] as List<MaterialStatus.Features.SWG.Models.tbl_dispo>)
        {
            if (item.start_time >= DateTime.Today)
            //(item.start_time > TimeRange.BeginnTestTime
            // & item.start_time < TimeRange.EndTestTime)
            {
                Config.GrundPutz_Counter++;
                long status = item.status;
                string bgc; // backgroundcolor

                switch (status)
                {
                    case 4:
                        bgc = "lightgreen";
                        break;
                    case 1:
                        bgc = "yellow";
                        break;
                    default:
                        bgc = "white";
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-material-row\"");
            BeginWriteAttribute("style", " style=\"", 1750, "\"", 1781, 3);
            WriteAttributeValue("", 1758, "background-color:", 1758, 17, true);
#nullable restore
#line 40 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
WriteAttributeValue(" ", 1775, bgc, 1776, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1780, ";", 1780, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 41 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.Material_Bez);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 42 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.chargenanzahl_soll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 43 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.chargenanzahl_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 44 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(Math.Round(item.auftrags_gewicht, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 45 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.auftrags_gewicht_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 47 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.line_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 48 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                               Write(item.start_time.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
         if (Config.GrundPutz_Counter == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr class=""table-material-row"">
                <td class=""table-material-item""> </td>
                <td class=""table-material-item""> 0 </td>
                <td class=""table-material-item""> 0 </td>
                <td class=""table-material-item""> 0 </td>
                <td class=""table-material-item""> 0 </td>                
                <td class=""table-material-item""> </td>
                <td class=""table-material-item"">");
#nullable restore
#line 62 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
                                           Write(DateTime.Today.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblGrundputzPartial.cshtml"
        }
        else
        {
            Config.GrundPutz_Counter = 0;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</article>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
