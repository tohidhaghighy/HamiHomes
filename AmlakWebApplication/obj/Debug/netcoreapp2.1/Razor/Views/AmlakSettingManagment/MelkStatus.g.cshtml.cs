#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc51bf1eb2c23b4a92c8de69a3db66e3143d897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_MelkStatus), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/MelkStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/MelkStatus.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_MelkStatus))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc51bf1eb2c23b4a92c8de69a3db66e3143d897", @"/Views/AmlakSettingManagment/MelkStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_MelkStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.AmlakMelkStatus>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
  
    ViewData["Title"] = "انواع وضعیت ملک";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f26a5f120e90451eb4195002db56fe2b", async() => {
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
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df7f137e4fee424ab8830d05ed666fc3", async() => {
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
            BeginContext(306, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(308, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c1b9132a8e4f5c9dd1561221b810bd", async() => {
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
            BeginContext(357, 1532, true);
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
    میتوانید در این قسمت تنظیمات ملک مربوط به انواع وضعیت ملک مانند سرقفلی و قراردادی و .. را ببینید
    برای افزودن با توسعه دهنده خود در تماس باشید
</div>

<p style=""margin-right:50px;"">
    <a href=""/AmlakSettingManagment/Create?settingtype=5&name=تنظیمات وضعیت ملک"" class=""btn btn-default"">افزودن تنظیمات جدید</a>
</p>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-ho");
            WriteLiteral(@"ver"" style=""background-color:white;"">
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
#line 54 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                      
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
            BeginContext(5012, 136, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5149, 9, false);
#line 115 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5158, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5256, 1, false);
#line 116 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                                                     Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5257, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5355, 4, false);
#line 117 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                                                     Write(melk);

#line default
#line hidden
            EndContext();
            BeginContext(5359, 99, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">\r\n");
            EndContext();
#line 119 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                  
                                                    if (item.ShowinSearch == true)
                                                    {

#line default
#line hidden
            BeginContext(5649, 96, true);
            WriteLiteral("                                                        <input type=\"checkbox\" checked=\"checked\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 5745, "\"", 5778, 3);
            WriteAttributeValue("", 5756, "Showinsearch(", 5756, 13, true);
#line 122 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
WriteAttributeValue("", 5769, item.Id, 5769, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5777, ")", 5777, 1, true);
            EndWriteAttribute();
            BeginContext(5779, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 123 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(5952, 78, true);
            WriteLiteral("                                                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 6030, "\"", 6063, 3);
            WriteAttributeValue("", 6041, "Showinsearch(", 6041, 13, true);
#line 126 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
WriteAttributeValue("", 6054, item.Id, 6054, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6062, ")", 6062, 1, true);
            EndWriteAttribute();
            BeginContext(6064, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 127 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6175, 233, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6408, "\"", 6438, 3);
            WriteAttributeValue("", 6418, "deleteitem(", 6418, 11, true);
#line 131 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
WriteAttributeValue("", 6429, item.Id, 6429, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6437, ")", 6437, 1, true);
            EndWriteAttribute();
            BeginContext(6439, 96, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 133 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\MelkStatus.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(6620, 1386, true);
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
            data: { deleteditem: deleteid, Id: 5 },
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
            data: { statusid: statusid , Id:5},
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.AmlakMelkStatus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
