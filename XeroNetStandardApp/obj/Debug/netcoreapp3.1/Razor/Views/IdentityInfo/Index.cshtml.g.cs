#pragma checksum "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ebdee0170d1a0850fec9f7e1ba3323b5db1357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IdentityInfo_Index), @"mvc.1.0.view", @"/Views/IdentityInfo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ebdee0170d1a0850fec9f7e1ba3323b5db1357", @"/Views/IdentityInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_IdentityInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Xero Connections</h2>

<table border=""1"">
  <tr>
    <th>Connection ID</th>
    <th>Tenant ID</th>
    <th>Tenant Type</th>
    <th>Tenant Name</th>
    <th>Created Date (UTC)</th>
    <th>Updated Date (UTC)</th>
    <th>Delete this Connection Using Connection Id</th>
  </tr>
");
#nullable restore
#line 15 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
   foreach (var connection in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      <td>");
#nullable restore
#line 17 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 18 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.TenantId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 19 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.TenantType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 20 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.TenantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 21 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.CreatedDateUTC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 22 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
     Write(connection.UpdatedDateUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>\n        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 597, "\"", 699, 3);
            WriteAttributeValue("", 607, "location.href=\'", 607, 15, true);
#nullable restore
#line 24 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
WriteAttributeValue("", 622, Url.Action("Delete", "IdentityInfo", new { connectionId = @connection.Id }), 622, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 698, "\'", 698, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\n      </td>\n    </tr>\n");
#nullable restore
#line 27 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<br>\n<p>\n  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 771, "\"", 825, 3);
            WriteAttributeValue("", 781, "location.href=\'", 781, 15, true);
#nullable restore
#line 32 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/IdentityInfo/Index.cshtml"
WriteAttributeValue("", 796, Url.Action("Index", "Home"), 796, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 824, "\'", 824, 1, true);
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