#pragma checksum "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb1548b2107a3bd5f79510e7b44f4c11b2c4b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chamado_Update), @"mvc.1.0.view", @"/Views/Chamado/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chamado/Update.cshtml", typeof(AspNetCore.Views_Chamado_Update))]
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
#line 1 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\_ViewImports.cshtml"
using AppChamados;

#line default
#line hidden
#line 2 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\_ViewImports.cshtml"
using AppChamados.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb1548b2107a3bd5f79510e7b44f4c11b2c4b88", @"/Views/Chamado/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630cd5493263a4d59f025f66932f33ad8b8e07ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Chamado_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppChamados.Domain.Chamado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 76, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h3>Editar Chamado</h3>\r\n\r\n    <br>\r\n\r\n    ");
            EndContext();
            BeginContext(111, 2467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d67fd56295594ac7887e87164db67344", async() => {
                BeginContext(147, 243, true);
                WriteLiteral("\r\n\r\n        <div class=\"col-md-5\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-12\">\r\n                <label for=\"cliente.id\">Cliente</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"cliente.id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 390, "\"", 417, 1);
#line 16 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 398, Model.cliente.nome, 398, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(418, 71, true);
                WriteLiteral(" readonly>\r\n                <input hidden type=\"text\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 489, "\"", 506, 1);
#line 17 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 497, Model.id, 497, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(507, 272, true);
                WriteLiteral(@"/>
            </div>                
        </div>

        <div class=""row"">
            <div class=""form-group col-md-12"">
                <label for=""descricao"">Descrição do Problema</label>
                <input class=""form-control"" rows=""5"" name=""descricao""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 779, "\"", 803, 1);
#line 24 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 787, Model.descricao, 787, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(804, 244, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"dataChamado\">Data</label>\r\n                <input class=\"form-control\" type=\"text\" name=\"dataChamado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1048, "\"", 1097, 1);
#line 31 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1056, Model.dataChamado.ToString("dd/MM/yyyy"), 1056, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1098, 215, true);
                WriteLiteral(" readonly>\r\n            </div>\r\n\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"horaInicio\">Hora Início</label>\r\n                <input class=\"form-control\" type=\"time\" name=\"horaInicio\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1313, "\"", 1338, 1);
#line 36 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1321, Model.horaInicio, 1321, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1339, 261, true);
                WriteLiteral(@" readonly>
            </div>
        </div>

        <div class=""row"">
            <div class=""form-group col-md-6"">
                <label for=""dataSolucao"">Data Solução</label>
                <input class=""form-control"" type=""date"" name=""dataSolucao""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1600, "\"", 1626, 1);
#line 43 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1608, Model.dataSolucao, 1608, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1627, 197, true);
                WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"horaFim\">Hora Fim</label>\r\n                <input class=\"form-control\" type=\"time\" name=\"horaFim\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1824, "\"", 1846, 1);
#line 48 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 1832, Model.horaFim, 1832, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1847, 240, true);
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label for=\"situacao.id\">Situação</label>\r\n                <select class=\"form-control\" name=\"situacao.id\">\r\n");
                EndContext();
#line 56 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
                     foreach(var situacao in @ViewBag.situacoes)
                    {

#line default
#line hidden
                BeginContext(2176, 25, true);
                WriteLiteral("                        <");
                EndContext();
                BeginContext(2202, 6, true);
                WriteLiteral("option");
                EndContext();
                BeginWriteAttribute("value", " value=", 2208, "", 2227, 1);
#line 58 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 2215, situacao.id, 2215, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("selected", " selected=\"", 2227, "\"", 2274, 1);
#line 58 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
WriteAttributeValue("", 2238, situacao.id == @Model.situacao.id, 2238, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2275, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2277, 18, false);
#line 58 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
                                                                                               Write(situacao.descricao);

#line default
#line hidden
                EndContext();
                BeginContext(2295, 2, true);
                WriteLiteral("</");
                EndContext();
                BeginContext(2298, 9, true);
                WriteLiteral("option>\r\n");
                EndContext();
#line 59 "C:\Users\Guilherme\Desktop\Workspace\lpc\atividades-lpc\trabalho-g1\AppChamados\Views\Chamado\Update.cshtml"
                    }

#line default
#line hidden
                BeginContext(2330, 241, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar Alterações\"/>\r\n        \r\n        <a href=\"Index\" class=\"btn btn-primary\">Voltar</a>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2578, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppChamados.Domain.Chamado> Html { get; private set; }
    }
}
#pragma warning restore 1591
