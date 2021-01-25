using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
   public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
