using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Interface
{
   public interface IBaseRepository<TEntity, TKey> // SE A INTERFACE TIVER INICIADO COM IBase SIGNIFICA QUE ELA É PAI 
    where TEntity : class
    {
        
        // METODO ABSTRATO A INTERFACE O METODO TEM QUE SER ABSTRATO OU SEJA NÃO TRATA NADA É UMA ASSINATURA
        void Inserir(TEntity obj);
        void Alterar(TEntity obj);
        void Excluir(TEntity obj);
        List<TEntity> Consultar();
        TEntity ObterPorId(TKey id);
    }
}
