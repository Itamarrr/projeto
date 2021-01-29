using Dapper;
using Projeto04.Entities;
using Projeto04.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto04.Repositories
{
    
   public class ClienteRepository : IClienteRepository
    {
        private string _connectionstring = ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void Inserir(Cliente obj)
        {
            var query = @"INSERT INTO CLIENTE (IDCLIENTE, NOME, CPF)
                         VALUES (@IDCLIENTE, @NOME, @CPF)";
            using (var connection = new SqlConnection(_connectionstring))
            {
                //executar o query sql no banco de dados
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Cliente obj)
        {
            var query = @"UPDATE CLIENTE (IDCLIENTE = @IDCLIENTE)";
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Cliente obj)
        {
            var query = @"DELETE CLIENTE  
                        WHERE (IDCLIENTE = @IDCLIENTE) ";
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Cliente> Consultar()
        {
            var query = @"SELECT * FROM CLIENTE
                          ORDER BY NOME ASC";

            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Cliente>(query).ToList(); // QUENDO FOR SELECT TEM QUE SER RESURNE E NÃO EXECULTE
            }
        }

        public Cliente ConsultarPorCpf(string cpf)
        {
            var query = @"SELECT * FROM CLIENTE
                        WHERE CFP = @CPF";
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Cliente>(query, new {cpf}).FirstOrDefault(); //FirstOrDefault retorna o primeiro registro que encontrar
            }
        }

        public Cliente ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM CLIENTE 
                        WHERE IDCLIENTE = @ID";
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Cliente>(query, new {id}).FirstOrDefault();
            }
        }
    }
}
