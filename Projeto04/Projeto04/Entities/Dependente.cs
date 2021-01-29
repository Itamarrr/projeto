using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Entities
{
    public class Dependente
    {
        #region Propriendades do dependente
        public Guid IdDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdCliente { get; set; }
        public Cliente Cliente { get; set; }// RELACIONAMENTO(TER -1) O DEPENDENTE ESTA RELACIONADO COM CLIENTE PODE CONTER APENAS UM CLIENTE 
        #endregion


    }
}
