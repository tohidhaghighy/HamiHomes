#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc82ad682603a83eff4e6b7f794ae72197f8228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_Create), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/Create.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_Create))]
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
#line 1 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using AmlakWebApplication;

#line default
#line hidden
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using AmlakWebApplication.Models;

#line default
#line hidden
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using ViewModelLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc82ad682603a83eff4e6b7f794ae72197f8228", @"/Views/AmlakSettingManagment/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelLayer.Common.KeyValueList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(137, 372, true);
            WriteLiteral(@"


<section class=""content-header"">
    <h1>
        داشبورد
        <small>کنترل پنل</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/Managment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">تنظیمات جدید </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>درج ");
            EndContext();
            BeginContext(510, 16, false);
#line 22 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
       Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(526, 194, true);
            WriteLiteral(" جدید</h4>\r\n\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"box box-danger\">\r\n        <div class=\"box-header\">\r\n            <h3 class=\"box-title\">تنظیمات جدید</h3>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(720, 1909, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2fc827db8f4464d8765d7d8d0175c07", async() => {
                BeginContext(750, 54, true);
                WriteLiteral("\r\n            <div class=\"box-body\">\r\n                ");
                EndContext();
                BeginContext(804, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1627c845d8f4220a68ef4f1a3e0549d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 33 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(874, 80, true);
                WriteLiteral("\r\n\r\n                <input name=\"Id\" id=\"Id\" type=\"number\" style=\"display:none;\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 954, "\"", 986, 1);
#line 35 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
WriteAttributeValue("", 962, ViewData["Settingtype"], 962, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(987, 180, true);
                WriteLiteral(">\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    <label> نوع ملک </label>\r\n                    <select name=\"MelkTypeId\" id=\"MelkTypeId\" class=\"form-control\">\r\n");
                EndContext();
#line 41 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                          
                            foreach (var item in Model.MelkTypes)
                            {

#line default
#line hidden
                BeginContext(1293, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1325, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6521ff529ef0414b809cfdac47861d4a", async() => {
                    BeginContext(1351, 9, false);
#line 44 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 44 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1369, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1429, 232, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label> نوع قرارداد </label>\r\n                    <select name=\"HomeTypeId\" id=\"HomeTypeId\" class=\"form-control\">\r\n");
                EndContext();
#line 52 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                          
                            foreach (var item in Model.Hometypes)
                            {

#line default
#line hidden
                BeginContext(1787, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1819, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fc7eea16fc441d6a1a36ff7609dc765", async() => {
                    BeginContext(1845, 9, false);
#line 55 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 55 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1863, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(1923, 699, true);
                WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <label>نام</label>
                    <input name=""name"" id=""name"" type=""text"" class=""form-control"" placeholder=""نام"">
                </div>

                <div class=""form-group"">
                    <label>نمایش در جستجو ؟</label>
                    <input name=""status"" id=""status"" type=""checkbox"" placeholder=""نمایش در جستجو ؟"" style=""padding:10px;"">
                </div>

                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-success"">درج تنظیمات جدید</button>
                </div>

            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2629, 97, true);
            WriteLiteral("\r\n        <!-- /.box-body -->\r\n    </div>\r\n    <!-- /.box -->\r\n    <!-- /.box -->\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2744, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 85 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelLayer.Common.KeyValueList> Html { get; private set; }
    }
}
#pragma warning restore 1591
