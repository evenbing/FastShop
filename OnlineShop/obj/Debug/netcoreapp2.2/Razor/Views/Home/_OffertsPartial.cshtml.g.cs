#pragma checksum "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b136d8f312ee04633bf9369da2aeaa376ee18fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__OffertsPartial), @"mvc.1.0.view", @"/Views/Home/_OffertsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_OffertsPartial.cshtml", typeof(AspNetCore.Views_Home__OffertsPartial))]
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
#line 1 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 2 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b136d8f312ee04633bf9369da2aeaa376ee18fd1", @"/Views/Home/_OffertsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__OffertsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.Models.Offert>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("~/img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("700"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 226, true);
            WriteLiteral("\r\n<section class=\"hero-banner\">\r\n    <div class=\"container\">\r\n        <div class=\"row no-gutters align-items-center pt-60px\">\r\n            <div class=\"col-5 d-none d-sm-block\">\r\n                <div class=\"hero-banner__img\">\r\n");
            EndContext();
#line 8 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
                      
                        var image = Model == null ? "default.png" 
                            : Model.ImageOfferts.OrderBy(x => Guid.NewGuid()).FirstOrDefault()?.ImageName;
                    

#line default
#line hidden
            BeginContext(477, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(497, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b136d8f312ee04633bf9369da2aeaa376ee18fd14672", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 540, "~/files/", 540, 8, true);
#line 12 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
AddHtmlAttributeValue("", 548, image, 548, 6, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
AddHtmlAttributeValue("", 561, image, 561, 6, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 231, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-7 col-lg-6 offset-lg-1 pl-4 pl-md-5 pl-lg-0\">\r\n                <div class=\"hero-banner__content\">\r\n                    <h4></h4>\r\n                    <h1>");
            EndContext();
            BeginContext(801, 14, false);
#line 18 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
                   Write(Model?.Concept);

#line default
#line hidden
            EndContext();
            BeginContext(815, 30, true);
            WriteLiteral("</h1>\r\n                    <p>");
            EndContext();
            BeginContext(846, 18, false);
#line 19 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
                  Write(Model?.Description);

#line default
#line hidden
            EndContext();
            BeginContext(864, 80, true);
            WriteLiteral("</p>\r\n                    <a class=\"button button-hero\" href=\"#\">Valida hasta : ");
            EndContext();
            BeginContext(945, 15, false);
#line 20 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Home\_OffertsPartial.cshtml"
                                                                     Write(Model?.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(960, 88, true);
            WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.Models.Offert> Html { get; private set; }
    }
}
#pragma warning restore 1591
