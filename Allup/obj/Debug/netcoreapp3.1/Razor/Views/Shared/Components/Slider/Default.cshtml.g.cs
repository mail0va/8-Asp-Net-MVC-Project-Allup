#pragma checksum "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392352624023d3234f8dbce134957005c1ccf343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392352624023d3234f8dbce134957005c1ccf343", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcf9b43084980e38f194158afed2c8b7ce99a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("<!--====== Slider Part Start ======-->\r\n\r\n<section class=\"slider-area slider-active\">\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
     foreach (Slider slider in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slider\">\r\n            <div class=\"slider-image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "392352624023d3234f8dbce134957005c1ccf3434674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 291, "~/assets/images/", 291, 16, true);
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 307, slider.Image, 307, 13, false);

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
            WriteLiteral(@"
            </div>
            <div class=""slider-content-wrapper"">
                <div class=""container-fluid custom-container"">
                    <div class=""slider-content"">
                        <h4 data-animation=""fadeInDown"" data-delay=""0.5s"" class=""sub-title"">");
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
                                                                                       Write(slider.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h1 data-animation=\"fadeInLeft\" data-delay=\"0.5s\" class=\"main-title \">");
#nullable restore
#line 17 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
                                                                                         Write(Html.Raw(slider.MainTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p data-animation=\"fadeInRightBig\" data-delay=\"0.5s\">");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
                                                                        Write(slider.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a data-animation=\"zoomIn\" data-delay=\"0.5s\" class=\"main-btn \"");
            BeginWriteAttribute("href", " href=\"", 945, "\"", 968, 1);
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 952, slider.PageLink, 952, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Shop Now</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\Components\Slider\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<!--====== Slider Part Ends ======-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
