#pragma checksum "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32822ee795f5f635d736fba9f8c6544d4cc7c726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagment__ListAjax), @"mvc.1.0.view", @"/Views/UserManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_UserManagment__ListAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32822ee795f5f635d736fba9f8c6544d4cc7c726", @"/Views/UserManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(118, 64, true);
            WriteLiteral("    <tr>\r\n        <td class=\"text-center\" style=\"padding:50px;\">");
            EndContext();
            BeginContext(183, 9, false);
#line 8 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(192, 75, true);
            WriteLiteral("</td>\r\n        <td class=\"text-center\" style=\"padding:50px;\">\r\n            ");
            EndContext();
            BeginContext(268, 11, false);
#line 10 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
       Write(item.Family);

#line default
#line hidden
            EndContext();
            BeginContext(279, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:50px;\">\r\n            ");
            EndContext();
            BeginContext(365, 11, false);
#line 13 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
       Write(item.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(376, 85, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:50px;\">\r\n            ");
            EndContext();
            BeginContext(462, 13, false);
#line 16 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
       Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(475, 73, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:50px;\">\r\n");
            EndContext();
#line 19 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
              
                if (item.Active == true)
                {

#line default
#line hidden
            BeginContext(625, 65, true);
            WriteLiteral("                    <input type=\"checkbox\" checked=\"checked\" />\r\n");
            EndContext();
#line 23 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(750, 47, true);
            WriteLiteral("                    <input type=\"checkbox\" />\r\n");
            EndContext();
#line 27 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
                }
            

#line default
#line hidden
            BeginContext(831, 161, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-center\" style=\"padding:50px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 992, "\"", 1022, 3);
            WriteAttributeValue("", 1002, "deleteitem(", 1002, 11, true);
#line 31 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1013, item.Id, 1013, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1021, ")", 1021, 1, true);
            EndWriteAttribute();
            BeginContext(1023, 60, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\UserManagment\_ListAjax.cshtml"
        }

    }


#line default
#line hidden
            BeginContext(1108, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
