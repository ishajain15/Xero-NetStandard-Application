#pragma checksum "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7079c1cb716fc91467d78654126cfb10b9756959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvoiceSync_Submit), @"mvc.1.0.view", @"/Views/InvoiceSync/Submit.cshtml")]
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
#line 1 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/_ViewImports.cshtml"
using XeroNetStandardApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/_ViewImports.cshtml"
using XeroNetStandardApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7079c1cb716fc91467d78654126cfb10b9756959", @"/Views/InvoiceSync/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_InvoiceSync_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<XeroNetStandardApp.Models.InvoiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Submit an Invoice</h2>\n");
#nullable restore
#line 4 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <table border=\"1\">\n    <tr>\n      <th>Invoice #</th>\n      <th>To</th>\n      <th>Date</th>\n      <th>Due Date</th>\n      <th>Total Due</th>\n      <th>Status</th>\n      <th>Submit?</th>\n    </tr>\n \n");
#nullable restore
#line 16 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
   for (var i = 0; i < Model.Count(); i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      ");
#nullable restore
#line 18 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
 Write(Html.HiddenFor(models => models[i].invoiceId, new {Value = Model[i].invoiceId, Name = "invoiceId"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      <td>");
#nullable restore
#line 19 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 20 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.Contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 21 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 22 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 23 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 24 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Model[i].invoice.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 25 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
     Write(Html.CheckBoxFor(models => models[i].isChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 27 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </table>\n  <br>\n  <input id=\"selected\" type=\"submit\" value=\"Submit\"/>\n");
#nullable restore
#line 31 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br>\n<br>\n\n<p>\n  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 896, "\"", 950, 3);
            WriteAttributeValue("", 906, "location.href=\'", 906, 15, true);
#nullable restore
#line 37 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/InvoiceSync/Submit.cshtml"
WriteAttributeValue("", 921, Url.Action("Index", "Home"), 921, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 949, "\'", 949, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<XeroNetStandardApp.Models.InvoiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
