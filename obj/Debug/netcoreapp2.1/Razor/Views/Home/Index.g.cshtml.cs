<<<<<<< HEAD
#pragma checksum "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b226fdf00fff27f487b513f81827c4b11a94834c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b226fdf00fff27f487b513f81827c4b11a94834c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c6a582af24dd9fcf635f671f82fb8c2104068b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaxWebApp.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";
    Person[] person = (Person[])ViewData["peopleArray"];

#line default
#line hidden
            BeginContext(195, 121, true);
            WriteLiteral("\r\n<style>\r\n    .tab-content tr:nth-child(even) {\r\n        background-color: #f2f2f2;\r\n    }\r\n\r\n</style>\r\n\r\n<h1>Today is: ");
            EndContext();
            BeginContext(317, 21, false);
#line 15 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
         Write(ViewData["toDayDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral(" </h1>\r\n\r\n<!-- Link to my example Page-->\r\n");
            EndContext();
            BeginContext(590, 82, true);
            WriteLiteral("\r\n\r\n<h2>Customers:</h2>\r\n<p>\r\n    <a href=\"/People/Create/\">Create New</a>\r\n</p>\r\n");
            EndContext();
#line 27 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(702, 31, true);
            WriteLiteral("    <p>\r\n        Find by name: ");
            EndContext();
            BeginContext(734, 28, false);
#line 30 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
                 Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(762, 60, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            EndContext();
#line 33 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(825, 88, true);
            WriteLiteral("<div>\r\n    <table class=\"tab-content\" style=\"width:70%\">\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(914, 42, false);
#line 37 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(956, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(980, 74, false);
#line 38 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Name", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1078, 39, false);
#line 39 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.New));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(1334, 16, true);
            WriteLiteral("            <th>");
            EndContext();
            BeginContext(1351, 41, false);
#line 43 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1416, 82, false);
#line 44 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Preparer", "Index", new { sortOrder = ViewBag.PreparerSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1522, 78, false);
#line 45 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Status", "Index", new { sortOrder = ViewBag.StatusSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 47, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2240, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2289, 41, false);
#line 70 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(2330, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2386, 39, false);
#line 73 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2481, 38, false);
#line 76 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.New));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(2835, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2870, 40, false);
#line 88 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2910, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2966, 43, false);
#line 91 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preparer));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3065, 41, false);
#line 94 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3106, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3163, "\"", 3194, 2);
            WriteAttributeValue("", 3170, "/People/Details/", 3170, 16, true);
#line 97 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3186, item.Id, 3186, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3195, 34, true);
            WriteLiteral(">Details</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3229, "\"", 3257, 2);
            WriteAttributeValue("", 3236, "/People/Edit/", 3236, 13, true);
#line 98 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3249, item.Id, 3249, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3258, 12, true);
            WriteLiteral(">Edit</a> \r\n");
            EndContext();
            BeginContext(3349, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3394, 4852, true);
            WriteLiteral(@"    </table>
</div>



<!-- Default Index Page Stuff
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <img src=""~/images/banner1.svg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how to build ASP.NET apps that can run anywhere.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner");
            WriteLiteral(@"2.svg"" alt=""Visual Studio"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    There are powerful new features in Visual Studio for building modern web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner3.svg"" alt=""Microsoft Azure"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </di");
            WriteLiteral(@"v>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core MVC</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Sec");
            WriteLiteral(@"rets using Secret Manager.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Overview</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview of what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=69");
            WriteLiteral(@"9321"">Client side development</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publish to Microsoft Azure Web Apps</a></li>
        </ul>
    </div>
</div>
-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaxWebApp.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
=======
#pragma checksum "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4547de26d9c58d0983d5d3b86782f1c2e9e2f2e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\_ViewImports.cshtml"
using TaxWebApp;

#line default
#line hidden
#line 2 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\_ViewImports.cshtml"
using TaxWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4547de26d9c58d0983d5d3b86782f1c2e9e2f2e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c6a582af24dd9fcf635f671f82fb8c2104068b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaxWebApp.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";
    Person[] person = (Person[])ViewData["peopleArray"];

#line default
#line hidden
            BeginContext(195, 119, true);
            WriteLiteral("\r\n<style>\r\n    .tab-content tr:nth-child(even) {\r\n        background-color: #f2f2f2;\r\n    }\r\n</style>\r\n\r\n<h1>Today is: ");
            EndContext();
            BeginContext(315, 21, false);
#line 14 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
         Write(ViewData["toDayDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(336, 88, true);
            WriteLiteral(" </h1>\r\n\r\n<h2>Customers:</h2>\r\n<p>\r\n    <a href=\"/People/Create/\">Create New</a>\r\n</p>\r\n");
            EndContext();
#line 20 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(454, 31, true);
            WriteLiteral("    <p>\r\n        Find by name: ");
            EndContext();
            BeginContext(486, 28, false);
#line 23 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
                 Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(514, 60, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            EndContext();
#line 26 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(577, 88, true);
            WriteLiteral("<div>\r\n    <table class=\"tab-content\" style=\"width:70%\">\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(666, 42, false);
#line 30 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(708, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(732, 74, false);
#line 31 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Name", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(806, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(830, 39, false);
#line 32 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.New));

#line default
#line hidden
            EndContext();
            BeginContext(869, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(1086, 16, true);
            WriteLiteral("            <th>");
            EndContext();
            BeginContext(1103, 41, false);
#line 36 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1168, 82, false);
#line 37 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Preparer", "Index", new { sortOrder = ViewBag.PreparerSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1274, 78, false);
#line 38 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Status", "Index", new { sortOrder = ViewBag.StatusSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 47, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2036, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2097, 41, false);
#line 63 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2206, 39, false);
#line 66 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2313, 38, false);
#line 69 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.New));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(2739, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2782, 40, false);
#line 81 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2890, 43, false);
#line 84 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Preparer));

#line default
#line hidden
            EndContext();
            BeginContext(2933, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3001, 41, false);
#line 87 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3111, "\"", 3142, 2);
            WriteAttributeValue("", 3118, "/People/Details/", 3118, 16, true);
#line 90 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3134, item.Id, 3134, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3143, 38, true);
            WriteLiteral(">Details</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3181, "\"", 3209, 2);
            WriteAttributeValue("", 3188, "/People/Edit/", 3188, 13, true);
#line 91 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3201, item.Id, 3201, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3210, 11, true);
            WriteLiteral(">Edit</a>\r\n");
            EndContext();
            BeginContext(3304, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 95 "C:\Users\grace\OneDrive\Documents\GitHub\TaxWebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3357, 4852, true);
            WriteLiteral(@"    </table>
</div>



<!-- Default Index Page Stuff
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <img src=""~/images/banner1.svg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how to build ASP.NET apps that can run anywhere.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner");
            WriteLiteral(@"2.svg"" alt=""Visual Studio"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    There are powerful new features in Visual Studio for building modern web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner3.svg"" alt=""Microsoft Azure"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </di");
            WriteLiteral(@"v>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core MVC</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Sec");
            WriteLiteral(@"rets using Secret Manager.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Overview</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview of what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=69");
            WriteLiteral(@"9321"">Client side development</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publish to Microsoft Azure Web Apps</a></li>
        </ul>
    </div>
</div>
-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaxWebApp.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
>>>>>>> Grace
