#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742f5b9b94f13de5b436889894f10db4111ea073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_NoeZamin), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/NoeZamin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/NoeZamin.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_NoeZamin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742f5b9b94f13de5b436889894f10db4111ea073", @"/Views/AmlakSettingManagment/NoeZamin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_NoeZamin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.AmlakNoeZamin>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
  
    ViewData["Title"] = "انواع زمین";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f58939a3571e47ab87c22b466f46ede4", async() => {
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
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "327a630b5313491fb5757e498ed86b2d", async() => {
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
            BeginContext(299, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(301, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098b7a6e3fa543e685b21fd2c8c77660", async() => {
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
            BeginContext(350, 1451, true);
            WriteLiteral(@"

<style>
    tr:nth-child(even) {
        background: rgba(126, 136, 241, 0.59)
    }
</style>


<section class=""content-header"">
    <h1>
        داشبرد
        <small>کنترل پنل</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/Managment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت تنظیمات ملک </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت تنظیمات ملک</h4>
    میتوانید در این قسمت تنظیمات ملک مربوط به انواع زمین مانند بغ و مسکونی و .. را ببینید
    برای افزودن با توسعه دهنده خود در تماس باشید
</div>

<p style=""margin-right:50px;"">
    <a href=""/AmlakSettingManagment/Create?settingtype=10&name=تنظیمات نوع زمین"" class=""btn btn-default"">افزودن تنظیمات جدید</a>
</p>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""");
            WriteLiteral(@"background-color:white;"">
                <thead>
                    <tr>
                        <th class=""text-center"">نام</th>
                        <th class=""text-center"">خرید / اجاره / ساخت</th>
                        <th class=""text-center"">نوع ملک</th>
                        <th class=""text-center"">حذف</th>
                    </tr>
                </thead>
                <tbody id=""listofarticle"">
");
            EndContext();
#line 53 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
                      
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
            BeginContext(4924, 136, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5061, 9, false);
#line 114 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5070, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5168, 1, false);
#line 115 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
                                                                                     Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5169, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5267, 4, false);
#line 116 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
                                                                                     Write(melk);

#line default
#line hidden
            EndContext();
            BeginContext(5271, 187, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5458, "\"", 5488, 3);
            WriteAttributeValue("", 5468, "deleteitem(", 5468, 11, true);
#line 117 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
WriteAttributeValue("", 5479, item.Id, 5479, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5487, ")", 5487, 1, true);
            EndWriteAttribute();
            BeginContext(5489, 96, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 119 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\NoeZamin.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(5670, 1078, true);
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
            data: { deleteditem: deleteid, Id: 10 },
            success: function (data) {
                window.location.rel");
            WriteLiteral("oad();\r\n            }\r\n        });\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.AmlakNoeZamin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
