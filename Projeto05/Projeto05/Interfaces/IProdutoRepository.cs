using Projeto05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Interfaces
{
  public interface IProdutoRepository
      : IBaseRepository<Produto, Guid>
  {

  }
}
