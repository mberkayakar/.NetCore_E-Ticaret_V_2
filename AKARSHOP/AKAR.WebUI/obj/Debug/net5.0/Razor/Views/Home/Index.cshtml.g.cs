#pragma checksum "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d44492b139b227fbf3fa4d4fed8204e5ac49b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
using AKAR.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d44492b139b227fbf3fa4d4fed8204e5ac49b12", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ana Sayfaya Hoşgeldiniz :</h1>\r\n\r\n\r\n<br />\r\n<h2> ÜRÜNLER :</h2>\r\n<br />\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-3\"> KATEGORİLER BÖLÜMÜ</div>\r\n    <div class=\"col-3\">\r\n");
#nullable restore
#line 20 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
         foreach (var item in @Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem;\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 470, "\"", 490, 1);
#nullable restore
#line 23 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 476, item.ImageURL, 476, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n        <div class=\"card-body\">\r\n         <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n         <p class=\"card-text\"> ");
#nullable restore
#line 26 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br>\r\n         <p class=\"card-text\"> ");
#nullable restore
#line 27 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n         <a href=\"#\" class=\"btn btn-primary\">Daha Fazlası için</a>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Muhammed Berkay AKAR\Desktop\DotenetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
       
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
