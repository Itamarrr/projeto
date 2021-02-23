using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //validações

namespace ProjetoMVC01.Presentation.Models
{
    public class EmpresaEdicaoViewModel
    {
        //campo oculto no formulário..
        public Guid IdEmpresa { get; set; } //HIDDEN (campo oculto)

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, inforne a razão social da empresa.")]
        public string RazaoSocial { get; set; }
    }
}
