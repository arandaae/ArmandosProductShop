#pragma checksum "F:\Repos\ArmandosProductShop\ArmandosProductShop\Views\Cart\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0795832aef1cfaec49b84bd519bcafb9f2cecce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Add), @"mvc.1.0.view", @"/Views/Cart/Add.cshtml")]
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
#line 1 "F:\Repos\ArmandosProductShop\ArmandosProductShop\Views\_ViewImports.cshtml"
using ArmandosProductShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Repos\ArmandosProductShop\ArmandosProductShop\Views\_ViewImports.cshtml"
using ArmandosProductShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0795832aef1cfaec49b84bd519bcafb9f2cecce9", @"/Views/Cart/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b2254f6af17ca50395fd808d2d39bf581cc748", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Repos\ArmandosProductShop\ArmandosProductShop\Views\Cart\Add.cshtml"
  
    ViewBag.Title = "Your Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Your Cart</h1>\r\n<p>You added ");
#nullable restore
#line 6 "F:\Repos\ArmandosProductShop\ArmandosProductShop\Views\Cart\Add.cshtml"
        Write(ViewBag.ProductSlug);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to your cart</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
