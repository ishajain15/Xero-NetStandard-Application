#pragma checksum "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/ContactsInfo/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0e9dbdb6f1388dce7032a1156f4bedbac7bec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactsInfo_Create), @"mvc.1.0.view", @"/Views/ContactsInfo/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0e9dbdb6f1388dce7032a1156f4bedbac7bec5", @"/Views/ContactsInfo/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactsInfo_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>Create a Xero Contact</h2>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0e9dbdb6f1388dce7032a1156f4bedbac7bec53592", async() => {
                WriteLiteral(@"
    <label for=""Name"">Contact Name:</label>
    <br>
    <input type=""text"" id=""Name"" placeholder=""Enter a unique name"" name=""input.Name""/>
    <br>
    <label for=""EmailAddress"">Contact Email Address:</label>
    <br>
    <input type=""text"" id=""EmailAddress"" placeholder=""Enter email address"" name=""input.EmailAddress"" />
    <br>
    <label for=""AccountNumber"">Account Number:</label>
    <br>
    <input type=""text"" id=""AccountNumber"" placeholder=""Enter account number"" name=""input.AccountNumber"" />
    <br>
    <label for=""Address1"">Postal Address Line 1:</label>
    <br>
    <input type=""text"" id=""Address1"" placeholder=""Enter postal address line 1"" name=""input.Addresses[0].AddressLine1"" />
    <br>
    <label for=""Address2"">Postal Address Line 2:</label>
    <br>
    <input type=""text"" id=""Address2"" placeholder=""Enter postal address line 2"" name=""input.Addresses[0].AddressLine2"" />
    <br>
    <label for=""City"">Postal City:</label>
    <br>
    <input type=""text"" id=""City"" placeholder=""Enter postal city"" na");
                WriteLiteral(@"me=""input.Addresses[0].City"" />
    <br>
    <label for=""Region"">Postal Region:</label>
    <br>
    <input type=""text"" id=""Region"" placeholder=""Enter postal region"" name=""input.Addresses[0].Region"" />
    <br>
    <label for=""PostalCode"">Postal Zip Code:</label>
    <br>
    <input type=""text"" id=""PostalCode"" placeholder=""Enter postal zip code"" name=""input.Addresses[0].PostalCode"" />
    <br>
    <label for=""Country"">Postal Country:</label>
    <br>
    <input type=""text"" id=""Country"" placeholder=""Enter postal country"" name=""input.Addresses[0].Country"" />
    <br>
    <label for=""SalesName"">Sales Tracking Category Name:</label>
    <br>
    <input type=""text"" id=""SalesName"" placeholder=""Enter sales tracking category name"" name=""sales.TrackingCategoryName"" />
    <br>
    <label for=""SalesOption"">Sales Tracking Category Option:</label>
    <br>
    <input type=""text"" id=""SalesOption"" placeholder=""Enter sales tracking category option"" name=""sales.TrackingOptionName"" />
    <br>
    <br>
    <input type=""submit");
                WriteLiteral("\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<br>\n<p>\n  <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2132, "\"", 2186, 3);
            WriteAttributeValue("", 2142, "location.href=\'", 2142, 15, true);
#nullable restore
#line 54 "/Users/ishajain/Desktop/Xero-NetStandard-Application/XeroNetStandardApp/Views/ContactsInfo/Create.cshtml"
WriteAttributeValue("", 2157, Url.Action("Index", "Home"), 2157, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2185, "\'", 2185, 1, true);
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
