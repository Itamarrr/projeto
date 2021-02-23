#pragma checksum "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d381d39da7436b5c836d101ff1be523210ed97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Consulta), @"mvc.1.0.view", @"/Views/Funcionario/Consulta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d381d39da7436b5c836d101ff1be523210ed97", @"/Views/Funcionario/Consulta.cshtml")]
    public class Views_Funcionario_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoMVC01.Presentation.Models.FuncionarioConsultaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Consulta de funcionários</h5>\r\n<p>Preencha os campos abaixo para pesquisar funcionários.</p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 12 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <label>Nome do Funcionário:</label>\r\n            ");
#nullable restore
#line 17 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.Nome,
                new
                {
                    @class = "form-control",
                    @placeholder = "Ex: João da Silva"
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label>CPF:</label>\r\n            ");
#nullable restore
#line 26 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.Cpf,
                new
                {
                    @class = "form-control",
                    @placeholder = "Ex: 99999999999"
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label>Matrícula:</label>\r\n            ");
#nullable restore
#line 35 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.Matricula,
                new
                {
                    @class = "form-control",
                    @placeholder = "Ex: 99999"
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label>Admitidos de:</label>\r\n            ");
#nullable restore
#line 44 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.DataInicioAdmissao,
                new
                {
                    @class = "form-control",
                    @type = "date"
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            <label>Admitidos até:</label>\r\n            ");
#nullable restore
#line 53 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(Html.TextBoxFor(model => model.DataFimAdmissao,
                new
                {
                    @class = "form-control",
                    @type = "date"
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Pesquisar Funcionários\"\r\n           class=\"btn btn-success\" />\r\n");
#nullable restore
#line 66 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<!-- Exibindo o resultado da consulta de funcionarios -->\r\n");
#nullable restore
#line 71 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
 if (Model != null && Model.Funcionarios != null && Model.Funcionarios.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table id=""tabela"" class=""table table-bordered table-striped table-hover table-light mt-4"">
        <thead>
            <tr>
                <th>Nome do Funcionário</th>
                <th>CPF</th>
                <th>Matrícula</th>
                <th>Data de Admissão</th>
                <th>Empresa</th>
                <th>CNPJ</th>
                <th width=""180"">Operações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 86 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
             foreach (var item in Model.Funcionarios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 89 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.Matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.DataAdmissao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.RazaoSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 94 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                   Write(item.Cnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2986, "\"", 3035, 2);
            WriteAttributeValue("", 2993, "/Funcionario/Edicao?id=", 2993, 23, true);
#nullable restore
#line 96 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
WriteAttributeValue("", 3016, item.IdFuncionario, 3016, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                           class=\"btn btn-primary btn-sm\">\r\n                            Atualizar\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3194, "\"", 3245, 2);
            WriteAttributeValue("", 3201, "/Funcionario/Exclusao?id=", 3201, 25, true);
#nullable restore
#line 100 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
WriteAttributeValue("", 3226, item.IdFuncionario, 3226, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 3246, "\"", 3349, 7);
            WriteAttributeValue("", 3284, "return", 3284, 6, true);
            WriteAttributeValue(" ", 3290, "window.confirm(\'Deseja", 3291, 23, true);
            WriteAttributeValue(" ", 3313, "excluir", 3314, 8, true);
            WriteAttributeValue(" ", 3321, "o", 3322, 2, true);
            WriteAttributeValue(" ", 3323, "funcionário", 3324, 12, true);
#nullable restore
#line 101 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
WriteAttributeValue(" ", 3335, item.Nome, 3336, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3346, "?\')", 3346, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                           class=\"btn btn-danger btn-sm\">\r\n                            Excluir\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 107 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"7\">Quantidade de funcionários: ");
#nullable restore
#line 111 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
                                                       Write(Model.Funcionarios.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 115 "C:\Itamarc#Projeto1\projeto\ProjetoMVC01\ProjetoMVC01.Presentation\Views\Funcionario\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoMVC01.Presentation.Models.FuncionarioConsultaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591