#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bead3c264595a516ed98da6443a40b13837178b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Fuellzustand), @"mvc.1.0.view", @"/Views/Shared/Fuellzustand.cshtml")]
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
#line 1 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
using MaterialStatus.Features.SWG.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
using MaterialStatus.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bead3c264595a516ed98da6443a40b13837178b8", @"/Views/Shared/Fuellzustand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70758daadc908d9a56766f9383836b2019cca751", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared_Fuellzustand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
 foreach (var item in ViewData["LagerG"] as List<MaterialStatus.Features.SWG.Models.tbl_lager>)
    {
        if (item.id >= Config.FirstSyloId_SWG & item.id <= Config.LastSyloId_SWG) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<article class=\"lager-place\">\r\n    <h2 lager-place-header>\r\n        Silo: <span class=\"lager-big-font\">");
#nullable restore
#line 10 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
                                      Write(item.bezeichnung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        / Füllstand: <span class=\"lager-big-font\">");
#nullable restore
#line 11 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
                                             Write(Math.Round(item.bestand_aktuell / 1000, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </h2>\r\n\r\n");
#nullable restore
#line 14 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
      string materialName = "nicht gefunden";
        foreach (var row in ViewData["MaterialG"] as List<MaterialStatus.Features.SWG.Models.tbl_material>)
        {
            if (item.fid_material == row.id)
            {
                materialName = row.bezeichnung;
                break;
            }
        } 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>Material: <span>");
#nullable restore
#line 25 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
                  Write(materialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n    \r\n    <div>\r\n        <img />\r\n        <div>\r\n            <div></div>\r\n            <p></p>\r\n        </div>\r\n    </div>\r\n</article>\r\n");
#nullable restore
#line 35 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\Fuellzustand.cshtml"
        }
    
    }

#line default
#line hidden
#nullable disable
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