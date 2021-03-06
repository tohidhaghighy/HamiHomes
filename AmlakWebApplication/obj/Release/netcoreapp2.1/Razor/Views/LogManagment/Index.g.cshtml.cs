#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d05dd66cf63392c2724cb93508a4124adaf311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogManagment_Index), @"mvc.1.0.view", @"/Views/LogManagment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LogManagment/Index.cshtml", typeof(AspNetCore.Views_LogManagment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d05dd66cf63392c2724cb93508a4124adaf311", @"/Views/LogManagment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_LogManagment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Log>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Managment.cshtml";

#line default
#line hidden
            BeginContext(121, 1171, true);
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
        <li><a href=""/LogManagment/Index""><i class=""fa fa-dashboard""></i> خانه</a></li>
        <li class=""active"">گزارش خطا  </li>
    </ol>
</section>

<div class=""callout callout-info"" style=""margin-top:10px;"">
    <h4>گزارش خطا</h4>
    این قسمت مخصوص برنامه نویس است و برنامه در هنگام ایجاد مشکل در اینجا گزارش بخشی که مشکل ایجاد کرده را قرار میدهد

</div>


<div class=""row"" style=""padding:50px;"">
    <div class=""col-md-12 box"">
        <div class=""table-responsive box-body"">
            <table id=""mytable"" class=""table table-bordered table-hover"" style=""background-color:white;"">
                <thead>
                    <tr>
                        <th class=""text-center"">متن</th>
                        <th class=""text-center"">کنترلر</th>
        ");
            WriteLiteral("                <th class=\"text-center\">ویو</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"listofarticle\">\r\n");
            EndContext();
#line 44 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
                     if (Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1440, 150, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\" style=\"padding:10px;\">\r\n                                    ");
            EndContext();
            BeginContext(1591, 12, false);
#line 50 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
                               Write(item.LogText);

#line default
#line hidden
            EndContext();
            BeginContext(1603, 157, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\" style=\"padding:10px;\">\r\n                                    ");
            EndContext();
            BeginContext(1761, 18, false);
#line 53 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
                               Write(item.LogController);

#line default
#line hidden
            EndContext();
            BeginContext(1779, 157, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\" style=\"padding:10px;\">\r\n                                    ");
            EndContext();
            BeginContext(1937, 12, false);
#line 56 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
                               Write(item.LogView);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 60 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\LogManagment\Index.cshtml"
                        }

                    }

#line default
#line hidden
            BeginContext(2079, 90, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Log>> Html { get; private set; }
    }
}
#pragma warning restore 1591
