#pragma checksum "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf1075de32f56cbcf22cc0da39eb2fa96ad466a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_View), @"mvc.1.0.view", @"/Views/ContaLuz/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/View.cshtml", typeof(AspNetCore.Views_ContaLuz_View))]
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
#line 1 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/_ViewImports.cshtml"
using Proj.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf1075de32f56cbcf22cc0da39eb2fa96ad466a", @"/Views/ContaLuz/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9cc475dedf69725ad704917a7b52ecccd00cef", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj.Domain.Entities.ContaLuz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(37, 267, true);
            WriteLiteral(@"
<h2 class=""text-center"">Contas de Luz</h2>

<div class=""form-group col-12 col-sm-8 col-md-6 mx-auto"">
    <div class=""editor-label"">
        Imovel
    </div>
    <div class=""editor-field"">
        <select class=""form-control"" name=""imovel.id"" required>
            ");
            EndContext();
            BeginContext(304, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bf1075de32f56cbcf22cc0da39eb2fa96ad466a3673", async() => {
                BeginContext(330, 18, true);
                WriteLiteral("Selecione o Imovel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(357, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
             foreach(var imovel in ViewBag.Imoveis)
            {

#line default
#line hidden
            BeginContext(424, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(440, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bf1075de32f56cbcf22cc0da39eb2fa96ad466a5691", async() => {
                BeginContext(512, 20, false);
#line 14 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                                                                  Write(imovel.identificacao);

#line default
#line hidden
                EndContext();
                BeginContext(532, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(536, 13, false);
#line 14 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                                                                                          Write(imovel.cidade);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 14 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                   WriteLiteral(imovel.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
AddHtmlAttributeValue("", 477, @imovel.id == Model.imovel.id, 477, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(558, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
            }

#line default
#line hidden
            BeginContext(573, 200, true);
            WriteLiteral("        </select>   \n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Leitura\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(774, 99, false);
#line 25 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
   Write(Html.EditorFor(model => model.dataLeitura, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(873, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(919, 53, false);
#line 26 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataLeitura));

#line default
#line hidden
            EndContext();
            BeginContext(972, 184, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        KW Gasto\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1157, 95, false);
#line 35 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
   Write(Html.EditorFor(model => model.kwGasto, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1298, 49, false);
#line 36 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.kwGasto));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 189, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Valor a pagar\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1537, 99, false);
#line 45 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
   Write(Html.EditorFor(model => model.valorAPagar, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1682, 53, false);
#line 46 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.valorAPagar));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 190, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Pagamento\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1926, 101, false);
#line 55 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
   Write(Html.EditorFor(model => model.dataPagamento, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2073, 55, false);
#line 56 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 192, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Média de Consumo\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(2321, 100, false);
#line 65 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
   Write(Html.EditorFor(model => model.mediaConsumo, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2467, 54, false);
#line 66 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.mediaConsumo));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 157, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"d-block text-center\">\n    <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Atualizar</button>\n\n    ");
            EndContext();
            BeginContext(2679, 93, false);
#line 73 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/Correções2019-2/CSharp-TrabalhoG2-Api-master/Proj.Web/Views/ContaLuz/View.cshtml"
Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(2772, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj.Domain.Entities.ContaLuz> Html { get; private set; }
    }
}
#pragma warning restore 1591
