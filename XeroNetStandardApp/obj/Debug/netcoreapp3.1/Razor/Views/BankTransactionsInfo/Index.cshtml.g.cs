#pragma checksum "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775946440c8039e57f104a38adccc1b61eafecc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankTransactionsInfo_Index), @"mvc.1.0.view", @"/Views/BankTransactionsInfo/Index.cshtml")]
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
#line 1 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/_ViewImports.cshtml"
using XeroNetStandardApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/_ViewImports.cshtml"
using XeroNetStandardApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775946440c8039e57f104a38adccc1b61eafecc4", @"/Views/BankTransactionsInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_BankTransactionsInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Xero BankTransactions</h2>\n\n<table border=\"1\">\n  <tr>\n    <th>Date</th>\n    <th>Reference</th>\n    <th>Type</th>\n    <th>Total</th>\n  </tr>\n");
#nullable restore
#line 12 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
   foreach (var bankTransaction in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      <td>");
#nullable restore
#line 14 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
     Write(bankTransaction.Date.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 15 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
     Write(bankTransaction.Reference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 16 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
     Write(bankTransaction.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 17 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
     Write(bankTransaction.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 19 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<br>\n<p>\n  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 440, "\"", 494, 3);
            WriteAttributeValue("", 450, "location.href=\'", 450, 15, true);
#nullable restore
#line 24 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/BankTransactionsInfo/Index.cshtml"
WriteAttributeValue("", 465, Url.Action("Index", "Home"), 465, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 493, "\'", 493, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Home</button>\n</p>\n");
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