#pragma checksum "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6c9299a85466f205d5ef4f72000c6ce9c25d96e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_Add), @"mvc.1.0.view", @"/Views/Image/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c9299a85466f205d5ef4f72000c6ce9c25d96e", @"/Views/Image/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    public class Views_Image_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Add Image to product with id: ");
#nullable restore
#line 6 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml"
                             Write(ViewData["productId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div class=""row"">
    <!--
    odel App.ViewModels.ImageViewModel
        <form asp-controller=""Image"" asp-action=""Add"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ImageFile"" class=""control-label""></label>
                <input type=""file"" name=""ImageFile"" class=""form-control"" multiple />
                <span asp-validation-for=""ImageFile"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
        -->
");
#nullable restore
#line 22 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml"
     using (Html.BeginForm("Add", "Image", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 949, "\"", 979, 1);
#nullable restore
#line 24 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml"
WriteAttributeValue("", 957, ViewData["productId"], 957, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"file\" name=\"file\" />\r\n        <br />\r\n        <input type=\"submit\" name=\"Submit\" id=\"Submit\" value=\"Upload\" />\r\n");
#nullable restore
#line 28 "F:\Coderslab.NET\07_ProjektKoncowy\Coderslab.NET_FinalProject_2020_05\FinalProject_LocalTrader\App\Views\Image\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
