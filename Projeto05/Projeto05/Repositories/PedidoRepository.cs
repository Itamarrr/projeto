
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
  public class PedidoRepository : IPedidoRepository
  {
    private string connectionstring;

    public PedidoRepository(string connectionstring)
    {
      this.connectionstring = connectionstring;
    }

    public void Inserir(Pedido obj)
    {
      var query = @"
                        INSERT INTO PEDIDO(IDPEDIDO, IDCLIENTE, DATAPEDIDO)
                        VALUES(@IdPedido, @IdCliente, @DataPedido)
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Alterar(Pedido obj)
    {
      var query = @"
                        UPDATE PEDIDO
                        SET
                            IDCLIENTE = @IdCliente,
                            DATAPEDIDO = @DataPedido
                        WHERE
                            IDPEDIDO = @IdPedido
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Excluir(Pedido obj)
    {
      var query = @"
                        DELETE FROM PEDIDO
                        WHERE IDPEDIDO = @IdPedido
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public List<Pedido> ObterTodos()
    {
      var query = @"
                        SELECT * FROM PEDIDO
                        ORDER BY DATAPEDIDO
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
                .Query<Pedido>(query)
                .ToList();
      }
    }

    public Pedido ObterPorId(Guid id)
    {
      var query = @"
                        SELECT * FROM PEDIDO
                        WHERE IDPEDIDO = @id
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
                .Query<Pedido>(query, new { id })
                .FirstOrDefault();
      }
    }
  }
}
