#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b55f9762354ee00e65ba276ddd6ff722fabf138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerManagment__Customerlist), @"mvc.1.0.view", @"/Views/CustomerManagment/_Customerlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerManagment/_Customerlist.cshtml", typeof(AspNetCore.Views_CustomerManagment__Customerlist))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b55f9762354ee00e65ba276ddd6ff722fabf138", @"/Views/CustomerManagment/_Customerlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e994221b564cf6324d43362954a7d1fac99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerManagment__Customerlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DomainLayer.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"
  
    if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(122, 102, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" style=\"padding:20px;\">\r\n                    ");
            EndContext();
            BeginContext(225, 9, false);
#line 9 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"
               Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(234, 109, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\" style=\"padding:20px;\">\r\n                    ");
            EndContext();
            BeginContext(344, 9, false);
#line 12 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(353, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(355, 11, false);
#line 12 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"
                          Write(item.Family);

#line default
#line hidden
            EndContext();
            BeginContext(366, 183, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td class=\"text-center\" style=\"padding:20px;\"><p data-placement=\"top\" data-toggle=\"tooltip\" title=\"انتخاب\"><a class=\"btn btn-success btn-xs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 549, "\"", 575, 3);
            WriteAttributeValue("", 559, "select(", 559, 7, true);
#line 15 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"
WriteAttributeValue("", 566, item.Id, 566, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 574, ")", 574, 1, true);
            EndWriteAttribute();
            BeginContext(576, 41, true);
            WriteLiteral(">انتخاب</a></p></td>\r\n            </tr>\r\n");
            EndContext();
#line 17 "D:\Projects\AmlakWebApplication\AmlakWebApplication\Views\CustomerManagment\_Customerlist.cshtml"

        }

    }


#line default
#line hidden
            BeginContext(644, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DomainLayer.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
