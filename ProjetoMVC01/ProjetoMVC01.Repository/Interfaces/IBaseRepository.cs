using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMVC01.Repository.Interfaces
{
    //<T> definição de tipo genérico
    public interface IBaseRepository<T>
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);

        List<T> ObterTodos();
        T ObterPorId(Guid id);
    }
}
