#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b66d63307c93f092887e0aebe624c37f9df8d1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MagzineManagment__ListAjax), @"mvc.1.0.view", @"/Views/MagzineManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MagzineManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_MagzineManagment__ListAjax))]
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
using Utilities.Calender;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b66d63307c93f092887e0aebe624c37f9df8d1f", @"/Views/MagzineManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_MagzineManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Magzine.Magazine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;height:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/def.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/def.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(157, 76, true);
            WriteLiteral("    <tr>\r\n        \r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n");
            EndContext();
#line 11 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
              
                if (item.Image!=null)
                {

#line default
#line hidden
            BeginContext(307, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(327, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76065e349eed40198ea1e98d817783b0", async() => {
                BeginContext(358, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d759d6276425474f91ae179711800b57", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 400, "~/images/", 400, 9, true);
#line 14 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 409, item.Image, 409, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 336, "~/images/", 336, 9, true);
#line 14 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 345, item.Image, 345, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(428, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(490, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(510, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138669c79fa94925b691451f45481a8e", async() => {
                BeginContext(537, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "832b2ce0e394428b824d8a76205d4cc3", async() => {
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
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
                }
            

#line default
#line hidden
            BeginContext(639, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(725, 10, false);
#line 24 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(735, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(821, 22, false);
#line 27 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
       Write(item.MagazinGroup.Name);

#line default
#line hidden
            EndContext();
            BeginContext(843, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(929, 9, false);
#line 30 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
       Write(item.Tags);

#line default
#line hidden
            EndContext();
            BeginContext(938, 73, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n");
            EndContext();
#line 33 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
               
                string s=Calender.OnlyPersianDate(item.Date);
            

#line default
#line hidden
            BeginContext(1106, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1119, 1, false);
#line 36 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
       Write(s);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 165, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"ویرایش\"><a class=\"btn btn-primary btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1285, "\"", 1313, 3);
            WriteAttributeValue("", 1295, "Edititem(", 1295, 9, true);
#line 38 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1304, item.Id, 1304, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1312, ")", 1312, 1, true);
            EndWriteAttribute();
            BeginContext(1314, 166, true);
            WriteLiteral(">ویرایش</a></p></td>\r\n        <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1480, "\"", 1510, 3);
            WriteAttributeValue("", 1490, "deleteitem(", 1490, 11, true);
#line 39 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1501, item.Id, 1501, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1509, ")", 1509, 1, true);
            EndWriteAttribute();
            BeginContext(1511, 60, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n    </tr>\r\n");
            EndContext();
#line 41 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\MagzineManagment\_ListAjax.cshtml"
        }

    }


#line default
#line hidden
            BeginContext(1596, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Magzine.Magazine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
