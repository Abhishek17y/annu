#pragma checksum "C:\Users\Abhishek\source\repos\Annu\Annu\Views\Category\CategoryDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054ec8fc95803721970f99a355e22dd02574d643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryDetail), @"mvc.1.0.view", @"/Views/Category/CategoryDetail.cshtml")]
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
#line 1 "C:\Users\Abhishek\source\repos\Annu\Annu\Views\_ViewImports.cshtml"
using Annu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abhishek\source\repos\Annu\Annu\Views\_ViewImports.cshtml"
using Annu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054ec8fc95803721970f99a355e22dd02574d643", @"/Views/Category/CategoryDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243080a0086a768ed376d36662264e8dba12123b", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Annu.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-6 offset-3"">
        <div class=""card"">
            <div class=""card-header"">
                <h4>Category Details</h4>
            </div>
            <div class=""card-body"">
                <table class=""table table-bordered"">

                    <tr>
                        <td><label>Image:</label></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><label>Name:</label></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><label>IsActive:</label></td>
                        <td></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Annu.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
