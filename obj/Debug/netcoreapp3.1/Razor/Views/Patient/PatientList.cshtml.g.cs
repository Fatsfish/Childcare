#pragma checksum "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a783490286702d4156e188f4e0f03a5c87f267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientList), @"mvc.1.0.view", @"/Views/Patient/PatientList.cshtml")]
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
#line 1 "D:\Study_material\C#\ChildCareProject\Childcare\Views\_ViewImports.cshtml"
using Childcare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study_material\C#\ChildCareProject\Childcare\Views\_ViewImports.cshtml"
using Childcare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a783490286702d4156e188f4e0f03a5c87f267", @"/Views/Patient/PatientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e32bb57870fb2d1b8b1f242a4e348efc280250", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Childcare.Models.PatientListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
  
    ViewData["title"] = "Patients";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 6 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div class=\"navbar-collapse collapse d-sm-inline-flex justify-content-between\">\r\n    <ul class=\"navbar-nav flex-grow-1\">\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3a783490286702d4156e188f4e0f03a5c87f2676184", async() => {
                WriteLiteral("Create\r\n                Patient");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n</div>\r\n");
#nullable restore
#line 14 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
 if (Model.Patients.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>There\'s no patient</div>\r\n");
#nullable restore
#line 17 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
}
else
{
    foreach (var p in Model.Patients)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">\r\n                ");
#nullable restore
#line 24 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
           Write(p.PatientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
#nullable restore
#line 25 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                 if(User.IsInRole("Staff") || User.IsInRole("Manager"))
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
               Write(p.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-body text-dark\">\r\n                <div class=\"card-text\">pOwnerId: ");
#nullable restore
#line 29 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                                            Write(p.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-text\">pId: ");
#nullable restore
#line 30 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                                       Write(p.PatientID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-text\">");
#nullable restore
#line 31 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                                  Write(p.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"card-text\">");
#nullable restore
#line 32 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                                  Write(p.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3a783490286702d4156e188f4e0f03a5c87f26710570", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1246, "\"", 1266, 1);
#nullable restore
#line 34 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 1254, p.PatientID, 1254, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"patientId\">\r\n                    <button type=\"submit\">Detail</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3a783490286702d4156e188f4e0f03a5c87f26712969", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 41 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
         foreach (var p in Model.Patients)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"checkbox\" name=\"patientIds\"");
                BeginWriteAttribute("id", " id=\"", 1560, "\"", 1577, 1);
#nullable restore
#line 43 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 1565, p.PatientID, 1565, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1578, "\"", 1598, 1);
#nullable restore
#line 43 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 1586, p.PatientID, 1586, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 1621, "\"", 1639, 1);
#nullable restore
#line 44 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
WriteAttributeValue("", 1627, p.PatientID, 1627, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 44 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
                                  Write(p.PatientID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 45 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\" value=\"submit\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\Study_material\C#\ChildCareProject\Childcare\Views\Patient\PatientList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Childcare.Models.PatientListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591