#pragma checksum "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e3d44302371beef22401020a7efc21b7db90c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketCartPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketCartPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e3d44302371beef22401020a7efc21b7db90c8", @"/Views/Shared/_BasketCartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcf9b43084980e38f194158afed2c8b7ce99a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketCartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletefrombasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"cart-btn\">\r\n    <a href=\"#\">\r\n        <i class=\"icon ion-bag\"></i>\r\n        <span class=\"text\">Cart :</span>\r\n        <span class=\"total\">$");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                         Write((Model.Sum(b=>b.Price)+ Model.Sum(b=>b.ExTax)).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"count\">");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n</div>\r\n<div class=\"mini-cart\">\r\n    <ul class=\"cart-items\">\r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
         foreach (BasketVM basketVM in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"single-cart-item d-flex\">\r\n                    <div class=\"cart-item-thumb\">\r\n                        <a href=\"single-product.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8e3d44302371beef22401020a7efc21b7db90c86547", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 629, "~/assets/images/product/", 629, 24, true);
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
AddHtmlAttributeValue("", 653, basketVM.Image, 653, 15, false);

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
            WriteLiteral("</a>\r\n                        <span class=\"product-quantity\">");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                   Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\r\n                    </div>\r\n                    <div class=\"cart-item-content media-body\">\r\n                        <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                                          Write(basketVM.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                        <span class=\"product-price\">???");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                Write(basketVM.Price.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e3d44302371beef22401020a7efc21b7db90c89352", async() => {
                WriteLiteral("\r\n                            <i class=\"fal fa-times\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                                                                   WriteLiteral(basketVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <div class=\"price_content\">\r\n        <div class=\"cart-subtotals\">\r\n            <div class=\"products price_inline\">\r\n                <span class=\"label\">Subtotal</span>\r\n                <span class=\"value\">???");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                 Write(Model.Sum(b=>b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"tax price_inline\">\r\n                <span class=\"label\">Taxes</span>\r\n                <span class=\"value\">???");
#nullable restore
#line 46 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                                 Write(Model.Sum(b=>b.ExTax * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"cart-total price_inline\">\r\n            <span class=\"label\">Total</span>\r\n            <span class=\"value\">???");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_BasketCartPartial.cshtml"
                             Write(Model.Sum(b => b.ExTax * b.Count) + Model.Sum(b => b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div> <!-- price content -->\r\n    <div class=\"checkout text-center\">\r\n        <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\r\n    </div>\r\n</div> <!-- mini cart -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
