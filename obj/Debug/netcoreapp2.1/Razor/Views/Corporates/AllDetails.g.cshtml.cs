#pragma checksum "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659e56c872d0a2b3483c24ced69e2355b44c8730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Corporates_AllDetails), @"mvc.1.0.view", @"/Views/Corporates/AllDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Corporates/AllDetails.cshtml", typeof(AspNetCore.Views_Corporates_AllDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659e56c872d0a2b3483c24ced69e2355b44c8730", @"/Views/Corporates/AllDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62caf2104da4c237e370046ec6b798b2dec09c80", @"/Views/_ViewImports.cshtml")]
    public class Views_Corporates_AllDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaxWebApp.Models.Corporate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
  
    //get array of Corporates
    Corporate[] Corporates = (Corporate[])ViewData["corporatesArray"];

#line default
#line hidden
            BeginContext(145, 1070, true);
            WriteLiteral(@"
<style>
    /*
        Added some css from W3 schools to make the Data legible
    */
    .customizeTable {
        font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        .customizeTable td, .customizeTable th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        .customizeTable tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .customizeTable tr:hover {
            background-color: #ddd;
        }

        .customizeTable th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #4CAF50;
            color: white;
        }
</style>

<table class=""customizeTable"">
    <!--Now Displaying Data in a Table-->
    <tr>
        <th>Type</th>
        <th>Number</th>
        <th>Name</th>
        <th>New</th>
        <th>In</th>
        <th>Notes</th>
        <th>Status</t");
            WriteLiteral("h>\r\n        <th>Preparer</th>\r\n    </tr>\r\n\r\n\r\n");
            EndContext();
#line 53 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
     foreach (Corporate c in Corporates)
    {
        //Display the Array

#line default
#line hidden
            BeginContext(1293, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1324, 6, false);
#line 57 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1330, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1354, 8, false);
#line 58 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Number);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1386, 6, false);
#line 59 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1392, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1416, 5, false);
#line 60 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.New);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1445, 4, false);
#line 61 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.In);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1473, 7, false);
#line 62 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1504, 8, false);
#line 63 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1536, 10, false);
#line 64 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
           Write(c.Preparer);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\Corporates\AllDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(1575, 8, true);
            WriteLiteral("</table>");
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
