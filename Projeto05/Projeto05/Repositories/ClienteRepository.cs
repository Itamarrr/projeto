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
  public class ClienteRepository : IClienteRepository
  {
    private string connectionstring;

    public ClienteRepository(string connectionstring)
    {
      this.connectionstring = connectionstring;
    }

    public void Inserir(Cliente obj)
    {
      var query = @"
                            INSERT INTO CLIENTE(IDCLIENTE, NOME, CPF)
                            VALUES(@IdCliente, @Nome, @Cpf)
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Alterar(Cliente obj)
    {
      var query = @"
                            UPDATE CLIENTE
                            SET
                                NOME = @Nome,
                                CPF = @Cpf
                            WHERE
                                IDCLIENTE = @IdCliente
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public void Excluir(Cliente obj)
    {
      var query = @"
                            DELETE FROM CLIENTE
                            WHERE IDCLIENTE = @IdCliente
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        connection
            .Execute(query, obj);
      }
    }

    public List<Cliente> ObterTodos()
    {
      var query = @"
                            SELECT * FROM CLIENTE
                            ORDER BY NOME
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
            .Query<Cliente>(query)
            .ToList();
      }
    }

    public Cliente ObterPorId(Guid id)
    {
      var query = @"
                            SELECT * FROM CLIENTE
                            WHERE IDCLIENTE = @id
                    ";

      using (var connection = new SqlConnection(connectionstring))
      {
        return connection
            .Query<Cliente>(query, new { id })
            .FirstOrDefault();
      }
    }
  }
}
