#pragma checksum "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d9fa45617748f87bf806d11a2cd2d0532089c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d9fa45617748f87bf806d11a2cd2d0532089c1", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac19021c91be167c194f3992f966bad6a65a76b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">");
#nullable restore
#line 6 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2 class=\"text-danger\">");
#nullable restore
#line 7 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
                   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 9 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 14 "D:\GitHub Controle\repos\MVC-Vendas-Asp.Net-Core\MVC-Web-Sales\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591