#pragma checksum "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67464821b6b31cc42e8aa34ec1a28759bfdafd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceSync_Index), @"mvc.1.0.view", @"/Views/InvoiceSync/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67464821b6b31cc42e8aa34ec1a28759bfdafd8", @"/Views/InvoiceSync/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceSync_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Xero Invoices in the Last 7 Days</h2>\n\n<table border=\"1\">\n  <tr>\n    <th>Invoice #</th>\n    <th>To</th>\n    <th>Date</th>\n    <th>Due Date</th>\n    <th>Total Due</th>\n    <th>Status</th>\n  </tr>\n");
#nullable restore
#line 14 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
   foreach (var invoice in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      <td>");
#nullable restore
#line 16 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 17 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.Contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 18 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.Date.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 19 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.DueDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 20 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 21 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
     Write(invoice.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 23 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<br>\n<p>\n  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 561, "\"", 615, 3);
            WriteAttributeValue("", 571, "location.href=\'", 571, 15, true);
#nullable restore
#line 28 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/InvoiceSync/Index.cshtml"
WriteAttributeValue("", 586, Url.Action("Index", "Home"), 586, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 614, "\'", 614, 1, true);
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
