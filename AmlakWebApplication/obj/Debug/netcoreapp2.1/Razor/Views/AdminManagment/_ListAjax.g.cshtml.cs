#pragma checksum "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda09c7c7c00b44aabdd0c10eb42a71233cf9c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminManagment__ListAjax), @"mvc.1.0.view", @"/Views/AdminManagment/_ListAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminManagment/_ListAjax.cshtml", typeof(AspNetCore.Views_AdminManagment__ListAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda09c7c7c00b44aabdd0c10eb42a71233cf9c0c", @"/Views/AdminManagment/_ListAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminManagment__ListAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(119, 80, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" style=\"padding:50px;\">");
            EndContext();
            BeginContext(200, 9, false);
#line 8 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(209, 91, true);
            WriteLiteral("</td>\r\n                <td class=\"text-center\" style=\"padding:50px;\">\r\n                    ");
            EndContext();
            BeginContext(301, 11, false);
#line 10 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
               Write(item.Family);

#line default
#line hidden
            EndContext();
            BeginContext(312, 109, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:50px;\">\r\n                    ");
            EndContext();
            BeginContext(422, 13, false);
#line 13 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
               Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(435, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:50px;\">\r\n");
            EndContext();
#line 16 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
                      
                        if (item.Active == true)
                        {

#line default
#line hidden
            BeginContext(625, 73, true);
            WriteLiteral("                            <input type=\"checkbox\" checked=\"checked\" />\r\n");
            EndContext();
#line 20 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(782, 55, true);
            WriteLiteral("                            <input type=\"checkbox\" />\r\n");
            EndContext();
#line 24 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(887, 177, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:50px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1064, "\"", 1094, 3);
            WriteAttributeValue("", 1074, "deleteitem(", 1074, 11, true);
#line 28 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
WriteAttributeValue("", 1085, item.Id, 1085, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1093, ")", 1093, 1, true);
            EndWriteAttribute();
            BeginContext(1095, 68, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\tohid\Source\Repos\AmlakWebApplication\AmlakWebApplication\Views\AdminManagment\_ListAjax.cshtml"
        }

    }


#line default
#line hidden
            BeginContext(1188, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591