#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeVilaManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52436d13d9fe58e2f18e241808c3b4be88655dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeVilaManagment_Index), @"mvc.1.0.view", @"/Views/HomeVilaManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeVilaManagment/Index.cshtml", typeof(AspNetCore.Views_HomeVilaManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52436d13d9fe58e2f18e241808c3b4be88655dca", @"/Views/HomeVilaManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeVilaManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Home.Vila>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeVilaManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(127, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(131, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6fecd72a9a8401bb16b496408b4adbe", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c0f7869d7f21497dab15ba2f0772d926", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e71130f5e48949658bb7b2fe8af654a7", async() => {
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
            BeginContext(343, 829, true);
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
        <li><a href=""/HomeVillaManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت ویلا  </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت ویلا </h4>
    در اینجا میتوانید لیست ویلا های درج شده را ببینید و اطلاعات ان را ویرایش و یا حذف کنید

</div>

<div class=""row"">
    <div class=""container"">
        <div class=""col-lg-2 col-xs-4"">
            <!-- small box -->
            <div class=""small-box bg-primary"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1173, 47, false);
#line 42 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeVilaManagment\Index.cshtml"
                   Write(Model.Where(a => a.Home.IsShow == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1220, 467, true);
            WriteLiteral(@"<sup style=""font-size: 20px""></sup></h3>

                    <p>تایید شده ها</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-stats-bars""></i>
                </div>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-2 col-xs-4"">
            <!-- small box -->
            <div class=""small-box bg-primary"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1688, 48, false);
#line 56 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeVilaManagment\Index.cshtml"
                   Write(Model.Where(a => a.Home.IsShow == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1736, 1262, true);
            WriteLiteral(@"<sup style=""font-size: 20px""></sup></h3>

                    <p>تعداد جدید ها</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-stats-bars""></i>
                </div>
            </div>
        </div>
    </div>
</div>

<p style=""margin-right:50px;"">
    <a href=""/HomeManagment/Create"" class=""btn btn-default"">افزودن ویلا جدید</a>
</p>

<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""background-color:white;"">
                <thead>
                    <tr>
                        <th class=""text-center"">تایید شده ؟</th>
                        <th class=""text-center"">متراژ بنا</th>
                        <th class=""text-center"">متراژ زمین</th>
                        <th class=""text-center"">تعداد کل طبقات  </th>
                        <th class=""text-center"">نام نگهبانی</th>
     ");
            WriteLiteral("                   <th class=\"text-center\">شماره نگهبانی</th>\r\n                        <th class=\"text-center\">حذف</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"listofarticle\">\r\n                    ");
            EndContext();
            BeginContext(2999, 43, false);
#line 88 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeVilaManagment\Index.cshtml"
               Write(await Html.PartialAsync("_ListAjax", Model));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 1497, true);
            WriteLiteral(@"
                </tbody>

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
            url: '/HomeVilaManagment/Delete',
            data: { id: id },
            success: function (data) {
                window.location.reload();
            }
        })");
            WriteLiteral(@";
    }

    function updateitem(id) {
        window.location.href = ""/HomeManagment/Update?id="" + id;
    }

    function map(url) {
        window.location.href = url;
    }

    function Changecheck(id) {
         $.ajax({
            type: ""Post"",
            url: '/HomeManagment/CheckChange',
            data: { id: id },
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Home.Vila>> Html { get; private set; }
    }
}
#pragma warning restore 1591
