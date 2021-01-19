using Projeto02.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Entities
{
   public class Funcionario : Pessoa
    {       
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmicao { get; set; }

        #region ASSOCIAÇÕES DE SETOR, FUNCAO E ENUMS

        public SituacaoFuncionario Situacao { get; set; } //criando a Associação entre funcionario e Enums de Situação
        public Setor Setor { get; set; }//criando a Associação entre funcionario e Setor

        public Funcao Funcao { get; set; } //criando a Associação entre funcionario e Funcao

        
        #endregion

    }
}
