#pragma checksum "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5aca8b30672d6e373f3263ff798b58490bf6ba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CountryDetails), @"mvc.1.0.view", @"/Views/Home/CountryDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5aca8b30672d6e373f3263ff798b58490bf6ba2", @"/Views/Home/CountryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fe98b1ed461907682597f2422df1c222cfae82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CountryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Country>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("CountryDescription"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
  
    ViewData["Title"] = "CountryDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>CountryDetails</h1>\r\n\r\n<h3>Name: ");
#nullable restore
#line 8 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Language: ");
#nullable restore
#line 9 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
         Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Greeting: ");
#nullable restore
#line 10 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
         Write(Model.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>\r\n    Colors:\r\n");
#nullable restore
#line 13 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
     foreach (var color in Model.NationalColors)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
    Write(color + " ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
                      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 18 "D:\Bootcamp\Labs\CountriesStateManagement\CountriesStateManagement\Views\Home\CountryDetails.cshtml"
  TempData["description"] = Model.Description;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5aca8b30672d6e373f3263ff798b58490bf6ba26014", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" name=\"View Details\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Country> Html { get; private set; }
    }
}
#pragma warning restore 1591