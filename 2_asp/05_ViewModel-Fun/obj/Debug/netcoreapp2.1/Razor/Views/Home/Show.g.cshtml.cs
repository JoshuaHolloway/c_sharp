#pragma checksum "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133c8a63cd3573a00484178350709ebb10de0c93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\_ViewImports.cshtml"
using _05_ViewModel_Fun;

#line default
#line hidden
#line 2 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\_ViewImports.cshtml"
using _05_ViewModel_Fun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133c8a63cd3573a00484178350709ebb10de0c93", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467f4a99f327b7c52e25d6278019b52c03021e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 527, true);
            WriteLiteral(@"<!-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -->
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<!-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -->
<style>
</style>
<!-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -->
<main>
    <a href=""/"">Home</a>

    <h4>Full Name:       ");
            EndContext();
            BeginContext(528, 12, false);
#line 10 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\Home\Show.cshtml"
                    Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(540, 32, true);
            WriteLiteral("</h4>\r\n    <h4>Location:        ");
            EndContext();
            BeginContext(573, 16, false);
#line 11 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\Home\Show.cshtml"
                    Write(ViewBag.location);

#line default
#line hidden
            EndContext();
            BeginContext(589, 32, true);
            WriteLiteral("</h4>\r\n    <h4>Language:        ");
            EndContext();
            BeginContext(622, 16, false);
#line 12 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\Home\Show.cshtml"
                    Write(ViewBag.language);

#line default
#line hidden
            EndContext();
            BeginContext(638, 32, true);
            WriteLiteral("</h4>\r\n    <h4>Comment:         ");
            EndContext();
            BeginContext(671, 15, false);
#line 13 "C:\dev\c_sharp\2_asp\05_ViewModel-Fun\Views\Home\Show.cshtml"
                    Write(ViewBag.comment);

#line default
#line hidden
            EndContext();
            BeginContext(686, 16, true);
            WriteLiteral("</h4>\r\n\r\n</main>");
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
