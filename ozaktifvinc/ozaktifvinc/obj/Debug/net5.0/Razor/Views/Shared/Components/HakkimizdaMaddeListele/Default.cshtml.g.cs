#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\HakkimizdaMaddeListele\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919e9ccbc8e33d00cdf16858096114609341cd92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HakkimizdaMaddeListele_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HakkimizdaMaddeListele/Default.cshtml")]
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
#line 1 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\_ViewImports.cshtml"
using ozaktifvinc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\_ViewImports.cshtml"
using ozaktifvinc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919e9ccbc8e33d00cdf16858096114609341cd92", @"/Views/Shared/Components/HakkimizdaMaddeListele/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1fb29b689dbbfaf2709e9e0b4c85d43222e00f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_HakkimizdaMaddeListele_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ozaktifvinc.Models.HakkimizdaMaddeler>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\HakkimizdaMaddeListele\Default.cshtml"
     foreach(var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"icon-box d-flex position-relative\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n    <i class=\"bi bi-easel flex-shrink-0\"></i>\r\n    <div>\r\n        <h4><a");
            BeginWriteAttribute("href", " href=\"", 252, "\"", 259, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"stretched-link\">");
#nullable restore
#line 8 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\HakkimizdaMaddeListele\Default.cshtml"
                                         Write(i.MaddeBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\HakkimizdaMaddeListele\Default.cshtml"
      Write(i.Madde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div><!-- End Icon Bo\r\n\r\nx -->\r\n");
#nullable restore
#line 14 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\HakkimizdaMaddeListele\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ozaktifvinc.Models.HakkimizdaMaddeler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
