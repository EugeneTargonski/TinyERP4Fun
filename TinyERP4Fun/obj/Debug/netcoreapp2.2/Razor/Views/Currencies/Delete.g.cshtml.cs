#pragma checksum "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093332d7289ab738dbf7d522e2995905ddde02d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currencies_Delete), @"mvc.1.0.view", @"/Views/Currencies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currencies/Delete.cshtml", typeof(AspNetCore.Views_Currencies_Delete))]
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
#line 1 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\_ViewImports.cshtml"
using TinyERP4Fun;

#line default
#line hidden
#line 2 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\_ViewImports.cshtml"
using TinyERP4Fun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093332d7289ab738dbf7d522e2995905ddde02d2", @"/Views/Currencies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c3a4dff41bfda2f62716864e6dedd3530d2ec2", @"/Views/_ViewImports.cshtml")]
    public class Views_Currencies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TinyERP4Fun.Models.Common.Currency>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
  
    ViewData["Title"] = Localization.currentLocalizatin["Delete"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(167, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(174, 41, false);
#line 8 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
Write(Localization.currentLocalizatin["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 13, true);
            WriteLiteral("</h1>\r\n\r\n<h3>");
            EndContext();
            BeginContext(229, 72, false);
#line 10 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
Write(Localization.currentLocalizatin["Are you sure you want to delete this?"]);

#line default
#line hidden
            EndContext();
            BeginContext(301, 22, true);
            WriteLiteral("</h3>\r\n<div>\r\n    <h4>");
            EndContext();
            BeginContext(324, 43, false);
#line 12 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
   Write(Localization.currentLocalizatin["Currency"]);

#line default
#line hidden
            EndContext();
            BeginContext(367, 84, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(452, 39, false);
#line 16 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Code"]);

#line default
#line hidden
            EndContext();
            BeginContext(491, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(555, 36, false);
#line 19 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(591, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(652, 39, false);
#line 22 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(691, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(755, 36, false);
#line 25 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(791, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(852, 40, false);
#line 28 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Name2"]);

#line default
#line hidden
            EndContext();
            BeginContext(892, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(956, 37, false);
#line 31 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name2));

#line default
#line hidden
            EndContext();
            BeginContext(993, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1054, 46, false);
#line 34 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Part001Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1164, 43, false);
#line 37 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Part001Name));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1268, 47, false);
#line 40 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Part001Name2"]);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1379, 44, false);
#line 43 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Part001Name2));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1484, 41, false);
#line 46 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1525, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1589, 38, false);
#line 49 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1688, 39, false);
#line 52 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Localization.currentLocalizatin["Base"]);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1791, 36, false);
#line 55 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Base));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1865, 276, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093332d7289ab738dbf7d522e2995905ddde02d212571", async() => {
                BeginContext(1891, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1901, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "093332d7289ab738dbf7d522e2995905ddde02d212964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1937, 30, true);
                WriteLiteral("\r\n        <input type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1967, "", 2016, 1);
#line 61 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
WriteAttributeValue("", 1974, Localization.currentLocalizatin["Delete"], 1974, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2016, 38, true);
                WriteLiteral(" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2054, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093332d7289ab738dbf7d522e2995905ddde02d215354", async() => {
                    BeginContext(2077, 47, false);
#line 62 "c:\Users\Yauheni_Tarhonski\source\repos\epm_lab_Yauheni_Tarhonski\TinyERP4Fun\Views\Currencies\Delete.cshtml"
                         Write(Localization.currentLocalizatin["Back to List"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2128, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2141, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TinyERP4Fun.Models.Common.Currency> Html { get; private set; }
    }
}
#pragma warning restore 1591