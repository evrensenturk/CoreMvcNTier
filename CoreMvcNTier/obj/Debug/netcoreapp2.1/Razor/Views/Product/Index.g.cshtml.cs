#pragma checksum "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "466b5c279a8db1f1d1f5c02ef2bcb7d4cc9f7e05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\_ViewImports.cshtml"
using CoreMvcNTier;

#line default
#line hidden
#line 2 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\_ViewImports.cshtml"
using CoreMvcNTier.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"466b5c279a8db1f1d1f5c02ef2bcb7d4cc9f7e05", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3307f6362942c0dfd310b59effa96bf3ac9583", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreMvcNTier.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fccef64ce808427d85bc75b003f739df", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 105, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 47, false);
#line 17 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 48, false);
#line 20 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(415, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(471, 48, false);
#line 23 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductStock));

#line default
#line hidden
            EndContext();
            BeginContext(519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(575, 46, false);
#line 26 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductImg));

#line default
#line hidden
            EndContext();
            BeginContext(621, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(677, 48, false);
#line 29 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductBrand));

#line default
#line hidden
            EndContext();
            BeginContext(725, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(843, 62, true);
            WriteLiteral("        <tr>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(906, 46, false);
#line 39 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1008, 47, false);
#line 42 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1111, 47, false);
#line 45 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductStock));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1214, 45, false);
#line 48 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductImg));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1315, 47, false);
#line 51 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductBrand));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1418, 65, false);
#line 54 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1504, 71, false);
#line 55 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1596, 69, false);
#line 56 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\evrenşentürk\source\repos\CoreMvcNTier\CoreMvcNTier\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1704, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreMvcNTier.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
