#pragma checksum "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8219e972bc342be6af513d84b6e9d83b0355dd12"
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
#line 1 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
using AKAR.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8219e972bc342be6af513d84b6e9d83b0355dd12", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout/_anasayfa_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
 if(@Model.Products.Count==0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Layout/PartialView/_hicbirurunbulunamadi.cshtml"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
                                                                                              
}

else
{
     
     

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n     \r\n");
#nullable restore
#line 22 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
         foreach (var item in @Model.Products)
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/Layout/PartialView/_urunler_card.cshtml",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 30 "C:\Users\Muhammed Berkay AKAR\Desktop\DotnetCore E Ticaret V 2.0\AKARSHOP\AKAR.WebUI\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
