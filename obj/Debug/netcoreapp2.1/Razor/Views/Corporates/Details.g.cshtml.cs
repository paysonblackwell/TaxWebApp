<<<<<<< HEAD
#pragma checksum "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0292d5b99755fe497438017fab6bddfede395c37"
=======
#pragma checksum "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f02d265a43b57f212f0b7603ffa0d4c604c8533"
>>>>>>> Grace
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Corporates_Details), @"mvc.1.0.view", @"/Views/Corporates/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Corporates/Details.cshtml", typeof(AspNetCore.Views_Corporates_Details))]
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
<<<<<<< HEAD
#line 1 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\_ViewImports.cshtml"
>>>>>>> Grace
using TaxWebApp;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\_ViewImports.cshtml"
>>>>>>> Grace
using TaxWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f02d265a43b57f212f0b7603ffa0d4c604c8533", @"/Views/Corporates/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c6a582af24dd9fcf635f671f82fb8c2104068b", @"/Views/_ViewImports.cshtml")]
    public class Views_Corporates_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaxWebApp.Models.Corporate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
<<<<<<< HEAD
#line 3 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 3 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    Corporate corporate = (Corporate)ViewData["corporationById"];

#line default
#line hidden
            BeginContext(194, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Corporate</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(318, 40, false);
<<<<<<< HEAD
#line 16 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 16 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(402, 40, false);
<<<<<<< HEAD
#line 19 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 19 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Type));

#line default
#line hidden
            EndContext();
            BeginContext(442, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(486, 42, false);
<<<<<<< HEAD
#line 22 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 22 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(572, 42, false);
<<<<<<< HEAD
#line 25 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 25 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Number));

#line default
#line hidden
            EndContext();
            BeginContext(614, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(658, 40, false);
<<<<<<< HEAD
#line 28 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 28 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(742, 40, false);
<<<<<<< HEAD
#line 31 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 31 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Name));

#line default
#line hidden
            EndContext();
            BeginContext(782, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(826, 39, false);
<<<<<<< HEAD
#line 34 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 34 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.New));

#line default
#line hidden
            EndContext();
            BeginContext(865, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(909, 39, false);
<<<<<<< HEAD
#line 37 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 37 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.New));

#line default
#line hidden
            EndContext();
            BeginContext(948, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(992, 38, false);
<<<<<<< HEAD
#line 40 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 40 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.In));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1074, 38, false);
<<<<<<< HEAD
#line 43 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 43 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.In));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1156, 41, false);
<<<<<<< HEAD
#line 46 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 46 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1241, 41, false);
<<<<<<< HEAD
#line 49 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 49 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1326, 42, false);
<<<<<<< HEAD
#line 52 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 52 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1412, 42, false);
<<<<<<< HEAD
#line 55 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 55 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1498, 44, false);
<<<<<<< HEAD
#line 58 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 58 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayNameFor(model => model.Preparer));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1586, 44, false);
<<<<<<< HEAD
#line 61 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Details.cshtml"
=======
#line 61 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
>>>>>>> Grace
       Write(Html.DisplayFor(model => corporate.Preparer));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1679, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "503d1c899d944a34a31124f53a144215", async() => {
                BeginContext(1729, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
                           WriteLiteral(corporate.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1737, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1745, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45aad1c016864260bc23d94283636724", async() => {
                BeginContext(1797, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Corporates\Details.cshtml"
                             WriteLiteral(corporate.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1807, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1815, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b1beaea69574a1a817429e2cd2d9147", async() => {
                BeginContext(1859, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1875, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaxWebApp.Models.Corporate> Html { get; private set; }
    }
}
#pragma warning restore 1591
