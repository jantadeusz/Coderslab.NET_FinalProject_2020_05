#pragma checksum "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3c595d6ac9cbba2d3e7c04dffaa35cab6fdfe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3c595d6ac9cbba2d3e7c04dffaa35cab6fdfe4", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Available Products:</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Lp</th>
            <th>Name</th>
            <th>Category</th>
            <th>Price</th>
            <th>Details</th>
            <th>Add to cart</th>
            <th>Image1</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
          int lp = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
         foreach (var product in Model)
        {
            lp++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"background-color: white\">\r\n            <td> ");
#nullable restore
#line 24 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
            Write(lp);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n            <td> ");
#nullable restore
#line 25 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      </td>\r\n            <td> ");
#nullable restore
#line 26 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
            Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  </td>\r\n            <td> ");
#nullable restore
#line 27 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     </td>\r\n            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3c595d6ac9cbba2d3e7c04dffaa35cab6fdfe45750", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 858, "~/Product/Details/", 858, 18, true);
#nullable restore
#line 28 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 876, product.Id, 876, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3c595d6ac9cbba2d3e7c04dffaa35cab6fdfe47350", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 933, "~/Product/AddToCart/", 933, 20, true);
#nullable restore
#line 29 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 953, product.Id, 953, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  </td>\r\n            <td>\r\n");
#nullable restore
#line 31 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
                  
                    if (@product.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img width=\"100\"");
            BeginWriteAttribute("src", " src=\"", 1132, "\"", 1161, 1);
#nullable restore
#line 34 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
WriteAttributeValue("", 1138, product.Image.FilePath, 1138, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 35 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
