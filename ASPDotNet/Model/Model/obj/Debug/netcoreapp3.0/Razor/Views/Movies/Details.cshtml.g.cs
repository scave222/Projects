#pragma checksum "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d77964c86531bd3c30162e9cd0311f80f8c45f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\codebits-academy\ASPDotNet\Model\Model\Views\_ViewImports.cshtml"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\codebits-academy\ASPDotNet\Model\Model\Views\_ViewImports.cshtml"
using Model.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d77964c86531bd3c30162e9cd0311f80f8c45f3", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19dd824c0ca0679a362526c0b044f5e2ac888bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>
<div class=""text-center"">
    <h1>pass Array from Controller to view in ASP.Net Core MVC DEMO</h1>
    <table cellpadding=""0"" cellspacing=""0"" class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Movies Name</th>
                <th scope=""col"">Movies Type</th>
                <th scope=""col"">Year Release</th>

            </tr>
        </thead>
");
#nullable restore
#line 19 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
         foreach(MoviesModelArray movies in (MoviesModelArray[])ViewBag.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
               Write(movies.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
               Write(movies.MovieType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
               Write(movies.YearRelease);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <p>Date is ");
#nullable restore
#line 28 "C:\codebits-academy\ASPDotNet\Model\Model\Views\Movies\Details.cshtml"
          Write(ViewData["ServerTime"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n");
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
