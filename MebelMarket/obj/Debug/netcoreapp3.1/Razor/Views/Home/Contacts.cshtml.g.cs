#pragma checksum "C:\Users\Magic\Documents\Бизнес\Мебельный магазин Ильнур\MebelMarket\MebelMarket\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff69eefd9721e2b9d26f4895bb329601011d596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
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
#line 1 "C:\Users\Magic\Documents\Бизнес\Мебельный магазин Ильнур\MebelMarket\MebelMarket\Views\_ViewImports.cshtml"
using MebelMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Magic\Documents\Бизнес\Мебельный магазин Ильнур\MebelMarket\MebelMarket\Views\_ViewImports.cshtml"
using MebelMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff69eefd9721e2b9d26f4895bb329601011d596", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d939970b9c2ba9417fa1caeecde2dadb6896b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Magic\Documents\Бизнес\Мебельный магазин Ильнур\MebelMarket\MebelMarket\Views\Home\Contacts.cshtml"
  
    ViewData["Title"] = $"Доставка - МебельМаркет";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""map-section"" style=""margin-top: 30px; margin-bottom: 15px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""mapouter"">
                    <div class=""gmap_canvas"">
                        <iframe src=""https://yandex.ru/map-widget/v1/?um=constructor%3A8a6e64acb6f9e762c9a8d122cf41cfb04bb9b8deb8a3b8038df6390bef0edc1d&amp;source=constructor"" width=""100%"" height=""400"" frameborder=""0""></iframe>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> <!-- ...::::End  Map Section:::... -->
<!-- ...::::Start Contact Section:::... -->
<div class=""contact-section"" style=""margin-top: 15px; margin-bottom: 30px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <!-- Start Contact Details -->
                <div class=""contact-details-wrapper section-top-gap-100"">
                    <div class=""contact-details"">
      ");
            WriteLiteral(@"                  <!-- Start Contact Details Single Item -->
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-phone""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <a href=""tel:(+7)9373216103"">+7-937-321-61-03</a>
                            </div>
                        </div> <!-- End Contact Details Single Item -->
                        <!-- Start Contact Details Single Item -->
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-globe""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <a href=""mailto:urname@email.com"">urname@email.com</");
            WriteLiteral(@"a>
                            </div>
                        </div> <!-- End Contact Details Single Item -->

                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-map-marker""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <span>г. Уфа</span>
                                <span>полный адрес</span>
                            </div>
                        </div>
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-map-marker""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <span>г. Янаул</span>
                                <span>полный а");
            WriteLiteral("дрес</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div> <!-- End Contact Details -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591