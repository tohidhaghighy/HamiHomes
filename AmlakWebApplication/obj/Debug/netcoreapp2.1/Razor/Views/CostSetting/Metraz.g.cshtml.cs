#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "508c75a4264651a679a9495c53a2557d48287987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CostSetting_Metraz), @"mvc.1.0.view", @"/Views/CostSetting/Metraz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CostSetting/Metraz.cshtml", typeof(AspNetCore.Views_CostSetting_Metraz))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"508c75a4264651a679a9495c53a2557d48287987", @"/Views/CostSetting/Metraz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_CostSetting_Metraz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.MetrazSetting>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
  
    ViewData["Title"] = "Metraz";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(134, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aeea5167e2be4da390791170bf53313f", async() => {
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
            BeginContext(193, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(195, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d2f6bf959084c6999609ca269e8117b", async() => {
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
            BeginContext(295, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(297, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6fb94afe9994e19a7f46eb2a9b36191", async() => {
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
            BeginContext(346, 1261, true);
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
        <li><a href=""/CostSetting/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت متراژ ها</li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت متراژ ها</h4>
</div>



<p style=""margin-right:50px;"">
    <a href=""/CostSetting/CreateMetraz"" class=""btn btn-default"">افزودن متراژ جدید</a>
</p>

<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""background-color:white;"">
                <thead>
                    <tr>
                        <th class=""text-center"">متراژ نمایشی</th>
                        <th class=""text-ce");
            WriteLiteral("nter\">متراژ</th>\r\n                        <th class=\"text-center\">نوع متراژ</th>\r\n                        <th class=\"text-center\">حذف</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"listofarticle\">\r\n");
            EndContext();
#line 52 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                      
                        if (Model.Count() > 0)
                        {
                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1794, 136, true);
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(1931, 11, false);
#line 58 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                                                                                     Write(item.Metraz);

#line default
#line hidden
            EndContext();
            BeginContext(1942, 97, true);
            WriteLiteral("</td>\r\n                                            <td class=\"text-center\" style=\"padding:10px;\">");
            EndContext();
            BeginContext(2040, 17, false);
#line 59 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                                                                                     Write(item.MetrazChance);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                                              
                                                if (item.TypeMetraz == 1)
                                                {

#line default
#line hidden
            BeginContext(2238, 114, true);
            WriteLiteral("                                                    <td class=\"text-center\" style=\"padding:10px;\">متراژ بنا</td>\r\n");
            EndContext();
#line 64 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(2508, 115, true);
            WriteLiteral("                                                    <td class=\"text-center\" style=\"padding:10px;\">متراژ زمین</td>\r\n");
            EndContext();
#line 68 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                                                }
                                            

#line default
#line hidden
            BeginContext(2721, 180, true);
            WriteLiteral("                                            <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2901, "\"", 2931, 3);
            WriteAttributeValue("", 2911, "deleteitem(", 2911, 11, true);
#line 70 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
WriteAttributeValue("", 2922, item.Id, 2922, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2930, ")", 2930, 1, true);
            EndWriteAttribute();
            BeginContext(2932, 96, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n                                        </tr>\r\n");
            EndContext();
#line 72 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CostSetting\Metraz.cshtml"
                            }

                        }

                    

#line default
#line hidden
            BeginContext(3113, 1171, true);
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

        function sendtoservertodelete(id) {
            $.ajax({
                type: ""Post"",
                url: '/CostSetting/DeleteMetraz',
                data: { id: id },
          ");
            WriteLiteral("      success: function (data) {\r\n                    window.location.reload();\r\n                }\r\n            });\r\n        }\r\n\r\n</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.MetrazSetting>> Html { get; private set; }
    }
}
#pragma warning restore 1591