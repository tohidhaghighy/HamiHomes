#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e76acac3559ecd096f77d16cec669d4db5a42c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AmlakSettingManagment_Kaf), @"mvc.1.0.view", @"/Views/AmlakSettingManagment/Kaf.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AmlakSettingManagment/Kaf.cshtml", typeof(AspNetCore.Views_AmlakSettingManagment_Kaf))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e76acac3559ecd096f77d16cec669d4db5a42c0", @"/Views/AmlakSettingManagment/Kaf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AmlakSettingManagment_Kaf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.AmlakKaf>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
  
    ViewData["Title"] = "انواع کف";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(131, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce035dff079f41929e70f6ab77e025d2", async() => {
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
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(192, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d156fc30d4be403f80773537f857f69f", async() => {
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
            BeginContext(292, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(294, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e3979a89af44fd5afe726c08b48fd54", async() => {
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
            BeginContext(343, 1371, true);
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
    <h4>مدریت تنظیمات پوشش کف</h4>
    میتوانید در این قسمت تنظیمات پوشش کف را ببینید
    
</div>

<p style=""margin-right:50px;"">
    <a href=""/AmlakSettingManagment/Create?settingtype=18&name=تنظیمات پوشش کف"" class=""btn btn-default"">افزودن تنظیمات جدید</a>
</p>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""background-color:white;"">
                <thead>
                    <tr>
  ");
            WriteLiteral(@"                      <th class=""text-center"">نام</th>
                        <th class=""text-center"">خرید / اجاره / ساخت</th>
                        <th class=""text-center"">نوع ملک</th>
                        <th class=""text-center"">حذف</th>
                    </tr>
                </thead>
                <tbody id=""listofarticle"">
");
            EndContext();
#line 53 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
                      
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
            BeginContext(4837, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(4958, 9, false);
#line 114 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4967, 89, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5057, 1, false);
#line 115 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
                                                                             Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(5058, 89, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(5148, 4, false);
#line 116 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
                                                                             Write(melk);

#line default
#line hidden
            EndContext();
            BeginContext(5152, 179, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5331, "\"", 5361, 3);
            WriteAttributeValue("", 5341, "deleteitem(", 5341, 11, true);
#line 117 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
WriteAttributeValue("", 5352, item.Id, 5352, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 5360, ")", 5360, 1, true);
            EndWriteAttribute();
            BeginContext(5362, 88, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                </tr>\r\n");
            EndContext();
#line 119 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AmlakSettingManagment\Kaf.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(5535, 1078, true);
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
            data: { deleteditem: deleteid, Id: 18 },
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.AmlakKaf>> Html { get; private set; }
    }
}
#pragma warning restore 1591
