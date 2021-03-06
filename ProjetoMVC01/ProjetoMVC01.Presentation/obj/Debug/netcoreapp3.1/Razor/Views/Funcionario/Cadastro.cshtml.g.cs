#pragma checksum "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb36319440d23bb667104fb84b4aa4d7c5d82c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Cadastro), @"mvc.1.0.view", @"/Views/Funcionario/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb36319440d23bb667104fb84b4aa4d7c5d82c2", @"/Views/Funcionario/Cadastro.cshtml")]
    public class Views_Funcionario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoMVC01.Presentation.Models.FuncionarioCadastroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Formulário de cadastro de funcionário</h5>\r\n<p>Preencha os campos abaixo para cadastrar um funcionário.</p>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n\r\n");
#nullable restore
#line 15 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label>Nome do funcionário:</label>\r\n");
#nullable restore
#line 18 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
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
#line 25 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>CPF:</label>\r\n");
#nullable restore
#line 30 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.Cpf,
            new
            {
                @class = "form-control",
                @placeholder = "Ex: 99999999999"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 37 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>Matrícula:</label>\r\n");
#nullable restore
#line 42 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.Matricula,
            new
            {
                @class = "form-control",
                @placeholder = "Ex: 99999"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 49 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>Data de Admissão:</label>\r\n");
#nullable restore
#line 54 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
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
#line 61 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.DataAdmissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n");
            WriteLiteral("            <label>Selecione a empresa:</label>\r\n");
#nullable restore
#line 66 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
       Write(Html.DropDownListFor(model => model.IdEmpresa, Model.ListagemDeEmpresas,
                    "Escolha uma opção", new { @class = "form-select" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-danger\">\r\n                ");
#nullable restore
#line 69 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.IdEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br/>\r\n");
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-success\"\r\n                   value=\"Cadastrar Funcionário\"/>\r\n");
#nullable restore
#line 75 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Cadastro.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoMVC01.Presentation.Models.FuncionarioCadastroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
