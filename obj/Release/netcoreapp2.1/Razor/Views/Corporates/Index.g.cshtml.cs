#pragma checksum "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e378312765962aea0e2ed92f6be355279c7d0a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Corporates_Index), @"mvc.1.0.view", @"/Views/Corporates/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Corporates/Index.cshtml", typeof(AspNetCore.Views_Corporates_Index))]
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
#line 1 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\_ViewImports.cshtml"
using TaxWebApp;

#line default
#line hidden
#line 2 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\_ViewImports.cshtml"
using TaxWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e378312765962aea0e2ed92f6be355279c7d0a26", @"/Views/Corporates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62caf2104da4c237e370046ec6b798b2dec09c80", @"/Views/_ViewImports.cshtml")]
    public class Views_Corporates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<TaxWebApp.Models.Corporate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 116, true);
            WriteLiteral("\r\n<\r\n<style>\r\n    .table tr:nth-child(even) {\r\n        background-color: #f2f2f2;\r\n    }\r\n</style>\r\n\r\n<h1>Today is: ");
            EndContext();
            BeginContext(257, 21, false);
#line 15 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
         Write(ViewData["toDayDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(278, 95, true);
            WriteLiteral(" </h1>\r\n\r\n<h2>Corporates:</h2>\r\n<p>\r\n    <a href=\"/Corporates/Create/\">Create New</a>\r\n</p>\r\n\r\n");
            EndContext();
#line 22 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(403, 31, true);
            WriteLiteral("    <p>\r\n        Find by name: ");
            EndContext();
            BeginContext(435, 61, false);
#line 25 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                 Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
            EndContext();
            BeginContext(496, 60, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            EndContext();
#line 28 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
}

#line default
#line hidden
            BeginContext(559, 100, true);
            WriteLiteral("<div>\r\n    <table class=\"table\" style=\"width:70%\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34217845d21d43ff8da2f46cefff4ecb", async() => {
                BeginContext(784, 6, true);
                WriteLiteral("Number");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                               WriteLiteral(ViewData["NumberSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                                                                                     WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(849, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2df3407f464d6aa3e49596924aad20", async() => {
                BeginContext(972, 4, true);
                WriteLiteral("Name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                               WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                                                                                   WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 83, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Notes</th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1063, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "968dc45c0df24942b5df4d4f6473d7a3", async() => {
                BeginContext(1190, 8, true);
                WriteLiteral("Preparer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                               WriteLiteral(ViewData["PreparerSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                                                                                       WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1202, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1257, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c504b9d3559647c3b165847ecc786fe9", async() => {
                BeginContext(1382, 6, true);
                WriteLiteral("Status");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                               WriteLiteral(ViewData["StatusSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                                                                                                     WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1392, 61, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 48 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1502, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1563, 41, false);
#line 52 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1672, 39, false);
#line 55 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1779, 40, false);
#line 58 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1887, 43, false);
#line 61 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Preparer));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1998, 41, false);
#line 64 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2108, "\"", 2143, 2);
            WriteAttributeValue("", 2115, "/Corporates/Details/", 2115, 20, true);
#line 67 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
WriteAttributeValue("", 2135, item.Id, 2135, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2144, 38, true);
            WriteLiteral(">Details</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2182, "\"", 2214, 2);
            WriteAttributeValue("", 2189, "/Corporates/Edit/", 2189, 17, true);
#line 68 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
WriteAttributeValue("", 2206, item.Id, 2206, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2215, 53, true);
            WriteLiteral(">Edit</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2279, 26, true);
            WriteLiteral("    </table>\r\n    <br />\r\n");
            EndContext();
#line 74 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    

#line default
#line hidden
            BeginContext(2456, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2462, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd16b0f730342c5abfa4455acba1a20", async() => {
                BeginContext(2694, 24, true);
                WriteLiteral("\r\n        Previous\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
            WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2663, "btn", 2663, 3, true);
            AddHtmlAttributeValue(" ", 2666, "btn-default", 2667, 12, true);
#line 83 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
AddHtmlAttributeValue(" ", 2678, prevDisabled, 2679, 13, false);

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
            BeginContext(2722, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2728, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f503309399485dbff04ba6d0408c9d", async() => {
                BeginContext(2960, 20, true);
                WriteLiteral("\r\n        Next\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
            WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2929, "btn", 2929, 3, true);
            AddHtmlAttributeValue(" ", 2932, "btn-default", 2933, 12, true);
#line 90 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\Index.cshtml"
AddHtmlAttributeValue(" ", 2944, nextDisabled, 2945, 13, false);

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
            BeginContext(2984, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<TaxWebApp.Models.Corporate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
