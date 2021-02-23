using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Domain.DTOs
{
    public class FiltroFuncionarioDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataInicioAdmissao { get; set; }
        public DateTime DataFimAdmissao { get; set; }
    }
}
