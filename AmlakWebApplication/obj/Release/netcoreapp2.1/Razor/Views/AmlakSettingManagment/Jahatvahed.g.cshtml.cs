#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c0c1246fd7345a01dc13e43c284f82ad9d61943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_Jahatvahed), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/Jahatvahed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/Jahatvahed.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_Jahatvahed))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c0c1246fd7345a01dc13e43c284f82ad9d61943", @"/Views/AmlakSettingManagment/Jahatvahed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_Jahatvahed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.AmlakJahatVahed>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/alert/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/alert/sweetalert.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
  
    ViewData["Title"] = "انواع جهت واحد ها";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(147, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "375b5c8cac474bcc878cc1e26fd4769d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(208, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "137886198f67479cad9cdd5d915053a6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(310, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a32cbf2c52654e6483cb17cafc93e2b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 1529, true);
            WriteLiteral(@"

<style>
    tr:nth-child(even) {
        background: rgba(126, 136, 241, 0.59)
    }
</style>


<section class=""content-header"">
    <h1>
        داشبورد
        <small>کنترل پنل</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/Managment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت تنظیمات ملک </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت تنظیمات ملک</h4>
    میتوانید در این قسمت تنظیمات ملک مربوط به انواع جهت واحد ها مانند شمالی و جنوبی و .. را ببینید
    برای افزودن با توسعه دهنده خود در تماس باشید
</div>

<p style=""margin-right:50px;"">
    <a href=""/AmlakSettingManagment/Create?settingtype=3&name=تنظیمات جهت واحد"" class=""btn btn-default"">افزودن تنظیمات جدید</a>
</p>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover");
            WriteLiteral(@""" style=""background-color:white;"">
                <thead>
                    <tr>
                        <th class=""text-center"">نام</th>
                        <th class=""text-center"">خرید / اجاره / ساخت</th>
                        <th class=""text-center"">نوع ملک</th>
                        <th class=""text-center"">نمایش در جستجو</th>
                        <th class=""text-center"">حذف</th>
                    </tr>
                </thead>
                <tbody id=""listofarticle"">
");
            EndContext();
#line 54 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                      
                        if (Model.Count() > 0)
                        {
                            foreach (var item in Model)
                            {
                                String s = "ندارد";
                                if (item.TypeHome == DomainLayer.Enums.TypeHome.Rent)
                                {
                                    s = "اجاره";
                                }
                                else if (item.TypeHome == DomainLayer.Enums.TypeHome.build)
                                {
                                    s = "ساخت";
                                }
                                else if (item.TypeHome == DomainLayer.Enums.TypeHome.Buy)
                                {
                                    s = "خرید";
                                }

                                String melk = "ندارد";
                                if (item.MelkType == DomainLayer.Enums.MelkType.Anbar)
                                {
                                    melk = "انبار";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Aparteman)
                                {
                                    melk = "آپارتمان";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Edari)
                                {
                                    melk = "اداری";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Garden)
                                {
                                    melk = "باغ و باغچه";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.HomeWithGarden)
                                {
                                    melk = "خانه حیاط دار";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Kolangi)
                                {
                                    melk = "کلنگی";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Maghaze)
                                {
                                    melk = "مغازه";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Mostaghelat)
                                {
                                    melk = "مستقلات";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Villa)
                                {
                                    melk = "ویلا";
                                }
                                else if (item.MelkType == DomainLayer.Enums.MelkType.Zamin)
                                {
                                    melk = "زمین";
                                }

#line default
#line hidden
            BeginContext(5011, 136, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5148, 9, false);
#line 115 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5157, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5255, 1, false);
#line 116 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                                                     Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5256, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5354, 4, false);
#line 117 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                                                     Write(melk);

#line default
#line hidden
            EndContext();
            BeginContext(5358, 99, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">\r\n");
            EndContext();
#line 119 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                  
                                                    if (item.ShowinSearch == true)
                                                    {

#line default
#line hidden
            BeginContext(5648, 96, true);
            WriteLiteral("                                                        <input type=\"checkbox\" checked=\"checked\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 5744, "\"", 5777, 3);
            WriteAttributeValue("", 5755, "Showinsearch(", 5755, 13, true);
#line 122 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
WriteAttributeValue("", 5768, item.Id, 5768, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5776, ")", 5776, 1, true);
            EndWriteAttribute();
            BeginContext(5778, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 123 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(5951, 78, true);
            WriteLiteral("                                                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 6029, "\"", 6062, 3);
            WriteAttributeValue("", 6040, "Showinsearch(", 6040, 13, true);
#line 126 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
WriteAttributeValue("", 6053, item.Id, 6053, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6061, ")", 6061, 1, true);
            EndWriteAttribute();
            BeginContext(6063, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 127 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6174, 233, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6407, "\"", 6437, 3);
            WriteAttributeValue("", 6417, "deleteitem(", 6417, 11, true);
#line 131 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
WriteAttributeValue("", 6428, item.Id, 6428, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6436, ")", 6436, 1, true);
            EndWriteAttribute();
            BeginContext(6438, 96, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 133 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Jahatvahed.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(6619, 1386, true);
            WriteLiteral(@"                </tbody>

            </table>

        </div>

    </div>
</div>


<script>


    function deleteitem(id) {
        swal({
            title: ""آیا میخواهید حذف شود؟"",
            text: """",
            type: ""warning"",
            showCancelButton: true,
            confirmButtonClass: ""btn-danger"",
            confirmButtonText: ""بله حذف شود"",
            cancelButtonText: ""خیر"",
            closeOnConfirm: false,
            closeOnCancel: false
        },
            function (isConfirm) {
                if (isConfirm) {
                    sendtoservertodelete(id);

                } else {
                    swal(""صرف نظر"", ""حذف نشد"", ""error"");
                }
            });
    }

    function sendtoservertodelete(deleteid) {
        $.ajax({
            type: ""Post"",
            url: '/AmlakSettingManagment/Delete',
            data: { deleteditem: deleteid, Id: 3 },
            success: function (data) {
                window.location.relo");
            WriteLiteral(@"ad();
            }
        });
    }

    function Showinsearch(statusid) {
         $.ajax({
            type: ""Post"",
            url: '/AmlakSettingManagment/SearchStatus',
            data: { statusid: statusid , Id:3},
            success: function (data) {
                window.location.reload();
            }
        });
    }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.AmlakJahatVahed>> Html { get; private set; }
    }
}
#pragma warning restore 1591
