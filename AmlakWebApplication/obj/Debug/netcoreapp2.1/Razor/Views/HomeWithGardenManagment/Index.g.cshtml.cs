#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeWithGardenManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9fdd43a3def97b9028ebb14787e4f7a9314bfa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeWithGardenManagment_Index), @"mvc.1.0.view", @"/Views/HomeWithGardenManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeWithGardenManagment/Index.cshtml", typeof(AspNetCore.Views_HomeWithGardenManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9fdd43a3def97b9028ebb14787e4f7a9314bfa5", @"/Views/HomeWithGardenManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeWithGardenManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Home.HomewithGarden>>
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeWithGardenManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(141, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67911d15f9fc4afb8bf78b4a80a679d3", async() => {
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
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ae781e1665e4059bbb2774e7768c81d", async() => {
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
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(304, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa82c78e7534f7ca4a50ee72e4bb247", async() => {
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
            BeginContext(353, 861, true);
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
        <li><a href=""/HomeWithGardenManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت خانه حیاط دار  </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت خانه حیاط دار </h4>
    در اینجا میتوانید لیست خانه حیاط دار های درج شده را ببینید و اطلاعات ان را ویرایش و یا حذف کنید

</div>

<div class=""row"">
    <div class=""container"">
        <div class=""col-lg-2 col-xs-4"">
            <!-- small box -->
            <div class=""small-box bg-primary"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1215, 47, false);
#line 42 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeWithGardenManagment\Index.cshtml"
                   Write(Model.Where(a => a.Home.IsShow == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1262, 467, true);
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
            BeginContext(1730, 48, false);
#line 56 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeWithGardenManagment\Index.cshtml"
                   Write(Model.Where(a => a.Home.IsShow == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1778, 1265, true);
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
    <a href=""/HomeVilaManagment/Create"" class=""btn btn-default"">افزودن خانه حیاط دار جدید</a>
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
                        <th class=""text-center"">عرض گذر</t");
            WriteLiteral("h>\r\n                        <th class=\"text-center\">عرض ملک</th>\r\n                        <th class=\"text-center\">حذف</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"listofarticle\">\r\n                    ");
            EndContext();
            BeginContext(3044, 43, false);
#line 88 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeWithGardenManagment\Index.cshtml"
               Write(await Html.PartialAsync("_ListAjax", Model));

#line default
#line hidden
            EndContext();
            BeginContext(3087, 1495, true);
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
            url: '/HomeManagment/Delete',
            data: { id: id },
            success: function (data) {
                window.location.reload();
            }
        });
 ");
            WriteLiteral(@"   }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Home.HomewithGarden>> Html { get; private set; }
    }
}
#pragma warning restore 1591
