using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // validações
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoMVC01.Presentation.Models
{
    public class FuncionarioEdicaoVewModel
    {
        public Guid IdFuncionario { get; set; } // campo oculto do funcionario...

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        //  não deixo alterar nem cpf nem matricula por ser unico
        //[RegularExpression("^[0-9]{11}$", ErrorMessage = "Por favor informe 11 dígitos numéricos.")]
        //[Required(ErrorMessage = "Por favor, informe o CPF do funcionário.")]
        //public string Cpf { get; set; }

        //[RegularExpression("^[A-Za-z0-9]{5,15}", ErrorMessage = "Por favor, preencha entre 5 e 15 caracteres alfanuméricos.")]
        //[Required(ErrorMessage = "Por favor, informe a matrícula do funcionário.")]
        //public string Matricula { get; set; }

        //[RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$", 
        //    ErrorMessage = "Data inválida.")]
        [Required(ErrorMessage = "Por favor, informe a data de admissão do funcionário.")]
        public string DataAdmissao { get; set; }

        [Required(ErrorMessage = "Por favor, selecione a empresa desejada.")]
        public string IdEmpresa { get; set; }

        #region DropDownList

        /*
            Campo utilizado para exibir na página um DropDownList que carregue
            todas as empresas obtidas do banco de dados.
         */
        public List<SelectListItem> ListagemDeEmpresas { get; set; }

        #endregion
    }
}
