#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderLoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d924c4345717a8b391bb488c0362402041e5c40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderLoginPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderLoginPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d924c4345717a8b391bb488c0362402041e5c40d", @"/Views/Shared/HeaderLoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70758daadc908d9a56766f9383836b2019cca751", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared_HeaderLoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header class=\"header\">\r\n    <nav class=\"nav nav-login\">\r\n       ");
#nullable restore
#line 3 "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\HeaderLoginPartial.cshtml"
  Write(Html.Partial("ProjectLogoPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </nav>\r\n</header>");
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
