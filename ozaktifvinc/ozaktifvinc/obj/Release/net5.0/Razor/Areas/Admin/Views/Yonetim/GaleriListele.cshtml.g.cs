#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dacc5820af93ac51676f80d608aab5e412228a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Yonetim_GaleriListele), @"mvc.1.0.view", @"/Areas/Admin/Views/Yonetim/GaleriListele.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacc5820af93ac51676f80d608aab5e412228a10", @"/Areas/Admin/Views/Yonetim/GaleriListele.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Yonetim_GaleriListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ozaktifvinc.Models.Galeri>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 border-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sample Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
  
    ViewData["Title"] = "GaleriListele";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GaleriListele</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
 foreach(var i in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-6 col-md-4\">\r\n    <div class=\"card\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dacc5820af93ac51676f80d608aab5e412228a104090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 289, "~/Resimler/Galeri/", 289, 18, true);
#nullable restore
#line 14 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
AddHtmlAttributeValue("", 307, i.ResimYol, 307, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
                              Write(i.ResimYazi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 560, 2);
            WriteAttributeValue("", 526, "/Admin/Yonetim/GaleriDuzenle/", 526, 29, true);
#nullable restore
#line 19 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
WriteAttributeValue("", 555, i.Id, 555, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link btn btn-info\" btn btn-info>Düzenle</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 633, "\"", 670, 2);
            WriteAttributeValue("", 640, "/Admin/Yonetim/GaleriSil/", 640, 25, true);
#nullable restore
#line 20 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
WriteAttributeValue("", 665, i.Id, 665, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link btn btn-danger\">Sil</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\GaleriListele.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ozaktifvinc.Models.Galeri>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591