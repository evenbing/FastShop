#pragma checksum "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dfdfa4b55e853e19a4bea1ac91087155aeb8817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Users.cshtml", typeof(AspNetCore.Views_Admin_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfdfa4b55e853e19a4bea1ac91087155aeb8817", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlockOrUnlockAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(109, 1058, true);
            WriteLiteral(@"
<h1>Usuarios</h1>

<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
        Listado de usuarios
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Estado</th>
                        <th>Numero</th>
                        <th>Correo</th>
                        <th>Dirreción</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Nombre</th>
                        <th>Estado</th>
                        <th>Numero</th>
                        <th>Correo</th>
                        <th>Dirreción</th>
                        <th>Acciones</th>
                    </tr>
                </t");
            WriteLiteral("foot>\r\n\r\n                <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1240, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1303, 13, false);
#line 41 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                           Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 42 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                              
                                string state = item.LockoutEnabled == false ? "Activo" : "Inactivo";
                            

#line default
#line hidden
            BeginContext(1488, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1521, 5, false);
#line 45 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                           Write(state);

#line default
#line hidden
            EndContext();
            BeginContext(1526, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1566, 16, false);
#line 46 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1622, 10, false);
#line 47 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1672, 12, false);
#line 48 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 50 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                                 if (item.LockoutEnabled)
                                {

#line default
#line hidden
            BeginContext(1819, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1855, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dfdfa4b55e853e19a4bea1ac91087155aeb88178092", async() => {
                BeginContext(1941, 119, true);
                WriteLiteral("\r\n                                        <b class=\"text-success\">Desbloquear</b>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2064, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2174, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2210, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dfdfa4b55e853e19a4bea1ac91087155aeb881711167", async() => {
                BeginContext(2296, 115, true);
                WriteLiteral("\r\n                                        <b class=\"text-danger\">Bloquear</b>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2415, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                                }

#line default
#line hidden
            BeginContext(2452, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Orbis\source\repos\OnlineShop\OnlineShop\Views\Admin\Users.cshtml"
                    }

#line default
#line hidden
            BeginContext(2541, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
