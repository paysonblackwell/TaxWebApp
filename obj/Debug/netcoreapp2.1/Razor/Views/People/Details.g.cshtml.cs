#pragma checksum "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c72d1f775cbe0ec0f54f70ec3d4d9d6afeadf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Details), @"mvc.1.0.view", @"/Views/People/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Details.cshtml", typeof(AspNetCore.Views_People_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c72d1f775cbe0ec0f54f70ec3d4d9d6afeadf8", @"/Views/People/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c6a582af24dd9fcf635f671f82fb8c2104068b", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaxWebApp.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml"
  
    //get array of Persons
    Person[] people = (Person[])ViewData["peopleArray"];

#line default
#line hidden
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml"
 foreach (Person p in people)
{
    //Display the Array

#line default
#line hidden
            BeginContext(186, 24, true);
            WriteLiteral("    <h1>\r\n        Name: ");
            EndContext();
            BeginContext(211, 12, false);
#line 11 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml"
         Write(p.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(223, 30, true);
            WriteLiteral("\r\n        <br />\r\n        ID: ");
            EndContext();
            BeginContext(254, 4, false);
#line 13 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml"
       Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(258, 45, true);
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n    </h1>\r\n");
            EndContext();
#line 17 "C:\Users\cutte\Desktop\School\Fall2018\WebAppDevelopment\TaxWebApp\TaxWebApp\Views\People\Details.cshtml"
}

#line default
#line hidden
            BeginContext(306, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaxWebApp.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
