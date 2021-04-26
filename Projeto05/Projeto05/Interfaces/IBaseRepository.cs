using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Interfaces
{
  public interface IBaseRepository<TEntity, TKey>
      where TEntity : class
      where TKey : struct
  {
    void Inserir(TEntity obj);
    void Alterar(TEntity obj);
    void Excluir(TEntity obj);

    List<TEntity> ObterTodos();
    TEntity ObterPorId(TKey id);
  }
}


