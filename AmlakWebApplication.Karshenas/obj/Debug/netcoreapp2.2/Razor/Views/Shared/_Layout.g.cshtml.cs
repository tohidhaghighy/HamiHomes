#pragma checksum "D:\Projects\AmlakWebApplication\AmlakWebApplication.Karshenas\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61680f03554c8ca2f1fb260a660ebd22d61ec900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "D:\Projects\AmlakWebApplication\AmlakWebApplication.Karshenas\Views\_ViewImports.cshtml"
using AmlakWebApplication.Karshenas;

#line default
#line hidden
#line 2 "D:\Projects\AmlakWebApplication\AmlakWebApplication.Karshenas\Views\_ViewImports.cshtml"
using AmlakWebApplication.Karshenas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61680f03554c8ca2f1fb260a660ebd22d61ec900", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7226094acd22d8f963ad5dd10490819bcb2f748", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-reboot.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/multiselect/js/bootstrap-multiselect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/multiselect/css/bootstrap-multiselect.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bodyid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 48, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html dir=\"rtl\" lang=\"fa-IR\">\r\n");
            EndContext();
            BeginContext(48, 4244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61680f03554c8ca2f1fb260a660ebd22d61ec9007653", async() => {
                BeginContext(54, 259, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>حامی هوم</title>
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <meta http-equiv=""Content-Language"" content=""fa"" />

    ");
                EndContext();
                BeginContext(313, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61680f03554c8ca2f1fb260a660ebd22d61ec9008305", async() => {
                    BeginContext(348, 10, true);
                    WriteLiteral("\r\n\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(372, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(378, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61680f03554c8ca2f1fb260a660ebd22d61ec9009808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(428, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(434, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61680f03554c8ca2f1fb260a660ebd22d61ec90011141", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(491, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(497, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61680f03554c8ca2f1fb260a660ebd22d61ec90012475", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(543, 716, true);
                WriteLiteral(@"
    <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.7.0/css/all.css' integrity='sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ' crossorigin='anonymous'>
    <link href=""https://unpkg.com/aos@2.3.1/dist/aos.css"" rel=""stylesheet"">
    <!--javascript-->
    <script src=""js/custom-js.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
    <script src=""https://unpkg.com/aos@2.3.1/dist/aos.js""></script>

    ");
                EndContext();
                BeginContext(1259, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61680f03554c8ca2f1fb260a660ebd22d61ec90014535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1350, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1356, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61680f03554c8ca2f1fb260a660ebd22d61ec90015878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1451, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1457, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61680f03554c8ca2f1fb260a660ebd22d61ec90017300", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1506, 2779, true);
                WriteLiteral(@"

    <style>


        .nav-hover:hover {
            border-bottom: 3px solid red;
        }

        .btnchange {
            -webkit-transition: color 1s; /* For Safari 3.0 to 6.0 */
            transition: color 1s; /* For modern browsers */
            border-radius: 10px 10px 10px 10px;
            margin-top: 10px;
            color: black;
            padding: 10px;
        }

            .btnchange:hover {
                background: #ca062b;
                color: white;
            }

        .btnchange1 {
            -webkit-transition: color 1s; /* For Safari 3.0 to 6.0 */
            transition: color 1s; /* For modern browsers */
            border-radius: 10px 10px 10px 10px;
            margin-top: 10px;
            color: black;
            padding: 10px;
        }

            .btnchange1:hover {
                color: #000000;
            }

        .col-1, .col-2, .col-3, .col-4, .col-5, .col-6, .col-7, .col-8, .col-9, .col-10, .col-11, .col-12, .col, ");
                WriteLiteral(@".col-auto, .col-sm-1, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm, .col-sm-auto, .col-md-1, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-10, .col-md-11, .col-md-12, .col-md, .col-md-auto, .col-lg-1, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg, .col-lg-auto, .col-xl-1, .col-xl-2, .col-xl-3, .col-xl-4, .col-xl-5, .col-xl-6, .col-xl-7, .col-xl-8, .col-xl-9, .col-xl-10, .col-xl-11, .col-xl-12, .col-xl, .col-xl-auto {
            position: relative;
            width: 100%;
            min-height: 1px;
            padding-left: 0px;
            padding-right: 0px;
        }

        input:focus {
            outline: none;
        }


        .padd {
            padding-left: 3px;
            padding-right: 3px;
        }

        option {
            color: black;
      ");
                WriteLiteral(@"  }

        .dropdown-menu {
            min-width: 12rem;
        }

        select {
            text-align: center;
            text-align-last: center;
            -moz-text-align-last: center;
        }

        .select-btn {
            color: black;
        }

            .select-btn :hover {
                color: #e4002b;
            }

        .multiselect-container {
            height: 200px;
            overflow-y: scroll;
            overflow-x: scroll;
        }

        .dropdown-item {
            display: inline;
        }

        .card {
            cursor: pointer;
        }

        .border-down {
            border-bottom: 3px solid red;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4292, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4294, 8141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61680f03554c8ca2f1fb260a660ebd22d61ec90022284", async() => {
                BeginContext(4312, 75, true);
                WriteLiteral("\r\n\r\n\r\n    <div style=\"background-color:#f8f9fa;margin-top:50px;\">\r\n        ");
                EndContext();
                BeginContext(4388, 12, false);
#line 127 "D:\Projects\AmlakWebApplication\AmlakWebApplication.Karshenas\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4400, 7982, true);
                WriteLiteral(@"

    </div>

    <footer class=""page-footer font-small unique-color-dark"">

        <div style=""background-color: rgba(0, 0, 0, 0.58);"">
            <div class=""container"">

                <!-- Grid row-->
                <div class=""row py-4 d-flex align-items-center"">

                    <!-- Grid column -->
                    <div class=""col-md-6 col-lg-5 text-center text-md-left mb-4 mb-md-0"">
                        <h6 class=""mb-0"" style=""color:white;"">در شبکه اجتماعی ما را دنبال کنید</h6>
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-md-6 col-lg-7 text-center text-md-right"" id=""icons"">

                        <!-- Facebook -->
                        <a class=""fb-ic"">
                            <i class=""fab fa-facebook-f white-text mr-4 coloricon""> </i>
                        </a>
                        <!-- Twitter -->
                        <a class=""tw-ic"">
         ");
                WriteLiteral(@"                   <i class=""fab fa-twitter white-text mr-4 coloricon""> </i>
                        </a>
                        <!-- Google +-->
                        <a class=""gplus-ic"">
                            <i class=""fab fa-google-plus-g white-text mr-4 coloricon""> </i>
                        </a>
                        <!--Linkedin -->
                        <a class=""li-ic"">
                            <i class=""fab fa-linkedin-in white-text mr-4 coloricon""> </i>
                        </a>
                        <!--Instagram-->
                        <a class=""ins-ic"">
                            <i class=""fab fa-instagram white-text coloricon""> </i>
                        </a>

                    </div>
                    <!-- Grid column -->

                </div>
                <!-- Grid row-->

            </div>
        </div>

        <!-- Footer Links -->
        <div class=""container text-center text-md-left mt-5"">

            <!-- Grid row -->
");
                WriteLiteral(@"            <div class=""row mt-3"">

                <!-- Grid column -->
                <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">

                    <!-- Content -->
                    <h6 class=""text-uppercase font-weight-bold"">درباره ما</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        اطلاعات مختصری در مورد شرکت در اینجا نوشته میشود
                    </p>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">

                    <!-- Links -->
                    <h6 class=""text-uppercase font-weight-bold"">پر بازدید ها</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <a href=""#!"">پیمانکاران</a>
                    </p>
                ");
                WriteLiteral(@"    <p>
                        <a href=""#!"">رهن و اجاره </a>
                    </p>
                    <p>
                        <a href=""#!"">فروش</a>
                    </p>
                    <p>
                        <a href=""#!"">ساخت</a>
                    </p>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">

                    <!-- Links -->
                    <h6 class=""text-uppercase font-weight-bold"">اخبار جدید</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <a href=""#!"">قیمت خرید</a>
                    </p>
                    <p>
                        <a href=""#!"">خبر جدید در مورد املاک</a>
                    </p>
                    <p>
                        <a href=""#!"">دکوراسیون داخلی </a>
                    </p>
        ");
                WriteLiteral(@"            <p>
                        <a href=""#!"">طراحی سنتی ساختمان</a>
                    </p>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">

                    <!-- Links -->
                    <h6 class=""text-uppercase font-weight-bold"">ارتباط با ما</h6>
                    <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
                    <p>
                        <i class=""fas fa-home mr-3""></i> خیابان حسنی
                    </p>
                    <p>
                        <i class=""fas fa-envelope mr-3""></i> info@hamihomes.com
                    </p>
                    <p>
                        <i class=""fas fa-phone mr-3""></i> +989144967941
                    </p>
                    <p>
                        <i class=""fas fa-print mr-3""></i> +98354874458
                    </p>

       ");
                WriteLiteral(@"         </div>
                <!-- Grid column -->

            </div>
            <!-- Grid row -->

        </div>



        <!-- Footer Links -->
        <!-- Copyright -->
        <div class=""footer-copyright text-center py-3"">
            © 2020 Copyright:
            <a href=""""> طراحی شده توسط گروه نرم افزاری طرح و تصویر</a>
        </div>
        <!-- Copyright -->

    </footer>
    <script>
        AOS.init();
        $(document).ready(function () {
            listdata();
            $(""#menusub"").hide();
            $(""#showwhenscroll"").hide();
            AOS.init();

        });

        $(document).scroll(function () {
            var y = $(this).scrollTop();
            if (y > 500) {
                $('#showwhenscroll').slideDown();
            } else {
                $('#showwhenscroll').slideUp();
            }
        });
        function listdata() {
            $.ajax({
                type: ""Post"",
                url: '/Home/Getdatalist',
   ");
                WriteLiteral(@"             success: function (data) {
                    $(""#defaultEmails"").empty();
                    $(""#defaultEmails"").append(data);
                }
            });
        }


        function changecolor(color) {
            var buyheadershow = document.getElementById(""buyheadershow"");
            buyheadershow.classList.remove(""border-down"");
            var rentheadershow = document.getElementById(""rentheadershow"");
            rentheadershow.classList.remove(""border-down"");
            var buildheadershow = document.getElementById(""buildheadershow"");
            buildheadershow.classList.remove(""border-down"");
            var soldheadershow = document.getElementById(""soldheadershow"");
            soldheadershow.classList.remove(""border-down"");
            if (color == 1) {
                $(""#buyheadershow"").addClass(""border-down"");
                typemelk = 1;
            } else if (color == 2) {
                $(""#rentheadershow"").addClass(""border-down"");
           ");
                WriteLiteral(@"     typemelk = 2;
            } else if (color == 3) {
                $(""#buildheadershow"").addClass(""border-down"");
                typemelk = 3;
            } else if (color == 4) {
                $(""#soldheadershow"").addClass(""border-down"");
                typemelk = 4;
            }
        }

        function showhidemenu() {
            var x = document.getElementById(""menusub"");

            if (x.style.display === ""none"") {
                $(""#menusub"").slideDown(100);

            } else {
                $(""#menusub"").slideUp(100);

            }
        }

        function shownumberhide() {
            document.getElementById(""btnnumberphonehide"").innerHTML = ""<span class='fa fa-phone' style='padding:5px;'></span> 09144967941"";
        }
    </script>



    ");
                EndContext();
                BeginContext(12383, 41, false);
#line 348 "D:\Projects\AmlakWebApplication\AmlakWebApplication.Karshenas\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(12424, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12435, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591