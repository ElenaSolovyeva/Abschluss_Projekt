#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39930472d9d6af02f61bffb04641df0402be8ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SyloStatus), @"mvc.1.0.view", @"/Views/Shared/SyloStatus.cshtml")]
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
#line 1 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
using MaterialStatus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39930472d9d6af02f61bffb04641df0402be8ba", @"/Views/Shared/SyloStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70758daadc908d9a56766f9383836b2019cca751", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SyloStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<article class=""sylo"">
    <div class=""sylo-left-block"">
        <h2 class=""sylo-header"">Sylo <span class=""sylo-number"">(10)</span></h2>
        <div class=""sylo-fullness"">
            <img class=""sylo-fullness-color"" src=""/images/icon_status_green.png""
                 alt=""Farbige abbildung von der Sylo-Befüllung"" />
            <p class=""sylo-fullness-value""><span>(78)</span>%</p>
        </div>
        <div class=""sylo-image-wrapper"">
            <img class=""sylo-image"" src=""/images/img_silo.png""
                 alt=""Sylo icon"" />
        </div>
    </div>
    <div class=""sylo-right-block"">
        <table class=""table-material"">
            <tr class=""table-material-row"">
                <th class=""table-material-header-item"">Rezept</th>
                <th class=""table-material-header-item"">Soll C.</th>
                <th class=""table-material-header-item"">Ist C.</th>
                <th class=""table-material-header-item"">Soll Kg</th>
                <th class=""table-material-he");
            WriteLiteral("ader-item\">Ist Kg </th>\r\n                <th class=\"table-material-header-item\">Ist Sackzahl</th>\r\n            </tr>\r\n            <!-- foreach -->\r\n");
#nullable restore
#line 28 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
             foreach (var item in ViewData["Data"] as List<Dispo>)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-material-row\">\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 32 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 33 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 34 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 35 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 36 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table-material-item\">");
#nullable restore
#line 37 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
                                           Write(item.Auftragsnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\SyloStatus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n</article>\r\n");
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
