#pragma checksum "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72f012fe6c834f53506c6969dd64ad7e882cf26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72f012fe6c834f53506c6969dd64ad7e882cf26", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72f012fe6c834f53506c6969dd64ad7e882cf264584", async() => {
                WriteLiteral("Add Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<h1>Categories in system:</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>Lp</th>
            <th>Name</th>
            <th>Remove</th>
        </tr>
    </thead>
    <tfoot>
        <tr>
            <th>Lp</th>
            <th>Name</th>
            <th>Remove</th>
        </tr>
    </tfoot>
    <tbody>
");
#nullable restore
#line 25 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
          int lp = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
         foreach (CategoryModel category in Model)
        {
            lp++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"background-color: white\">\r\n                <td> ");
#nullable restore
#line 30 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
                Write(lp);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                <td> ");
#nullable restore
#line 31 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
                Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      </td>\r\n                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72f012fe6c834f53506c6969dd64ad7e882cf267700", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 858, "~/Category/Remove/", 858, 18, true);
#nullable restore
#line 32 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
AddHtmlAttributeValue("", 876, category.Id, 876, 12, false);

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
            WriteLiteral("   </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Category\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
