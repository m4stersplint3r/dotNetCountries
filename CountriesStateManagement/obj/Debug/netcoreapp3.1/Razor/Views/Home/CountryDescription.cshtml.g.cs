#pragma checksum "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d72ff9ca08b2d158988d9bbeae2ee07c3e99cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CountryDescription), @"mvc.1.0.view", @"/Views/Home/CountryDescription.cshtml")]
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
#nullable restore
#line 1 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\_ViewImports.cshtml"
using CountriesStateManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\_ViewImports.cshtml"
using CountriesStateManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d72ff9ca08b2d158988d9bbeae2ee07c3e99cdb", @"/Views/Home/CountryDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fe98b1ed461907682597f2422df1c222cfae82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CountryDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDescription.cshtml"
  
    ViewData["Title"] = "CountryDescription";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>CountryDescription</h1>\r\n<h3>");
#nullable restore
#line 6 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDescription.cshtml"
Write(TempData["description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
