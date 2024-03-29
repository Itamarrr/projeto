using Dapper;
using Projeto05.Entities;
using Projeto05.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto05.Repositories
{
  public class ItemPedidoRepository : IItemPedidoRepository
  {
    private string connectionstring;

    public ItemPedidoRepository(string connectionstring)
    {
      this.connectionstring = connectionstring;
    }

    public void Inserir(ItemPedido obj)
    {
      var query = @"
                            INSERT INTO ITEMPEDIDO(IDITEMPEDIDO, IDPEDIDO, IDPRODUTO, QUANTIDADE)
                            VALUES(@IdItemPedido, @IdPedido, @IdProduto, @Quantidade)
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Alterar(ItemPedido obj)
    {
      var query = @"
                            UPDATE ITEMPEDIDO
                            SET
                                IDPEDIDO = @IdPedido,
                                IDPRODUTO = @IdProduto,
                                QUANTIDADE = @quantidade
                            WHERE
                                IDITEMPEDIDO = @IdItemPedido
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Excluir(ItemPedido obj)
    {
      var query = @"
                            DELETE FROM ITEMPEDIDO
                            WHERE IDITEMPEDIDO = @IdItemPedido
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public List<ItemPedido> ObterTodos()
    {
      var query = @"
                            SELECT * FROM ITEMPEDIDO                            
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
                .Query<ItemPedido>(query)
                .ToList();
      }
    }

    public ItemPedido ObterPorId(Guid id)
    {
      var query = @"
                            SELECT * FROM ITEMPEDIDO   
                            WHERE IDITEMPEDIDO = @id
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
                .Query<ItemPedido>(query, new { id })
                .FirstOrDefault();
      }
    }
  }
}
