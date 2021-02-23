using ProjetoMVC01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //biblioteca para validação
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Presentation.Models
{
    public class EmpresaConsultaViewModel
    {
        //validação de minimo de caracteres exigido no campo..
        [MinLength(2, ErrorMessage = "Por favor, Informe no mínimo {1} caracteres.")]
        //validação de campo obrigatório (não pode ser vazio)
        [Required(ErrorMessage = "Por favor, informe a razão social desejada.")]
        public string RazaoSocial { get; set; } //campo do formulário

        //propriedade para exibir na página uma listagem de empresas..
        public List<Empresa> Empresas { get; set; }
    }
}
