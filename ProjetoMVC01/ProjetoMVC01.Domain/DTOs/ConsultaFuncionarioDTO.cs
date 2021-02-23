using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Domain.DTOs
{
    public class ConsultaFuncionarioDTO
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
    }
}
