#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671e5248f820d81cbc0795e95c7223cd0fc30718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminHakkimizdaListele_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminHakkimizdaListele/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671e5248f820d81cbc0795e95c7223cd0fc30718", @"/Views/Shared/Components/AdminHakkimizdaListele/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1fb29b689dbbfaf2709e9e0b4c85d43222e00f0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AdminHakkimizdaListele_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ozaktifvinc.Models.Hakkimizda>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table"">
  <thead>
    <tr>
      <th hidden scope=""col"">#</th>
      <th scope=""col"">Başlık</th>
      <th scope=""col"">İçerik</th>
      <th scope=""col"">Resim</th>
      <th scope=""col"">Düzenle</th>
      <th scope=""col"">Sil</th>
    </tr>
  </thead>
  <tbody>
     
    <tr>
      <th hidden scope=""row"">");
#nullable restore
#line 17 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 18 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
     Write(Model.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 19 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
              
                if(Model.Icerik.Length<=10)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 22 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
                   Write(Model.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <td>");
#nullable restore
#line 26 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
                    Write(Model.Icerik.Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("       <td><img");
            BeginWriteAttribute("src", " src=\"", 763, "\"", 805, 2);
            WriteAttributeValue("", 769, "/Resimler/Hakkimizda/", 769, 21, true);
#nullable restore
#line 30 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
WriteAttributeValue("", 790, Model.ResimYol, 790, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"20%\" /></td>\r\n      <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 861, "\"", 910, 2);
            WriteAttributeValue("", 868, "/Admin/Yonetim/HakkimizdaDuzenle/", 868, 33, true);
#nullable restore
#line 31 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
WriteAttributeValue("", 901, Model.Id, 901, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a></td>\r\n      <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1010, 2);
            WriteAttributeValue("", 972, "/Admin/Yonetim/HakkimizdaSil/", 972, 29, true);
#nullable restore
#line 32 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Views\Shared\Components\AdminHakkimizdaListele\Default.cshtml"
WriteAttributeValue("", 1001, Model.Id, 1001, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n    </tr>\r\n      \r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ozaktifvinc.Models.Hakkimizda> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
