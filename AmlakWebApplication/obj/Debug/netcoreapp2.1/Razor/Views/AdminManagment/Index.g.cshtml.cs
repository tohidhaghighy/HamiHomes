#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1afb438d70e8e594a6d3397ec7b4838b0ba8fbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminManagment_Index), @"mvc.1.0.view", @"/Views/AdminManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminManagment/Index.cshtml", typeof(AspNetCore.Views_AdminManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1afb438d70e8e594a6d3397ec7b4838b0ba8fbed", @"/Views/AdminManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Admin>>
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
            BeginContext(32, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\Index.cshtml"
      
  ViewBag.Title = "مدیران سایت";
    

#line default
#line hidden
            BeginContext(81, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(85, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b78542ffb1a4dc18593db126932e668", async() => {
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
            BeginContext(144, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(150, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1bd6092307248e9add30add0ecd0ef7", async() => {
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
            BeginContext(250, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(256, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99ea3fd1ad54db19060771c131ce6bc", async() => {
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
            BeginContext(305, 1688, true);
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
            <li><a href=""/AdminManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
            <li class=""active"">مدیریت مدیران</li>
        </ol>
    </section>

    <div class=""callout callout-info"" style=""margin-top:10px;"">
        <h4>مدریت مدیران</h4>
        دو مدل مدیر میتوانید درج کنید یکی طلایی و دومی نقره ای
        در پنل طلایی دسترسی به افزودن ادمین داده میشود
        در پنل نقره ای تمام امکانات هست فقط دسترسی به ادمین جدید داده نمیشود
    </div>



    <p style=""margin-right:50px;"">
        <a href=""/AdminManagment/Create"" class=""btn btn-default"">افزودن مدیر جدید</a>
    </p>

    <div class=""row"" style=""padding:50px;"">
        <div class=""col-md-12 box"">
            <div class=""table-");
            WriteLiteral(@"responsive box-body"">
                <table id=""mytable"" class=""table table-bordered table-hover"" style=""background-color:white;"">
                    <thead>
                        <tr>
                            <th class=""text-center"">نام</th>
                            <th class=""text-center"">نام خانوادگی</th>
                            <th class=""text-center"">نام کاربری </th>
                            <th class=""text-center"">فعال /غیر فعال</th>
                            <th class=""text-center"">حذف</th>
                        </tr>
                    </thead>
                    <tbody id=""listofarticle"">
                        ");
            EndContext();
            BeginContext(1994, 43, false);
#line 54 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\Index.cshtml"
                   Write(await Html.PartialAsync("_ListAjax", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 1519, true);
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
                url: '/AdminManagment/Delete',
              ");
            WriteLiteral(@"  data: { id: id },
                success: function (data) {
                    window.location.reload();
                }
            });
        }

        function Changecheckuser(id) {
            $.ajax({
                type: ""Post"",
                url: '/AdminManagment/ChangeCheck',
                data: { id: id },
                success: function (data) {
                    window.location.reload();
                }
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
