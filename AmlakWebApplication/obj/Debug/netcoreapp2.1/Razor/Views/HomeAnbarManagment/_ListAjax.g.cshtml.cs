#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb295193e37c735343f6e6bbbf8b3d61fc8888ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeAnbarManagment__ListAjax), @"mvc.1.0.view", @"/Views/HomeAnbarManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HomeAnbarManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_HomeAnbarManagment__ListAjax))]
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
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
using Utilities.Calender;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb295193e37c735343f6e6bbbf8b3d61fc8888ea", @"/Views/HomeAnbarManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeAnbarManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Home.Anbar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(151, 97, true);
            WriteLiteral("            <tr>\r\n                \r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 248, "\"", 283, 3);
            WriteAttributeValue("", 259, "updateitem(", 259, 11, true);
#line 10 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
WriteAttributeValue("", 270, item.HomeId, 270, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 282, ")", 282, 1, true);
            EndWriteAttribute();
            BeginContext(284, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(308, 16, false);
#line 11 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
               Write(item.MetrazhBena);

#line default
#line hidden
            EndContext();
            BeginContext(324, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 410, "\"", 445, 3);
            WriteAttributeValue("", 421, "updateitem(", 421, 11, true);
#line 13 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
WriteAttributeValue("", 432, item.HomeId, 432, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 444, ")", 444, 1, true);
            EndWriteAttribute();
            BeginContext(446, 22, true);
            WriteLiteral(">\r\n                   ");
            EndContext();
            BeginContext(469, 16, false);
#line 14 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
              Write(item.MetrazhBena);

#line default
#line hidden
            EndContext();
            BeginContext(485, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 571, "\"", 606, 3);
            WriteAttributeValue("", 582, "updateitem(", 582, 11, true);
#line 16 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
WriteAttributeValue("", 593, item.HomeId, 593, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 605, ")", 605, 1, true);
            EndWriteAttribute();
            BeginContext(607, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(631, 18, false);
#line 17 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
               Write(item.NegahbaniName);

#line default
#line hidden
            EndContext();
            BeginContext(649, 86, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 735, "\"", 770, 3);
            WriteAttributeValue("", 746, "updateitem(", 746, 11, true);
#line 19 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
WriteAttributeValue("", 757, item.HomeId, 757, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 769, ")", 769, 1, true);
            EndWriteAttribute();
            BeginContext(771, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(795, 19, false);
#line 20 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
               Write(item.NegahbaniPhone);

#line default
#line hidden
            EndContext();
            BeginContext(814, 177, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 991, "\"", 1021, 3);
            WriteAttributeValue("", 1001, "deleteitem(", 1001, 11, true);
#line 22 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1012, item.Id, 1012, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1020, ")", 1020, 1, true);
            EndWriteAttribute();
            BeginContext(1022, 68, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\HomeAnbarManagment\_ListAjax.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Home.Anbar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
