using Projeto04.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Interface
{    //
     // IBAseRepository o tipo generico <T> representa um cliente
                                                        //<TEntity, TKey>
    public interface IClienteRepository : IBaseRepository<Cliente, Guid>
    {

        // METODO PARA CONSULTAR 1 CLIENTE NO BANCO DE DADOS 
        // ATRAVEZ DO SEU CPF.. (RETORNA UM UNICO REGISTRO)
        Cliente ConsultarPorCpf(string Cpf);
    }
}
