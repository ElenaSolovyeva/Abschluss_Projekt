#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6e0070538e63d8159cee7baa5e1cb1a4c9dde5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TblEdelputz1500Partial), @"mvc.1.0.view", @"/Views/Shared/TblEdelputz1500Partial.cshtml")]
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
#line 1 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
using MaterialStatus.Features.SWB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
using MaterialStatus.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6e0070538e63d8159cee7baa5e1cb1a4c9dde5", @"/Views/Shared/TblEdelputz1500Partial.cshtml")]
    public class Views_Shared_TblEdelputz1500Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<article class=""table-wrapper main-filter-item halle-b"">
    <h2>Edelputz 1500</h2>
    <table class=""table-material"">
        <tr class=""table-material-row"">
            <th class=""table-material-header-item"">Rezept</th> <!-- => item.Material_Bez -->
            <th class=""table-material-header-item"">C. Soll</th> <!-- => item.chargenanzahl_soll -->
            <th class=""table-material-header-item"">C. Ist</th> <!-- => item.chargenanzahl_ist -->
            <th class=""table-material-header-item"">Soll, Kg</th> <!-- => item.auftrags_gewicht -->
            <th class=""table-material-header-item"">Ist, Kg </th> <!-- => item.auftrags_gewicht_ist -->
            <th class=""table-material-header-item"">Ist Sackzahl</th>
            <th class=""table-material-header-item"">Farbe</th>
            <th class=""table-material-header-item"">LineId</th>
            <th class=""table-material-header-item"">StartTime</th>
        </tr>

");
#nullable restore
#line 19 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
         foreach (var item in ViewData["DispoB"] as List<MaterialStatus.Features.SWB.Models.tbl_dispo>)
        {
            if (item.line_id == Config.Edelputz1500_LineId
                & item.start_time >= DateTime.Today)
                //& item.start_time > TimeRange.BeginnTestTime
                //& item.start_time < TimeRange.EndTestTime)
            {
                Config.Edelputz1500_Counter++;
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
            BeginWriteAttribute("style", " style=\"", 1960, "\"", 1991, 3);
            WriteAttributeValue("", 1968, "background-color:", 1968, 17, true);
#nullable restore
#line 43 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
WriteAttributeValue(" ", 1985, bgc, 1986, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1990, ";", 1990, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 44 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(item.Material_Bez);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 45 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(item.chargenanzahl_soll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 46 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(item.chargenanzahl_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 47 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(Math.Round(item.auftrags_gewicht, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 48 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(Math.Round(item.auftrags_gewicht_ist, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"table-material-item\">\r\n                        <!-- Ist Sackzahl -->\r\n");
#nullable restore
#line 52 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                          Sackzahl sackzahl = new Sackzahl(ViewData["DispoB"] as List<MaterialStatus.Features.SWB.Models.tbl_dispo>);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 53 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                   Write(sackzahl.GetSackzahlSWB(item.auftragsnr, Config.Edelputz1500_LineId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"table-material-item\">\r\n                        <!-- Farbbezeichnung -->\r\n");
#nullable restore
#line 58 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                          
                            string GetFarbeBezechnung(long farb_id)
                            {
                                string result = "";

                                foreach (var row in ViewData["FarbeBezeichnungB"] as List<MaterialStatus.Features.SWB.Models.tbl_stueckliste_historie_kopf>)
                                {
                                    if (row.Fid_Material == farb_id)
                                    {
                                        result = row.Bezeichnung.ToString();
                                        break;
                                    }
                                }
                                return result;
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 74 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                   Write(GetFarbeBezechnung(item.farb_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 76 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(item.line_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 77 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                               Write(item.start_time.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
         if (Config.Edelputz1500_Counter == 0)
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
                <td class=""table-material-item""> 0 </td>
                <td class=""table-material-item""> </td>
                <td class=""table-material-item""> </td>
                <td class=""table-material-item"">");
#nullable restore
#line 93 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
                                           Write(DateTime.Today.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 95 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\TblEdelputz1500Partial.cshtml"
        }
        else
        {
            Config.Edelputz1500_Counter = 0;
        }    

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </table>\r\n</article>\r\n\r\n");
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
