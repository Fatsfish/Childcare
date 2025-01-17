#pragma checksum "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568a495bdbecf44aa16051d7cb8c956d2583669c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
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
#line 1 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\_ViewImports.cshtml"
using Childcare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\_ViewImports.cshtml"
using Childcare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"568a495bdbecf44aa16051d7cb8c956d2583669c", @"/Views/User/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e32bb57870fb2d1b8b1f242a4e348efc280250", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Childcare.Models.UserListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignStaffRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AssignSpecialtyToStaff"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveStaffRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
  
    ViewData["title"] = "Childcare user";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 6 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 7 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
 if (Model.Customers.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>There\'s no customer</div>\r\n");
#nullable restore
#line 10 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Customer List:</h3>\r\n");
#nullable restore
#line 14 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
    foreach (var c in Model.Customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">\r\n                UserId: ");
#nullable restore
#line 18 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                   Write(c.ChildcareUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Customer email: ");
#nullable restore
#line 19 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                           Write(c.ChildCareUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                CustomerId: ");
#nullable restore
#line 20 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                       Write(c.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body text-dark\">\r\n                <div class=\"card-text\">Full name: ");
#nullable restore
#line 23 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                                             Write(c.ChildCareUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-text\">PhoneNum: ");
#nullable restore
#line 24 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                                            Write(c.ChildCareUser.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568a495bdbecf44aa16051d7cb8c956d2583669c8290", async() => {
                WriteLiteral("\r\n    <label id=\"userId\">Choose userId to assign staff role</label>\r\n    <input type=\"text\" name=\"userId\" id=\"userId\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568a495bdbecf44aa16051d7cb8c956d2583669c8682", async() => {
                    WriteLiteral("Assign Staff Role");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 36 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
 if (Model.Staffs.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>There\'s no staff</div>\r\n");
#nullable restore
#line 39 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Staff List:</h3>\r\n");
#nullable restore
#line 43 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
    foreach (var s in Model.Staffs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">\r\n                UserId: ");
#nullable restore
#line 47 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                   Write(s.ChildcareUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Staff email: ");
#nullable restore
#line 48 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                        Write(s.ChildCareUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Staff Id: ");
#nullable restore
#line 49 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                     Write(s.StaffID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body text-dark\">\r\n                <div class=\"card-text\">Full name: ");
#nullable restore
#line 52 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                                             Write(s.ChildCareUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-text\">PhoneNum: ");
#nullable restore
#line 53 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
                                            Write(s.ChildCareUser.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568a495bdbecf44aa16051d7cb8c956d2583669c13753", async() => {
                WriteLiteral("\r\n                    Spec Id: <input type=\"text\" name=\"specialtyId\"");
                BeginWriteAttribute("value", " value=\"", 1834, "\"", 1856, 1);
#nullable restore
#line 55 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
WriteAttributeValue("", 1842, s.SpecialtyID, 1842, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"staffId\"");
                BeginWriteAttribute("value", " value=\"", 1915, "\"", 1933, 1);
#nullable restore
#line 56 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
WriteAttributeValue("", 1923, s.StaffID, 1923, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button type=\"submit\">Change spec</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "D:\FPTU\2021 S2 Summer\PRN211\Lab\Childcare\Views\User\UserList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568a495bdbecf44aa16051d7cb8c956d2583669c16488", async() => {
                WriteLiteral("\r\n    <label id=\"userId\">Choose userId to remove staff role</label>\r\n    <input type=\"text\" name=\"userId\" id=\"userId\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568a495bdbecf44aa16051d7cb8c956d2583669c16881", async() => {
                    WriteLiteral("Remove Staff Role");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Childcare.Models.UserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
