using Projeto04.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Interface
{
                                                           //<TEntity, TKey>
   public interface IDependenteRepository : IBaseRepository<Dependente, Guid>
    {
        
    }
}
