#pragma checksum "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\SettingManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ace75272c139ae6f4e7ef2c9993696dc4800c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SettingManagment_Index), @"mvc.1.0.view", @"/Views/SettingManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SettingManagment/Index.cshtml", typeof(AspNetCore.Views_SettingManagment_Index))]
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
#line 1 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using AmlakWebApplication;

#line default
#line hidden
#line 2 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using AmlakWebApplication.Models;

#line default
#line hidden
#line 3 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\_ViewImports.cshtml"
using ViewModelLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ace75272c139ae6f4e7ef2c9993696dc4800c26", @"/Views/SettingManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_SettingManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\SettingManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(93, 2651, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        داشبرد
        <small>کنترل پنل</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""/SettingManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">مدیریت تنظیمات </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>مدریت تنظیمات</h4>
     این قسمت برای بهتر شدن سیو سایت تعبیه شده است و میتوانید در اینجا لینک شبکه های اجتماعی و  .. .
    را وارد کنید
</div>

<div class=""container"">
    <div class=""box box-danger"">
        <div class=""box-header"">
            <h3 class=""box-title"">تنظیمات</h3>
        </div>
        <div class=""box-body"">
            <div class=""form-group"">
                <label>عنوان</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>توضیحات</label>
                <input type=""text"" class=""form-control"">
            </div>
   ");
            WriteLiteral(@"         <div class=""form-group"">
                <label>کلمات کلیدی</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>نویسنده</label>
                <input type=""text"" class=""form-control"">
            </div>


        </div>
        <!-- /.box-body -->
    </div>
    <!-- /.box -->

    <div class=""box box-info"">
        <div class=""box-header"">
            <h3 class=""box-title"">شبکه های اجتماعی</h3>
        </div>
        <div class=""box-body"">
            <!-- Color Picker -->
            <div class=""form-group"">
                <label>اینیستاگرام</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>توییتر</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>تلگرام</label>
                <input type=""t");
            WriteLiteral(@"ext"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>گوگل +</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>اپارات</label>
                <input type=""text"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label>Youtube</label>
                <input type=""text"" class=""form-control"">
            </div>

        </div>
        <!-- /.box-body -->
    </div>
    <!-- /.box -->
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
