#pragma checksum "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e988399cd216013f5f62ac03877dd3dd075aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
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
#line 1 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\_ViewImports.cshtml"
using MVC_Web_Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\_ViewImports.cshtml"
using MVC_Web_Sales.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e988399cd216013f5f62ac03877dd3dd075aae", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac19021c91be167c194f3992f966bad6a65a76b4", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Web_Sales.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 5 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "SimpleSearch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 9 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7e988399cd216013f5f62ac03877dd3dd075aae4695", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 473, "", 500, 1);
#nullable restore
#line 18 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 480, ViewData["minDate"], 480, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 500, "", 527, 1);
#nullable restore
#line 18 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 507, ViewData["minDate"], 507, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 727, "", 754, 1);
#nullable restore
#line 22 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 734, ViewData["maxDate"], 734, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 754, "", 781, 1);
#nullable restore
#line 22 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 761, ViewData["maxDate"], 761, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</nav>\n<div class=\"panel panel-primary\">\n    <div class=\"panel-heading\">\n        <h3 class=\"panel-title\">Total sales = ");
#nullable restore
#line 31 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    </div>\n    <div class=\"panel-body\">\n        <table class=\"table table-striped table-hover\">\n            <thead>\n                <tr class=\"success\">\n                    <th>\n                        ");
#nullable restore
#line 38 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 41 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 44 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 47 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 50 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 53 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 58 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 62 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 65 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 68 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 71 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 74 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 77 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 80 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        </\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Web_Sales.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
