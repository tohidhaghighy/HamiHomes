#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98dc1b4eaa2713d5baf0b26b96cc97c7ca77ebde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeGardenManagment__ListAjax), @"mvc.1.0.view", @"/Views/HomeGardenManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeGardenManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_HomeGardenManagment__ListAjax))]
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
using Utilities.Calender;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98dc1b4eaa2713d5baf0b26b96cc97c7ca77ebde", @"/Views/HomeGardenManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeGardenManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Home.Garden>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(152, 82, true);
            WriteLiteral("            <tr >\r\n\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 234, "\"", 268, 3);
            WriteAttributeValue("", 244, "updateitem(", 244, 11, true);
#line 10 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
WriteAttributeValue("", 255, item.HomeId, 255, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 267, ")", 267, 1, true);
            EndWriteAttribute();
            BeginContext(269, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(293, 17, false);
#line 11 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
               Write(item.Metrazhzamin);

#line default
#line hidden
            EndContext();
            BeginContext(310, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 396, "\"", 430, 3);
            WriteAttributeValue("", 406, "updateitem(", 406, 11, true);
#line 13 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
WriteAttributeValue("", 417, item.HomeId, 417, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 429, ")", 429, 1, true);
            EndWriteAttribute();
            BeginContext(431, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(455, 18, false);
#line 14 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
               Write(item.NegahbaniName);

#line default
#line hidden
            EndContext();
            BeginContext(473, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 559, "\"", 593, 3);
            WriteAttributeValue("", 569, "updateitem(", 569, 11, true);
#line 16 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
WriteAttributeValue("", 580, item.HomeId, 580, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 592, ")", 592, 1, true);
            EndWriteAttribute();
            BeginContext(594, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(618, 19, false);
#line 17 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
               Write(item.NegahbaniPhone);

#line default
#line hidden
            EndContext();
            BeginContext(637, 177, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 814, "\"", 844, 3);
            WriteAttributeValue("", 824, "deleteitem(", 824, 11, true);
#line 19 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
WriteAttributeValue("", 835, item.Id, 835, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 843, ")", 843, 1, true);
            EndWriteAttribute();
            BeginContext(845, 68, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeGardenManagment\_ListAjax.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Home.Garden>> Html { get; private set; }
    }
}
#pragma warning restore 1591
