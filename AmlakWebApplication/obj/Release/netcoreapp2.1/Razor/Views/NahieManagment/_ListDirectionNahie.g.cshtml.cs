#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a01805bafacf5a09c31b34dc51c04b112a2ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NahieManagment__ListDirectionNahie), @"mvc.1.0.view", @"/Views/NahieManagment/_ListDirectionNahie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NahieManagment/_ListDirectionNahie.cshtml", typeof(AspNetCore.Views_NahieManagment__ListDirectionNahie))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a01805bafacf5a09c31b34dc51c04b112a2ae1", @"/Views/NahieManagment/_ListDirectionNahie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_NahieManagment__ListDirectionNahie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelLayer.City.NahieDirect>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 60, true);
            WriteLiteral("    <input style=\"display:none;\" id=\"nahieid\" name=\"nahieid\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 104, "\"", 126, 1);
#line 3 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
WriteAttributeValue("", 112, Model.nahieid, 112, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(127, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
#line 4 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
    if (Model.NahieDirections.Count() > 0)
    {
        foreach (var item in Model.NahieDirections)
        {

#line default
#line hidden
            BeginContext(246, 102, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" style=\"padding:10px;\">\r\n                    ");
            EndContext();
            BeginContext(349, 20, false);
#line 10 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
               Write(item.Gpsx.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(369, 109, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:10px;\">\r\n                    ");
            EndContext();
            BeginContext(479, 20, false);
#line 13 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
               Write(item.Gpsy.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(499, 179, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td class=\"text-center\" style=\"padding:10px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"حذف\"><a class=\"btn btn-danger btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 678, "\"", 708, 3);
            WriteAttributeValue("", 688, "deleteitem(", 688, 11, true);
#line 16 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
WriteAttributeValue("", 699, item.Id, 699, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 707, ")", 707, 1, true);
            EndWriteAttribute();
            BeginContext(709, 68, true);
            WriteLiteral("><i class=\"ion ion-ios-trash\"></i></a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 18 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\NahieManagment\_ListDirectionNahie.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelLayer.City.NahieDirect> Html { get; private set; }
    }
}
#pragma warning restore 1591
