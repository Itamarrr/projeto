using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
   public class Turma
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }

        //ASSOCIAÇÃO 
        public List<Aluno> Alunos { get; set; } // a relação é de um pra muitos conforme solicitado pelo cliente 1 turma tem n alunos

        public Professor Professor = new Professor();  // a relação seria de 1 pra 1 conforme solicitado pelo cliene 1 turma tem 1 professor

    }
}
