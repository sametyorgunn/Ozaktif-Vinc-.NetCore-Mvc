#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\HakkimizdaDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4bcc8fa16a399530947faca3f2a6de941c9ad40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Yonetim_HakkimizdaDuzenle), @"mvc.1.0.view", @"/Areas/Admin/Views/Yonetim/HakkimizdaDuzenle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bcc8fa16a399530947faca3f2a6de941c9ad40", @"/Areas/Admin/Views/Yonetim/HakkimizdaDuzenle.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Yonetim_HakkimizdaDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ozaktifvinc.Models.Hakkimizda>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\HakkimizdaDuzenle.cshtml"
  
    ViewData["Title"] = "HakkimizdaDuzenle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>HakkimizdaDuzenle</h1>\r\n\r\n<form method=\"post\" enctype=\"multipart/form-data\">\r\n \r\n     <div hidden class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">id</label>\r\n    <input type=\"text\" class=\"form-control col-sm-3\"");
            BeginWriteAttribute("value", " value=\"", 371, "\"", 388, 1);
#nullable restore
#line 13 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\HakkimizdaDuzenle.cshtml"
WriteAttributeValue("", 379, Model.Id, 379, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Id\" id=\"exampleInputPassword1\" placeholder=\"Bşlık\">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">Başlık</label>\r\n    <input type=\"text\" class=\"form-control col-sm-3\"");
            BeginWriteAttribute("value", " value=\"", 594, "\"", 615, 1);
#nullable restore
#line 17 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\HakkimizdaDuzenle.cshtml"
WriteAttributeValue("", 602, Model.Baslik, 602, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Baslik\" id=\"exampleInputPassword1\" placeholder=\"Bşlık\" required>\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label for=\"exampleInputPassword1\">İçerik</label>\r\n    <input type=\"text\" class=\"form-control col-sm-3\"");
            BeginWriteAttribute("value", " value=\"", 834, "\"", 855, 1);
#nullable restore
#line 21 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\HakkimizdaDuzenle.cshtml"
WriteAttributeValue("", 842, Model.Icerik, 842, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Icerik"" id=""exampleInputPassword1"" placeholder=""içerik"" required>
  </div>

  <div class=""form-group"">
    <label for=""exampleFormControlFile1"">Resim Yükle</label>
    <input type=""file"" name=""Resim"" class=""form-control-file"" id=""exampleFormControlFile1"" required>
  </div>
  <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
</form>


");
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