#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9734ffb2d1ac951daf23009ff8a31c45b9252372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_Nema), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/Nema.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/Nema.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_Nema))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9734ffb2d1ac951daf23009ff8a31c45b9252372", @"/Views/AmlakSettingManagment/Nema.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_Nema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.AmlakNema>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
  
    ViewData["Title"] = "انواع نما";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33890d776d6d48e9982a60aa8327f584", async() => {
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
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(194, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb797106958142279e9ba0ffd461e785", async() => {
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
            BeginContext(294, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(296, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c6185a38fe4ca2b99f23028b2467ff", async() => {
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
            BeginContext(345, 1513, true);
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
    میتوانید در این قسمت تنظیمات ملک مربوط به انواع نما مانند چوب و کلاسیک و .. را ببینید
    برای افزودن با توسعه دهنده خود در تماس باشید
</div>

<p style=""margin-right:50px;"">
    <a href=""/AmlakSettingManagment/Create?settingtype=9&name=تنظیمات نما"" class=""btn btn-default"">افزودن تنظیمات جدید</a>
</p>

<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""backgro");
            WriteLiteral(@"und-color:white;"">
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
#line 53 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                      
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
            BeginContext(4981, 136, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5118, 9, false);
#line 114 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5127, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5225, 1, false);
#line 115 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                                                     Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5226, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5324, 4, false);
#line 116 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                                                     Write(melk);

#line default
#line hidden
            EndContext();
            BeginContext(5328, 99, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">\r\n");
            EndContext();
#line 118 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                  
                                                    if (item.ShowinSearch == true)
                                                    {

#line default
#line hidden
            BeginContext(5618, 96, true);
            WriteLiteral("                                                        <input type=\"checkbox\" checked=\"checked\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 5714, "\"", 5747, 3);
            WriteAttributeValue("", 5725, "Showinsearch(", 5725, 13, true);
#line 121 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
WriteAttributeValue("", 5738, item.Id, 5738, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5746, ")", 5746, 1, true);
            EndWriteAttribute();
            BeginContext(5748, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 122 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(5921, 78, true);
            WriteLiteral("                                                        <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("onchange", " onchange=\"", 5999, "\"", 6032, 3);
            WriteAttributeValue("", 6010, "Showinsearch(", 6010, 13, true);
#line 125 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
WriteAttributeValue("", 6023, item.Id, 6023, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6031, ")", 6031, 1, true);
            EndWriteAttribute();
            BeginContext(6033, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 126 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                                                    }
                                                

#line default
#line hidden
            BeginContext(6144, 233, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6377, "\"", 6407, 3);
            WriteAttributeValue("", 6387, "deleteitem(", 6387, 11, true);
#line 130 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
WriteAttributeValue("", 6398, item.Id, 6398, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6406, ")", 6406, 1, true);
            EndWriteAttribute();
            BeginContext(6408, 96, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 132 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Nema.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(6589, 1386, true);
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
            data: { deleteditem: deleteid, Id: 9 },
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
            data: { statusid: statusid , Id:9},
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.AmlakNema>> Html { get; private set; }
    }
}
#pragma warning restore 1591
