#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderAdminAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7e7413b13c9544a276fd0ca42d04e8bc805b74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderAdminAreaPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderAdminAreaPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7e7413b13c9544a276fd0ca42d04e8bc805b74", @"/Views/Shared/HeaderAdminAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70758daadc908d9a56766f9383836b2019cca751", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderAdminAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header class=\"header\">\r\n    <nav class=\"main-nav\">\r\n        <div class=\"main-nav-block main-nav-left-block\">\r\n            ");
#nullable restore
#line 4 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderAdminAreaPartial.cshtml"
       Write(Html.Partial("ProjectLogoPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 5 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderAdminAreaPartial.cshtml"
       Write(Html.Partial("NavigationAdminPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""main-nav-block main-nav-center-block"">
            <p class=""nav-item user-name"">John Snow</p>
        </div>
        <div class=""main-nav-right-block"">
            <ul class=""functional-nav main-nav-block"">
                <li class=""functional-nav-item"">
                    <a class=""admin-area-link main-page-link"" href=""MainPage"">MainPage</a>
                </li>
                <li class=""functional-nav-item"">
                    <a class=""help-link main-page-link"">Hilfe</a>
                </li>
                <li class=""functional-nav-item"">
                    <a class=""logout-link main-page-link"" href=""https://localhost:44340/"">Ausloggen</a>
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
