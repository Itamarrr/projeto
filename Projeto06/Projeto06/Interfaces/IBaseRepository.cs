using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.Interfaces
{
  /// <summary>
  /// Interface genérica para operações de repositorio de dados
  /// </summary>
  public interface IBaseRepository<TEntity>
      where TEntity : class
  {
    void Exportar(TEntity obj);
  }
}
