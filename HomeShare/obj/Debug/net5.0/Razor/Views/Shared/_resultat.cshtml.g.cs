#pragma checksum "C:\Users\judyn\OneDrive\Documenten\ASP_NET\HoliDayRentalJudyNtk\HomeShare\Views\Shared\_resultat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92175a3e0abaf43a2972f4fb88744698bf2d61db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__resultat), @"mvc.1.0.view", @"/Views/Shared/_resultat.cshtml")]
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
#line 1 "C:\Users\judyn\OneDrive\Documenten\ASP_NET\HoliDayRentalJudyNtk\HomeShare\Views\_ViewImports.cshtml"
using HoliDayRental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\judyn\OneDrive\Documenten\ASP_NET\HoliDayRentalJudyNtk\HomeShare\Views\_ViewImports.cshtml"
using HoliDayRental.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\judyn\OneDrive\Documenten\ASP_NET\HoliDayRentalJudyNtk\HomeShare\Views\_ViewImports.cshtml"
using HoliDayRental.Infrastructure.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92175a3e0abaf43a2972f4fb88744698bf2d61db", @"/Views/Shared/_resultat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ec440af546b1b6c6b7a1f8957a659d6e5c2f9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__resultat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""inside-banner"">
    <div class=""container"">
        <span class=""pull-right""><a href=""/Home/Index"">Home</a> / Recherche</span>
        <h2>Résultat de la recherche</h2>
    </div>
</div>
<!-- banner -->


<div class=""container"">
    <div class=""spacer agents"">
    <div class=""searchbar"">
      <div class=""row"">
        <div class=""col-lg-6 col-sm-6"">
          <input type=""text"" class=""form-control"" placeholder=""mots clés"">
          <div class=""row"">
            <div class=""col-lg-3 col-sm-3 "">
              <select class=""form-control"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92175a3e0abaf43a2972f4fb88744698bf2d61db4000", async() => {
                WriteLiteral("Maison");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92175a3e0abaf43a2972f4fb88744698bf2d61db4974", async() => {
                WriteLiteral("Appartement");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92175a3e0abaf43a2972f4fb88744698bf2d61db5953", async() => {
                WriteLiteral("Studio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              </select>
            </div>
            
              <div class=""col-lg-3 col-sm-4"">
              <button class=""btn btn-success""  onclick=""window.location.href='/Search/Index'"">Rechercher</button>
              </div>
          </div>
          
          
        </div>
       </div>  
      </div>
      </div>
    <div class=""spacer Propriete"">

        <div class=""row"">
            <div>
                <div class=""row"">
                    <div class=""col-lg-3 col-sm-3 ""><a href=""#""><img src=""/images/properties/1.jpg"" class=""img-responsive"" alt=""agent name""></a></div>
                    <div class=""col-lg-4 col-sm-4 "">
                        <h4>Royal Inn</h4>
                        <p>Une grande piscine et un magnifique jardin.</p>
                        <div class=""listing-detail""><span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Chiens admis""><img src=""/images/icones/chien.png"" width=""25"" /></span> <span data-toggle=""tooltip"" data-pl");
            WriteLiteral(@"acement=""bottom"" data-original-title=""Lit double""><img src=""/images/icones/chambre.png"" width=""25"" /></span> <span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Parking""><img src=""/images/icones/parking.png"" width=""25"" /></span> <span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Cuisine""><img src=""/images/icones/ustensiles-de-cuisine.png"" width=""25"" /></span> </div>

                    </div>
                    <div class=""col-lg-3 col-sm-3 "">
                        <span class=""glyphicon glyphicon-map-marker""></span> 1200 Bruxelles <img src=""/images/icones/belgique.png"" width=""30"" /><br>
                        <span class=""glyphicon glyphicon-earphone""></span> (9009) 899 889
                        <a class=""btn btn-primary"" href=""#"">Détails</a>
                    </div>
                    <div class=""col-lg-2 col-sm-2 "">
                        <div id=""map"" class=""minimap""></div>
                        <script>
                            var map");
            WriteLiteral(@" = L.map('map').setView([50.499527, 4.475402500000001], 13);
                            L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', 
                            {
                                attribution: 'HoliDayRental &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                                maxZoom: 18,
                                id: 'mapbox/streets-v11',
                                tileSize: 512,
                                zoomOffset: -1,
                                accessToken: 'pk.eyJ1IjoibWlrZXBlcnNvbjI1MSIsImEiOiJjanlwc3cweHkxYjNsM21xZjl2Y2d2bXRvIn0.edBkKpFNjEvTZ2MbijICKA'
                            }).addTo(map);
                        </script>
                    </div>
                </div>

            </div>
        </div>
        <div class=""row"">
            <div>
                <div class=""row"">");
            WriteLiteral(@"
                    <div class=""col-lg-3 col-sm-3 ""><a href=""#""><img src=""/images/properties/3.jpg"" class=""img-responsive"" alt=""agent name""></a></div>
                    <div class=""col-lg-4 col-sm-4 "">
                        <h4>Smart House</h4>
                        <p>Une grande maison avec vue sur BigBen.</p>
                        <div class=""listing-detail""> <span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Lit double""><img src=""/images/icones/chambre.png"" width=""25"" /></span> <span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Parking""><img src=""/images/icones/parking.png"" width=""25"" /></span> <span data-toggle=""tooltip"" data-placement=""bottom"" data-original-title=""Piscine""><img src=""/images/icones/piscine.png"" width=""25"" /></span> </div>

                    </div>
                    <div class=""col-lg-3 col-sm-3 "">
                        <span class=""glyphicon glyphicon-map-marker""></span> EC2P 2E Londres <img src=""/images/icones/Angleterre");
            WriteLiteral(@".png"" width=""30"" /><br>
                        <span class=""glyphicon glyphicon-earphone""></span> (9009) 899 889
                        <a class=""btn btn-primary"" href=""#"">Détails</a>
                    </div>
                    <div class=""col-lg-2 col-sm-2 "">
                        <div id=""map2"" class=""minimap""></div>
                        <script>
                            var map2 = L.map('map2').setView([51.505, -0.09], 13);
                            L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', 
                            {
                                attribution: 'HoliDayRental &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                                maxZoom: 18,
                                id: 'mapbox/streets-v11',
                                tileSize: 512,
                                zoomOffset: -1,
    ");
            WriteLiteral(@"                            accessToken: 'pk.eyJ1IjoibWlrZXBlcnNvbjI1MSIsImEiOiJjanlwc3cweHkxYjNsM21xZjl2Y2d2bXRvIn0.edBkKpFNjEvTZ2MbijICKA'
                            }).addTo(map2);
                        </script>
                    </div>
                </div>

            </div>
        </div>

    </div>
</div>
");
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