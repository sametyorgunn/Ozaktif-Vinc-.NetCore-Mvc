#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddbeb81aba71fbc2457f93c6e6e7839d718fc9ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Yonetim_TagsEkle), @"mvc.1.0.view", @"/Areas/Admin/Views/Yonetim/TagsEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddbeb81aba71fbc2457f93c6e6e7839d718fc9ee", @"/Areas/Admin/Views/Yonetim/TagsEkle.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Yonetim_TagsEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ozaktifvinc.Models.MetaTag>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml"
  
    ViewData["Title"] = "TagsEkle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<form method=\"post\" enctype=\"multipart/form-data\">\r\n\r\n    <div hidden class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Id</label>\r\n        <input type=\"text\" class=\"form-control col-sm-3\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 347, "\"", 364, 1);
#nullable restore
#line 12 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml"
WriteAttributeValue("", 355, Model.Id, 355, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"exampleInputPassword1\">\r\n    </div>\r\n     <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Title</label>\r\n        <input type=\"text\" class=\"form-control col-sm-3\" name=\"Title\"");
            BeginWriteAttribute("value", " value=\"", 565, "\"", 585, 1);
#nullable restore
#line 16 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml"
WriteAttributeValue("", 573, Model.Title, 573, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Content</label>\r\n        <input type=\"text\" class=\"form-control col-sm-3\" name=\"Content\"");
            BeginWriteAttribute("value", " value=\"", 762, "\"", 784, 1);
#nullable restore
#line 20 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml"
WriteAttributeValue("", 770, Model.Content, 770, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Keywords</label>\r\n        <input type=\"text\" class=\"form-control col-sm-3\"");
            BeginWriteAttribute("value", " value=\"", 947, "\"", 969, 1);
#nullable restore
#line 24 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\TagsEkle.cshtml"
WriteAttributeValue("", 955, Model.Keyword, 955, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Keyword\">\r\n    </div>\r\n    <br />\r\n    <button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ozaktifvinc.Models.MetaTag> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
