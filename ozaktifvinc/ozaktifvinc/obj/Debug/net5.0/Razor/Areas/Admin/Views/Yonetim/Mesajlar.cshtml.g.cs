#pragma checksum "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9665b41b9cc1feb852086fecea3aa1253b615c67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Yonetim_Mesajlar), @"mvc.1.0.view", @"/Areas/Admin/Views/Yonetim/Mesajlar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9665b41b9cc1feb852086fecea3aa1253b615c67", @"/Areas/Admin/Views/Yonetim/Mesajlar.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Yonetim_Mesajlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ozaktifvinc.Models.IletisimMesaj>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
  
    ViewData["Title"] = "Mesajlar";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9665b41b9cc1feb852086fecea3aa1253b615c673007", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.6.1.js\" integrity=\"sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h4>Mesajlar</h4>


<table class=""table"">
  <thead>
    <tr>
      <th hidden scope=""col"">#</th>
      <th scope=""col"">adı</th>
      <th scope=""col"">Mail</th>
      <th scope=""col"">tel</th>
      <th scope=""col"">Mesajı</th>
      <th scope=""col"">görüntüle</th>
      <th scope=""col"">Sil</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 27 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
      foreach(var i in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th hidden scope=\"row\">");
#nullable restore
#line 30 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
                        Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 31 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
     Write(i.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
     Write(i.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 33 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
      Write(i.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td class=\"mesaj\"");
            BeginWriteAttribute("value", " value=\"", 847, "\"", 863, 1);
#nullable restore
#line 34 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
WriteAttributeValue("", 855, i.Mesaj, 855, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
                                     Write(i.Mesaj.Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th><button class=\"btn btn-primary goruntule\">Görüntüle</button></th>\r\n      <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1046, 2);
            WriteAttributeValue("", 1017, "/Admin/Yonetim/MesajSil/", 1017, 24, true);
#nullable restore
#line 36 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
WriteAttributeValue("", 1041, i.Id, 1041, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 38 "C:\Users\asame\source\repos\ozaktifvinc\ozaktifvinc\Areas\Admin\Views\Yonetim\Mesajlar.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n\r\n<script>\r\n$(\".goruntule\").click(function() {\r\n    var mesaj = $(this).parent().parent().find(\".mesaj\").attr(\"value\")\r\n    alert(\"Kişinin Mesajı :\" + mesaj)\r\n})\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ozaktifvinc.Models.IletisimMesaj>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
