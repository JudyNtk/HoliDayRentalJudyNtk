#pragma checksum "C:\Users\judyn\OneDrive\Documenten\ASP_NET\HoliDayRentalJudyNtk\HomeShare\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c076d7e4111fa054197d22c8da6afa38ad72c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c076d7e4111fa054197d22c8da6afa38ad72c63", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ec440af546b1b6c6b7a1f8957a659d6e5c2f9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Modal -->\r\n");
            WriteLiteral("\r\n<div id=\"loginpop\" >\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 login\">\r\n                    <h4>Enregistrez-vous</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c076d7e4111fa054197d22c8da6afa38ad72c634522", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputNom"">Nom</label>
                            <input type=""text"" class=""form-control"" id=""exampleInputNom"" placeholder=""Smith"">
                        </div>
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputPrenom"">Prenom</label>
                            <input type=""text"" class=""form-control"" id=""exampleInputPrenom"" placeholder=""Jhon"">
                        </div>
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputEmail2"">E-mail</label>
                            <input type=""email"" class=""form-control"" id=""exampleInputEmail2"" placeholder=""jhon@example.com"">
                        </div>
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputTel"">Téléphone</label>
              ");
                WriteLiteral(@"              <input type=""text"" class=""form-control"" id=""exampleInputTel"" placeholder=""555-563698"">
                        </div>
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputPassword2"">Mot de passe</label>
                            <input type=""password"" class=""form-control"" id=""exampleInputPassword2"" placeholder=""Mot de passe"">
                        </div>
                        <div class=""form-group"">
                            <label class=""sr-only"" for=""exampleInputPassword2"">Répétez le Mot de passe</label>
                            <input type=""password"" class=""form-control"" id=""exampleInputPassword2"" placeholder=""Répétez le Mot de passe"">
                        </div>
                        <div class=""checkbox"">
                            <label>
                                <input type=""checkbox""> J'accepte les <a href=""./Home/conditions"">condition générale du site</a>
                            </l");
                WriteLiteral("abel>\r\n                        </div>\r\n                        <button type=\"submit\" class=\"btn btn-success\">Connexion</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- /.modal -->");
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