#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4e940a6fb1e0088b982b1bf78bb7b58adce3310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SyloStatus), @"mvc.1.0.view", @"/Views/Shared/SyloStatus.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
using MaterialStatus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
using MaterialStatus.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4e940a6fb1e0088b982b1bf78bb7b58adce3310", @"/Views/Shared/SyloStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70758daadc908d9a56766f9383836b2019cca751", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SyloStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<article class=\"sylo sylo-halle-b\"> <!--Halle B, Line 1 -->\r\n    <div class=\"sylo-left-block\">\r\n        <h2 class=\"sylo-header\">Sylo <span class=\"sylo-number\">");
#nullable restore
#line 7 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                          Write(Config.HalleB_Linie1_SyloNr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
        <div class=""sylo-image-wrapper"">
            <img class=""sylo-image"" src=""/images/img_silo.png""
                 alt=""Sylo icon"" />
        </div>
    </div>
    <div class=""sylo-right-block"">
        <table class=""table-material"">
            <tr class=""table-material-row"">
                <th class=""table-material-header-item"">Material</th>
                <th class=""table-material-header-item"">Soll C.</th>
                <th class=""table-material-header-item"">Ist C.</th>
                <th class=""table-material-header-item"">Soll, Kg</th>
                <th class=""table-material-header-item"">Ist, Kg </th>
                <th class=""table-material-header-item"">AuftragsNr</th>
                <th class=""table-material-header-item"">LineId</th>
                <th class=""table-material-header-item"">AnfangsDatum</th>
                <th class=""table-material-header-item"">EndDatum</th>
                <th class=""table-material-header-item"">RezeptNr</th>
                <");
            WriteLiteral("th class=\"table-material-header-item\">RezeptVersion</th>\r\n\r\n            </tr>\r\n            <!-- foreach -->\r\n");
#nullable restore
#line 30 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
             foreach (var item in ViewData["DataB"] as List<DispoB>)
            {
                if (item.Line_id == Config.HalleB_Linie1_id & item.Start_time >= new DateTime(2023, 12,01))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-material-row\">\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 35 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Material_Bez);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 36 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Chargenanzahl_soll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 37 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Chargenanzahl_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 38 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(Math.Round(item.Auftrags_gewicht, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 39 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(Math.Round(item.Auftrags_gewicht_ist, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 40 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Auftragsnr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 41 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Line_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 42 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Start_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 43 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.End_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 44 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Rezept_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 45 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Rezept_version_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</article>\r\n\r\n<article class=\"sylo sylo-halle-b\"> <!--Halle B, Line 3 -->\r\n    <div class=\"sylo-left-block\">\r\n        <h2 class=\"sylo-header\">Sylo <span class=\"sylo-number\">");
#nullable restore
#line 55 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                          Write(Config.HalleB_Linie3_SyloNr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
        <div class=""sylo-image-wrapper"">
            <img class=""sylo-image"" src=""/images/img_silo.png""
                 alt=""Sylo icon"" />
        </div>
    </div>
    <div class=""sylo-right-block"">
        <table class=""table-material"">
            <tr class=""table-material-row"">
                <th class=""table-material-header-item"">Material</th>
                <th class=""table-material-header-item"">Soll C.</th>
                <th class=""table-material-header-item"">Ist C.</th>
                <th class=""table-material-header-item"">Soll, Kg</th>
                <th class=""table-material-header-item"">Ist, Kg </th>
                <th class=""table-material-header-item"">AuftragsNr</th>
                <th class=""table-material-header-item"">LineId</th>
                <th class=""table-material-header-item"">AnfangsDatum</th>
                <th class=""table-material-header-item"">EndDatum</th>
                <th class=""table-material-header-item"">RezeptNr</th>
                <");
            WriteLiteral("th class=\"table-material-header-item\">RezeptVersion</th>\r\n\r\n            </tr>\r\n            \r\n");
#nullable restore
#line 78 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
             foreach (var item in ViewData["DataB"] as List<DispoB>)
            {
                if (item.Line_id == Config.HalleB_Linie3_id & item.Start_time >= new DateTime(2023, 12, 01))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-material-row\">\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 83 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Material_Bez);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 84 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Chargenanzahl_soll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 85 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Chargenanzahl_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 86 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(Math.Round(item.Auftrags_gewicht, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 87 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(Math.Round(item.Auftrags_gewicht_ist, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 88 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Auftragsnr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 89 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Line_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 90 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Start_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 91 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.End_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 92 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Rezept_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"table-material-item\">");
#nullable restore
#line 93 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                               Write(item.Rezept_version_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 96 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</article>\r\n\r\n<article class=\"sylo sylo-halle-g\"> <!--Halle G, Linie 2-->\r\n\r\n    <div class=\"sylo-left-block\">\r\n        <h2 class=\"sylo-header\">Sylo <span class=\"sylo-number\">");
#nullable restore
#line 105 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                          Write(Config.HalleG_SyloNr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
        <div class=""sylo-image-wrapper"">
            <img class=""sylo-image"" src=""/images/img_silo.png""
                 alt=""Sylo icon"" />
        </div>
    </div>
    <div class=""sylo-right-block"">
        <table class=""table-material"">
            <tr class=""table-material-row"">
                <th class=""table-material-header-item"">Material</th>
                <th class=""table-material-header-item"">Soll C.</th>
                <th class=""table-material-header-item"">Ist C.</th>
                <th class=""table-material-header-item"">Soll, Kg</th>
                <th class=""table-material-header-item"">Ist, Kg </th>
                <th class=""table-material-header-item"">AuftragsNr</th>
                <th class=""table-material-header-item"">LineId</th>
                <th class=""table-material-header-item"">AnfangsDatum</th>
                <th class=""table-material-header-item"">EndDatum</th>
                <th class=""table-material-header-item"">RezeptNr</th>
                <");
            WriteLiteral("th class=\"table-material-header-item\">RezeptVersion</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 127 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
             foreach (var item in ViewData["DataG"] as List<DispoG>)
            {
                if (item.Line_id == Config.HalleG_Linie2_id && item.Start_time >= new DateTime(2023, 12, 01))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"table-material-row\">\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 133 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Material_Bez);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 134 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Chargenanzahl_soll);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 135 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Chargenanzahl_ist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 136 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(Math.Round(item.Auftrags_gewicht, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 137 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(Math.Round(item.Auftrags_gewicht_ist, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 138 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Auftragsnr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 139 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Line_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 140 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Start_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 141 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.End_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 142 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Rezept_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table-material-item\">");
#nullable restore
#line 143 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                                   Write(item.Rezept_version_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 145 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</article>\r\n\r\n");
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
