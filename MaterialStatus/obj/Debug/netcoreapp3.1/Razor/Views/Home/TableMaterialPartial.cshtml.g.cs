#pragma checksum "C:\Users\elena\Dropbox\Dokumente\for_backup\_Abschluss_Projekt\MaterialStatus\Views\Home\TableMaterialPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deecf4f852432c48a952644834aa6468c3ac3e8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TableMaterialPartial), @"mvc.1.0.view", @"/Views/Home/TableMaterialPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deecf4f852432c48a952644834aa6468c3ac3e8d", @"/Views/Home/TableMaterialPartial.cshtml")]
    public class Views_Home_TableMaterialPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table>
    <tr>
        <th>Rezept</th>
        <th>Soll C.</th>
        <th>Ist C.</th>
        <th>Soll Kg</th>
        <th>Ist Kg </th>
        <th>Ist Sackzahl</th>
    </tr>
    <!-- foreach -->
    <tr>
        <td>Test</td>
        <td>Test</td>
        <td>Test</td>
        <td>Test</td>
        <td>Test</td>
        <td>Test</td>
    </tr>
</table>");
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
