#pragma checksum "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eae320f18ce702e3cc17c1419653a4efba56ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeFacilityManagment__ListAjax), @"mvc.1.0.view", @"/Views/HomeFacilityManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeFacilityManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_HomeFacilityManagment__ListAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eae320f18ce702e3cc17c1419653a4efba56ab4", @"/Views/HomeFacilityManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeFacilityManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.HomeFacility>>
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
#line 2 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(126, 102, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" style=\"padding:50px;\">\r\n                    ");
            EndContext();
            BeginContext(228, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c6e8e4a86444e01bf3e8566b07fa4b3", async() => {
                BeginContext(258, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87bc0e6a34d94cada611f50cc2385775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 300, "~/images/", 300, 9, true);
#line 9 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 309, item.Icon, 309, 10, false);

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
            AddHtmlAttributeValue("", 237, "~/images/", 237, 9, true);
#line 9 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
AddHtmlAttributeValue("", 246, item.Icon, 246, 10, false);

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
            BeginContext(327, 109, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:50px;\">\r\n                    ");
            EndContext();
            BeginContext(437, 9, false);
#line 12 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(446, 179, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td class=\"text-center\" style=\"padding:50px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 625, "\"", 655, 3);
            WriteAttributeValue("", 635, "deleteitem(", 635, 11, true);
#line 15 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
WriteAttributeValue("", 646, item.Id, 646, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 654, ")", 654, 1, true);
            EndWriteAttribute();
            BeginContext(656, 68, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 17 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\HomeFacilityManagment\_ListAjax.cshtml"
        }

    }


#line default
#line hidden
            BeginContext(749, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.HomeFacility>> Html { get; private set; }
    }
}
#pragma warning restore 1591