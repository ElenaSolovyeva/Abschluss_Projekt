#pragma checksum "C:\Projects\Abschluss_Projekt\MaterialStatus\Views\Shared\ModalFilterMainPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0173b0eb36998b4926c4a3c9203df49fe2f167d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ModalFilterMainPartial), @"mvc.1.0.view", @"/Views/Shared/ModalFilterMainPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0173b0eb36998b4926c4a3c9203df49fe2f167d", @"/Views/Shared/ModalFilterMainPartial.cshtml")]
    public class Views_Shared_ModalFilterMainPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<form class=""main-filter visually-hidden"" action=""#"" method=""get""> <!--todo-->
    <fieldset>
        <legend>Benutzer</legend>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle1_all_lines"" value=""halle1_all_lines"" /> Alle</label><br/>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle1_line1"" value=""halle1_line1"" />Linie 1</label><br/>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle1_line2"" value=""halle1_line2"" />Linie 2</label>
    </fieldset>
    <fieldset>
        <legend>Halle 2</legend>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle2_all_lines"" value=""halle2_all_lines""/> Alle</label><br/>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle2_line1"" value=""halle2_line1""/>Linie 1</label><br/>
        <label class=""main-filter-item""><input type=""checkbox"" name=""halle2_line2"" value=""halle2_line2""/>Linie 2</label>
    </fieldset>
    <div class=""main-filter-buttons"">
   ");
            WriteLiteral("     <input type=\"submit\" value=\"Auswählen\"/>\r\n        <input type=\"reset\"/>\r\n    </div>\r\n</form>\r\n");
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
