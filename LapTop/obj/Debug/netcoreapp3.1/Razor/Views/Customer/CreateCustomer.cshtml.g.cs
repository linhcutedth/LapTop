#pragma checksum "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52ea6b15ed1577966b21263f84c2c145d89d2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CreateCustomer), @"mvc.1.0.view", @"/Views/Customer/CreateCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52ea6b15ed1577966b21263f84c2c145d89d2f4", @"/Views/Customer/CreateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a53b268c9cb016cea4365a2cfa183cf5e714c88", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CreateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LapTop.Models.Customer>
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
#line 3 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
  
    ViewData["Title"] = "CreateCustomer";
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n<h4>Customer</h4>\r\n<hr />\r\n\r\n");
#nullable restore
#line 13 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
 using (Html.BeginForm("CreateCustomer", "Customer", new { style = "border:1px solid black;" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div> <p style=\"width: 200px; \">Mã khách hàng </p> ");
#nullable restore
#line 15 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                                  Write(Html.TextBoxFor(kh => kh.MaKH));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <p style=\"width: 200px; \">Tên đăng nhập</p> ");
#nullable restore
#line 17 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                                 Write(Html.TextBoxFor(kh => kh.TenDN));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <p style=\"width: 200px; \">Tên khách hàng</p> ");
#nullable restore
#line 19 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                                  Write(Html.TextBoxFor(kh => kh.TenKH));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <p style=\"width: 200px; \">Số điện thoại</p> ");
#nullable restore
#line 21 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                                 Write(Html.TextBoxFor(kh => kh.SoDT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <p style=\"width: 200px; \">Email</p> ");
#nullable restore
#line 23 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                         Write(Html.TextBoxFor(kh => kh.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <p style=\"width: 200px; \">Giới tính</p> ");
#nullable restore
#line 25 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
                                             Write(Html.TextBoxFor(kh => kh.GTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n    <br>\r\n    <div> <input type=\"submit\" value=\"Add Customer\" /></div>\r\n");
#nullable restore
#line 28 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f52ea6b15ed1577966b21263f84c2c145d89d2f46447", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\UIT\Nam3\FrameWork\Demoo\LapTop\LapTop\Views\Customer\CreateCustomer.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
