#pragma checksum "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a24f3f1608d3747d565f92901fd7ebb2f9059a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
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
#line 2 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ComponentViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a24f3f1608d3747d565f92901fd7ebb2f9059a", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcf9b43084980e38f194158afed2c8b7ce99a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!--====== Category Part Start ======-->

<section class=""category-area category-bg pt-100 pb-100"">
    <div class=""container-fluid custom-container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-6"">
                <div class=""section-title text-center pb-30"">
                    <h2 class=""title"">Featured Categories</h2>
                </div>
            </div>
        </div> <!-- row -->
        <div class=""row category-active"">
");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
             for (int i = 0; i < (int)Math.Ceiling(((decimal)Model.Count() / 2)); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
                     foreach (var item in Model.Skip(i * 2).Take(2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-category text-center\">\r\n                            <a target=\"_blank\" href=\"shop-left-sidebar.html\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2a24f3f1608d3747d565f92901fd7ebb2f9059a5542", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 938, "~/assets/images/", 938, 16, true);
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
AddHtmlAttributeValue("", 954, item.Image, 954, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <p>");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n                        </div> <!-- single category -->\r\n");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Category\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div> <!-- row -->\r\n    </div> <!-- container -->\r\n</section>\r\n<!--====== Category Part Ends ======-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
