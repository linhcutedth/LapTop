#pragma checksum "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59ee3677b9ceb36865999b7fdcb914e109c1aab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Edit), @"mvc.1.0.view", @"/Views/Customer/Edit.cshtml")]
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
#line 1 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59ee3677b9ceb36865999b7fdcb914e109c1aab", @"/Views/Customer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a53b268c9cb016cea4365a2cfa183cf5e714c88", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LapTop.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    var customer = ViewData["Customer"] as Customer;
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap""
      rel=""stylesheet"">
<!-- Card Body -->
<div class=""card-body"">

    <h1 style=""text-align: center; color: coral;"">C???p nh???t th??ng tin</h1>
    <hr />

");
#nullable restore
#line 18 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
     using (Html.BeginForm("Edit", "Customer", new { style = "border:1px solid red; " }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\" , style=\"text-align:center;\">\r\n            <tr>\r\n                <td> <b> M?? kh??ch h??ng</b></td>\r\n                <td><input type=\"text\" id=\"maKH\" name=\"maKH\"");
            BeginWriteAttribute("value", " value=\"", 739, "\"", 761, 1);
#nullable restore
#line 23 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 747, customer.MaKH, 747, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n            <tr>\r\n                <td> <b>T??n ????ng nh???p</b></td>\r\n                <td><input type=\"text\" id=\"tenDN\" name=\"tenDN\"");
            BeginWriteAttribute("value", " value=\"", 937, "\"", 960, 1);
#nullable restore
#line 27 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 945, customer.TenDN, 945, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n            <tr>\r\n                <td> <b>T??n kh??ch h??ng</b> </td>\r\n                <td>  <input type=\"text\" id=\"tenKH\" name=\"tenKH\"");
            BeginWriteAttribute("value", " value=\"", 1140, "\"", 1163, 1);
#nullable restore
#line 31 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 1148, customer.TenKH, 1148, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n            <tr>\r\n                <td> <b>S??? ??i???n tho???i</b></td>\r\n                <td>  <input type=\"text\" id=\"soDT\" name=\"soDT\"");
            BeginWriteAttribute("value", " value=\"", 1339, "\"", 1361, 1);
#nullable restore
#line 35 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 1347, customer.SoDT, 1347, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n            <tr>\r\n                <td> <b>Email</b></td>\r\n                <td> <input type=\"text\" id=\"email\" name=\"email\"");
            BeginWriteAttribute("value", " value=\"", 1530, "\"", 1553, 1);
#nullable restore
#line 39 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 1538, customer.Email, 1538, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n            <tr>\r\n                <td> <b>Gi???i t??nh</b></td>\r\n                <td> <input type=\"text\" id=\"gTinh\" name=\"gTinh\"");
            BeginWriteAttribute("value", " value=\"", 1726, "\"", 1749, 1);
#nullable restore
#line 43 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
WriteAttributeValue("", 1734, customer.GTinh, 1734, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n            </tr>\r\n        </table>\r\n        <br />\r\n        <div style=\"text-align: center\"> <input type=\"submit\" value=\"C???p nh???t\" /></div>\r\n");
#nullable restore
#line 48 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b59ee3677b9ceb36865999b7fdcb914e109c1aab7949", async() => {
                WriteLiteral("Tr??? v???");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 71 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\Edit.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LapTop.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
