#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8fe563316cc51ecc96da07967159cc97e30bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeGalleryManagment_Index), @"mvc.1.0.view", @"/Views/HomeGalleryManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeGalleryManagment/Index.cshtml", typeof(AspNetCore.Views_HomeGalleryManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8fe563316cc51ecc96da07967159cc97e30bd0", @"/Views/HomeGalleryManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeGalleryManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Home.HomeGallery>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/alert/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/alert/sweetalert.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(134, 302, true);
            WriteLiteral(@"
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>
");
            EndContext();
            BeginContext(436, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9af4b50b25af46d3afc32d40a612ba11", async() => {
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
            BeginContext(495, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(497, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bd01286b61db4d8ebfdf18b57495ac02", async() => {
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
            BeginContext(597, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(599, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af7392b94a049528437a5082aa1ffd2", async() => {
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
            BeginContext(648, 2138, true);
            WriteLiteral(@"
<style>


    .green {
        background-color: #6fb936;
    }

    .thumb {
        margin-bottom: 30px;
    }

    .page-top {
        margin-top: 85px;
    }


    img.zoom {
        width: 100%;
        height: 200px;
        border-radius: 10px;
        object-fit: cover;
        -webkit-transition: all .3s ease-in-out;
        -moz-transition: all .3s ease-in-out;
        -o-transition: all .3s ease-in-out;
        -ms-transition: all .3s ease-in-out;
    }


    .transition {
        -webkit-transform: scale(1.2);
        -moz-transform: scale(1.2);
        -o-transform: scale(1.2);
        transform: scale(1.2);
    }

    .modal-header {
        border-bottom: none;
    }

    .modal-title {
        color: #000;
    }

    .modal-footer {
        display: none;
    }

    .img-hover-zoom {
        height: 200px; /* [1.1] Set it as per your need */
    }

        /* [2] Transition property for smooth transformation of images */
        .img-hover-");
            WriteLiteral(@"zoom img {
            transition: transform .5s ease;
        }

        /* [3] Finally, transforming the image when container gets hovered */
        .img-hover-zoom:hover img {
            transform: scale(1.2);
        }
</style>

<section class=""content-header"">
    <h1>
        داشبورد
        <small>کنترل پنل</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/HomeGalleryManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت گالری </li>
    </ol>
</section>

<div class=""text-center"" style=""background:rgba(202, 199, 199, 0.50)"">
    <h4 class=""text-center"" style=""padding-top:80px;padding-bottom:10px;"">اطلاعات ملک شما با موفقیت ثبت گردید پس از بررسی منتشر خواهد شد</h4>
    <h6 class=""text-center"" style=""padding-top:10px;padding-bottom:50px;color:rgba(41, 41, 41, 0.75)"">برای بیشتر دیده شدن ملک خود در این قسمت میتوانید عکس اپلود کنید</h6>
</div>


<div class=""container"">
    <div class=""box box-danger"">
        <div clas");
            WriteLiteral("s=\"box-header\">\r\n            <h3 class=\"box-title\">عکس جدید</h3>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(2786, 911, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de7096cf7a44cb0a399c7f643657a38", async() => {
                BeginContext(2846, 54, true);
                WriteLiteral("\r\n            <div class=\"box-body\">\r\n                ");
                EndContext();
                BeginContext(2900, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea2455f92cb1483f9d50e7e24caa1e2b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 99 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2970, 204, true);
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <input type=\"number\" style=\"display:none;\" value=\"\">\r\n                </div>\r\n                <input type=\"number\" placeholder=\"عکس خانه \"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3174, "\"", 3197, 1);
#line 104 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
WriteAttributeValue("", 3182, ViewData["Id"], 3182, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3198, 492, true);
                WriteLiteral(@" name=""HomeId"" id=""HomeId"" style=""display:none;"">
                <div class=""form-group"">
                    <label>عکس</label>
                    <input type=""file"" placeholder=""عکس خانه "" name=""Image"" id=""Image"">
                    <span class=""text-danger""></span>
                </div>



                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-success"">درج عکس جدید</button>
                </div>

            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3697, 264, true);
            WriteLiteral(@"
        <!-- /.box-body -->
    </div>
    <!-- /.box -->
    <!-- /.box -->
</div>

<!-- Page Content -->
<div class=""container"">
    <div class=""box box-primary"">
        <div class=""box-header"" style=""margin:30px;"">

            <div class=""row"">
");
            EndContext();
#line 131 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(4053, 149, true);
            WriteLiteral("                        <div class=\"col-lg-3 col-md-4 col-xs-6 thumb\">\r\n                            <a class=\"fancybox img-hover-zoom\" rel=\"ligthbox\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4202, "\"", 4232, 3);
            WriteAttributeValue("", 4212, "deleteitem(", 4212, 11, true);
#line 135 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
WriteAttributeValue("", 4223, item.Id, 4223, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4231, ")", 4231, 1, true);
            EndWriteAttribute();
            BeginContext(4233, 39, true);
            WriteLiteral(">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4272, "\"", 4287, 1);
#line 136 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
WriteAttributeValue("", 4278, item.Url, 4278, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4288, 102, true);
            WriteLiteral(" class=\"zoom img-fluid \" alt=\"\">\r\n\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 140 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(4432, 1368, true);
            WriteLiteral(@"


            </div>

        </div>
    </div>
</div>


<script>

    $(document).ready(function () {
        $("".fancybox"").fancybox({
            openEffect: ""none"",
            closeEffect: ""none""
        });

        $("".zoom"").hover(function () {

            $(this).addClass('transition');
        }, function () {

            $(this).removeClass('transition');
        });
    });


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
   ");
            WriteLiteral(@"             }
            });
    }

    function sendtoservertodelete(id) {
        $.ajax({
            type: ""Post"",
            url: '/HomeGalleryManagment/Delete',
            data: { id: id },
            success: function (data) {
                window.location.reload();
            }
        });
        }

</script>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5818, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 205 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGalleryManagment\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Home.HomeGallery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
