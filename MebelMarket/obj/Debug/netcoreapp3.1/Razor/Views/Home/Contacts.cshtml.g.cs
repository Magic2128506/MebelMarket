#pragma checksum "C:\Users\Magic\Documents\Бизнес\Мебельный магазин Ильнур\MebelMarket\MebelMarket\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "967cf066bc65f051f3985b7be0530802670e9c66"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"967cf066bc65f051f3985b7be0530802670e9c66", @"/Views/Home/Contacts.cshtml")]
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
</div>
<div class=""contact-section"" style=""margin-top: 15px; margin-bottom: 30px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""contact-details-wrapper section-top-gap-100"">
                    <div class=""contact-details"">
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
       ");
            WriteLiteral(@"                         <i class=""fa fa-phone""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <a href=""tel:(+7)9373216103"">+7-937-321-61-03</a>
                            </div>
                        </div>
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-globe""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <a href=""mailto:mebelyanaul@gmail.com"">mebelyanaul@gmail.com</a>
                            </div>
                        </div>

                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-map-marker""></i>
                            ");
            WriteLiteral(@"</div>
                            <div class=""contact-details-content contact-phone"">
                                <span>г. Уфа</span>
                                <span>ул. Инициативная, д. 1/1</span>
                            </div>
                        </div>
                        <div class=""contact-details-single-item"">
                            <div class=""contact-details-icon"">
                                <i class=""fa fa-map-marker""></i>
                            </div>
                            <div class=""contact-details-content contact-phone"">
                                <span>г. Янаул</span>
                                <span>ул. Маяковского, д. 14/3</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
