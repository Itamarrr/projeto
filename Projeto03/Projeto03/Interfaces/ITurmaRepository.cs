using Projeto03.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Interfaces
{
  public  interface ITurmaRepository
    {
        // METODOS ABSTRATOS SÃO METODOS QUE NÃO POSSUEM CORPO APENAS ASSINATURA
        void Exportar(Turma turma); //Meu metodo exportar esta recebendo um objeto turma  Tipo do objeto Turma uma variavel turma recebendo 
    }
}
