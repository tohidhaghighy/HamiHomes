#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d54317a34992f5ab1be85657ce9dd50a374adb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NahieManagment__ListAjax), @"mvc.1.0.view", @"/Views/NahieManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NahieManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_NahieManagment__ListAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d54317a34992f5ab1be85657ce9dd50a374adb3", @"/Views/NahieManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_NahieManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Location.Nahie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;height:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(128, 78, true);
            WriteLiteral("    <tr>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(206, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29cc5f06874e437caacbb99aa297d04a", async() => {
                BeginContext(236, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46ddda6f1cf1484bbb56ffb31a337fa1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 278, "~/images/", 278, 9, true);
#line 9 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 287, item.Icon, 287, 10, false);

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
            AddHtmlAttributeValue("", 215, "~/images/", 215, 9, true);
#line 9 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 224, item.Icon, 224, 10, false);

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
            BeginContext(305, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(391, 9, false);
#line 12 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(400, 87, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(488, 9, false);
#line 16 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
       Write(item.Gpsx);

#line default
#line hidden
            EndContext();
            BeginContext(497, 5, true);
            WriteLiteral("  -  ");
            EndContext();
            BeginContext(503, 9, false);
#line 16 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
                      Write(item.Gpsy);

#line default
#line hidden
            EndContext();
            BeginContext(512, 87, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td class=\"text-center\" style=\"padding:10px;\">\r\n            ");
            EndContext();
            BeginContext(600, 14, false);
#line 20 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
       Write(item.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(614, 170, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"افزودن محله\"><a class=\"btn btn-warning btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 784, "\"", 815, 3);
            WriteAttributeValue("", 794, "Mahalleitem(", 794, 12, true);
#line 22 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
WriteAttributeValue("", 806, item.Id, 806, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 814, ")", 814, 1, true);
            EndWriteAttribute();
            BeginContext(816, 175, true);
            WriteLiteral(">افزودن محله</a></p></td>\r\n        <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"ویرایش\"><a class=\"btn btn-primary btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 991, "\"", 1021, 3);
            WriteAttributeValue("", 1001, "Updateitem(", 1001, 11, true);
#line 23 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1012, item.Id, 1012, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1020, ")", 1020, 1, true);
            EndWriteAttribute();
            BeginContext(1022, 166, true);
            WriteLiteral(">ویرایش</a></p></td>\r\n        <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1188, "\"", 1218, 3);
            WriteAttributeValue("", 1198, "deleteitem(", 1198, 11, true);
#line 24 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1209, item.Id, 1209, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1217, ")", 1217, 1, true);
            EndWriteAttribute();
            BeginContext(1219, 60, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n    </tr>\r\n");
            EndContext();
#line 26 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListAjax.cshtml"
        }

    }


#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Location.Nahie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
