#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0f52d58754f2ce6c7a329fe0ef056b3685a410d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MagazinGroupManagment_Index), @"mvc.1.0.view", @"/Views/MagazinGroupManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MagazinGroupManagment/Index.cshtml", typeof(AspNetCore.Views_MagazinGroupManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f52d58754f2ce6c7a329fe0ef056b3685a410d", @"/Views/MagazinGroupManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_MagazinGroupManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Magzine.MagazinGroup>>
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
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(144, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66c5f9009bdb4efba050d22970394c94", async() => {
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
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(205, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7844c68150cd414abf526f250d12958f", async() => {
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
            BeginContext(305, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(307, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7da6ce07d0fc4d4caa70af9f6409816d", async() => {
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
            BeginContext(356, 980, true);
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
        <li><a href=""/MagazineManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت دسته بندی مجلات </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت دسته بندی مجلات</h4>
    در این قسمت مجلات حامی هوم را میتوانید در دسته بندی های مختلف وارد کنید
</div>



<p style=""margin-right:50px;"">
    <a href=""/MagazinGroupManagment/Create?id=0"" class=""btn btn-default"">افزودن دسته بندی مجلات جدید</a>
</p>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <ul class=""sidebar-menu"" data-widget=""tree"" style=""padding-top:20px;"">
            <li class=""header"" style=""background-color:#ffffff;"">منو</li>
");
            EndContext();
#line 46 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
              if (Model != null)
                {
                    foreach (var item in Model.Where(a => a.ParentId == 0))
                    {

#line default
#line hidden
            BeginContext(1489, 168, true);
            WriteLiteral("                        <li id=\"Workitem\" class=\"treeview\">\r\n                            <a href=\"#\">\r\n                                <span style=\"margin-right:50px;\">");
            EndContext();
            BeginContext(1658, 9, false);
#line 52 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 145, true);
            WriteLiteral("</span>\r\n                                <span class=\"pull-left-container\">\r\n                                    <i class=\"fa fa-trash pull-left\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1812, "\"", 1842, 3);
            WriteAttributeValue("", 1822, "deleteitem(", 1822, 11, true);
#line 54 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
WriteAttributeValue("", 1833, item.Id, 1833, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1841, ")", 1841, 1, true);
            EndWriteAttribute();
            BeginContext(1843, 110, true);
            WriteLiteral(" title=\"حذف گروه\" style=\"color:red;\"></i>\r\n                                    <i class=\"fa fa-plus pull-left\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1953, "\"", 1980, 3);
            WriteAttributeValue("", 1963, "additem(", 1963, 8, true);
#line 55 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
WriteAttributeValue("", 1971, item.Id, 1971, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1979, ")", 1979, 1, true);
            EndWriteAttribute();
            BeginContext(1981, 100, true);
            WriteLiteral(" title=\"درج زیر گروه\"></i>\r\n                                    <i class=\"fa fa-dashboard pull-left\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2081, "\"", 2110, 3);
            WriteAttributeValue("", 2091, "addMagzin(", 2091, 10, true);
#line 56 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
WriteAttributeValue("", 2101, item.Id, 2101, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2109, ")", 2109, 1, true);
            EndWriteAttribute();
            BeginContext(2111, 179, true);
            WriteLiteral(" title=\"افزودن مجله\" style=\"color:green;\"></i>\r\n                                </span>\r\n                            </a>\r\n                            <ul class=\"treeview-menu\">\r\n");
            EndContext();
#line 60 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
                                  
                                    foreach (var ziritem in Model.Where(a => a.ParentId == item.Id))
                                    {

#line default
#line hidden
            BeginContext(2467, 227, true);
            WriteLiteral("                                        <li class=\"active\" style=\"margin-right:20px;\">\r\n                                            <a href=\"#\">\r\n                                                <span style=\"margin-right:50px;\">");
            EndContext();
            BeginContext(2695, 12, false);
#line 65 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
                                                                            Write(ziritem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2707, 177, true);
            WriteLiteral("</span>\r\n                                                <span class=\"pull-left-container\">\r\n                                                    <i class=\"fa fa-trash pull-left\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2884, "\"", 2917, 3);
            WriteAttributeValue("", 2894, "deleteitem(", 2894, 11, true);
#line 67 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
WriteAttributeValue("", 2905, ziritem.Id, 2905, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2916, ")", 2916, 1, true);
            EndWriteAttribute();
            BeginContext(2918, 135, true);
            WriteLiteral(" title=\"حذف زیر گروه\" style=\"color:red;\"></i>\r\n                                                    <i class=\"fa fa-dashboard pull-left\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3053, "\"", 3085, 3);
            WriteAttributeValue("", 3063, "addMagzin(", 3063, 10, true);
#line 68 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
WriteAttributeValue("", 3073, ziritem.Id, 3073, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3084, ")", 3084, 1, true);
            EndWriteAttribute();
            BeginContext(3086, 202, true);
            WriteLiteral(" title=\"افزودن مجله\" style=\"color:green;\"></i>\r\n                                                </span>\r\n                                            </a>\r\n                                        </li>\r\n");
            EndContext();
#line 72 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(3362, 70, true);
            WriteLiteral("\r\n\r\n                            </ul>\r\n                        </li>\r\n");
            EndContext();
#line 78 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagazinGroupManagment\Index.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(3489, 1225, true);
            WriteLiteral(@"
        </ul>
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
            url: '/MagazinGroupManagment/Delete',
            data: { id: id },
            success: function (data) {
                window.location.reload();
            }
        });
        }

    function addMagzin(id) {
   ");
            WriteLiteral("     window.location.href = \"/MagzineManagment/Create?id=\" + id;\r\n        }\r\n\r\n    function additem(id) {\r\n        window.location.href = \"/MagazinGroupManagment/Create?id=\" + id;\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Magzine.MagazinGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591