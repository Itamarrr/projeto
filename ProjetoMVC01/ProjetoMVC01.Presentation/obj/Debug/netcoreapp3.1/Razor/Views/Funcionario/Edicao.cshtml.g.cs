#pragma checksum "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b29fd969185b1c77bab77f605d642a0a33de71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Edicao), @"mvc.1.0.view", @"/Views/Funcionario/Edicao.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b29fd969185b1c77bab77f605d642a0a33de71", @"/Views/Funcionario/Edicao.cshtml")]
    public class Views_Funcionario_Edicao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoMVC01.Presentation.Models.FuncionarioEdicaoVewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
  
    ViewData["Title"] = "Edicao";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Formulário de cadastro de funcionário</h5>\r\n<p>Preencha os campos abaixo para Atualizar os dados do funcionário.</p>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n\r\n");
#nullable restore
#line 15 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--CAMPO OCULTO Html.HiddenFor -->\r\n");
#nullable restore
#line 18 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
       Write(Html.HiddenFor(model => model.IdFuncionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label>Nome do funcionário:</label>\r\n");
#nullable restore
#line 21 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
       Write(Html.TextBoxFor(model => model.Nome,
            new
            {
                @class = "form-control",
                @placeholder = "Ex: João da Silva"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 28 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>Data de Admissão:</label>\r\n");
#nullable restore
#line 57 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
       Write(Html.TextBoxFor(model => model.DataAdmissao,
            new
            {
                @class = "form-control",
                @type = "date"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 64 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.DataAdmissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>Selecione a empresa:</label>\r\n");
#nullable restore
#line 69 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
       Write(Html.DropDownListFor(model => model.IdEmpresa, Model.ListagemDeEmpresas,
                    "Escolha uma opção", new { @class = "form-select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 72 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
           Write(Html.ValidationMessageFor(model => model.IdEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-primary\"\r\n                   value=\"Atualizar Funcionário\" />\r\n");
#nullable restore
#line 78 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Edicao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoMVC01.Presentation.Models.FuncionarioEdicaoVewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
