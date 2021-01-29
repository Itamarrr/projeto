using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Entities
{
   public class Cliente
    {
        #region Propriedades do Cliente
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        //RELACIONAMENTOS (TER N) OU SEJA CLIENTE ESTA REALACIONADO COM O DEPENDENTE PODE TER VARIOS DEPENDNETE 
        public List<Dependente> Dependentes { get; set; }
        #endregion

    }
}
