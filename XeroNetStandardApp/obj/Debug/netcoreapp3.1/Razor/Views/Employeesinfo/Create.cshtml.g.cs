#pragma checksum "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/Employeesinfo/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2765a7836df1ba7763c50125698a8706a5b5a78b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employeesinfo_Create), @"mvc.1.0.view", @"/Views/Employeesinfo/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2765a7836df1ba7763c50125698a8706a5b5a78b", @"/Views/Employeesinfo/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e112d52b0ceede218d179a09bb11923aba4eed8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employeesinfo_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<h2>Create a Xero Payroll Employee</h2>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2765a7836df1ba7763c50125698a8706a5b5a78b3651", async() => {
                WriteLiteral("\n    <label for=\"firstName\">First Name:</label>\n    <br>\n    <input type=\"text\" id=\"firstName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 155, "\"", 169, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"firstName\"/>\n    <br>\n    <label for=\"lastName\">Last Name:</label>\n    <br>\n    <input type=\"text\" id=\"lastName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 289, "\"", 303, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"lastName\" />\n    <br>\n    <br>\n    <input type=\"submit\" />\n");
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
            BeginWriteAttribute("onclick", " onclick=\"", 397, "\"", 451, 3);
            WriteAttributeValue("", 407, "location.href=\'", 407, 15, true);
#nullable restore
#line 18 "/Users/ishajain/Desktop/xero-netstandard-oauth2-starter-dotnet-core/XeroNetStandardApp/Views/Employeesinfo/Create.cshtml"
WriteAttributeValue("", 422, Url.Action("Index", "Home"), 422, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 450, "\'", 450, 1, true);
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