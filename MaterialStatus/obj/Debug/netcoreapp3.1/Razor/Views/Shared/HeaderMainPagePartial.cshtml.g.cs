#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderMainPagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df96a07412891b36fe41313ca9c0dcd4a2e6f1af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderMainPagePartial), @"mvc.1.0.view", @"/Views/Shared/HeaderMainPagePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df96a07412891b36fe41313ca9c0dcd4a2e6f1af", @"/Views/Shared/HeaderMainPagePartial.cshtml")]
    public class Views_Shared_HeaderMainPagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header class=\"header\">\r\n    <nav class=\"main-nav\">\r\n        <div class=\"main-nav-left-block\">\r\n            <button class=\"button burger-button\" aria-label=\"Menu\">Burger</button>\r\n             ");
#nullable restore
#line 6 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderMainPagePartial.cshtml"
        Write(Html.Partial("ProjectLogoPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             ");
#nullable restore
#line 7 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderMainPagePartial.cshtml"
        Write(Html.Partial("NavigationElementsPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""main-nav-center-block"">
            <p class=""user-name"">John Snow</p>
        </div>
        <div class=""main-nav-right-block"">
            <ul class=""functional-nav"">
                <li class=""functional-nav-item"">
                    <a class=""admin-area-link"">Adminbereich</a>
                </li>
                <li class=""functional-nav-item"">
                    <a class=""help-link"">Hilfe</a>
                </li>
                <li class=""functional-nav-item"">
                    <a class=""logout-link"">Auslogen</a>
                </li>
                <li>
                    <button class=""button close-button"" aria-label=""Schliessen"">Close</button>
                </li>
            </ul>
        </div>
    </nav>
</header>");
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
