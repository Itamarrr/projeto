using System;
using System.Collections.Generic;
using System.Text;


namespace Projeto01.Entities  
{
   public class Cliente
    {
        //Gid ele entra altomaticamente para implementar um codigo que não se repete
        public Guid id { get; set; }   
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
