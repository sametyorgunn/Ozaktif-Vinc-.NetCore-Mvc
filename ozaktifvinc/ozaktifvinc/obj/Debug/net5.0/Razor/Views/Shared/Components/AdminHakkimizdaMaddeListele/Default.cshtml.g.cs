#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a13217834ec7950907672d3842a4e807ceebdd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminHakkimizdaMaddeListele_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminHakkimizdaMaddeListele/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a13217834ec7950907672d3842a4e807ceebdd4", @"/Views/Shared/Components/AdminHakkimizdaMaddeListele/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1fb29b689dbbfaf2709e9e0b4c85d43222e00f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AdminHakkimizdaMaddeListele_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ozaktifvinc.Models.HakkimizdaMaddeler>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th hidden scope=\"col\">#</th>\r\n      <th scope=\"col\">Başlık</th>\r\n      <th scope=\"col\">içerik</th>\r\n      <th scope=\"col\">Düzenle</th>\r\n      <th scope=\"col\">Sil</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
      foreach(var i in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th hidden scope=\"row\">");
#nullable restore
#line 17 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
                        Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 18 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
     Write(i.MaddeBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 19 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
     Write(i.Madde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("      <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 641, 2);
            WriteAttributeValue("", 602, "/Admin/Yonetim/HakkimizdaMaddeSil/", 602, 34, true);
#nullable restore
#line 21 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
WriteAttributeValue("", 636, i.Id, 636, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaMaddeListele\Default.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
