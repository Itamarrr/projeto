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
   public class DependenteRepository : IDependenteRepository
    {
        private string _connectionstring = ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public void Inserir(Dependente obj)
        {
            var query = @"INSERT INTO DEPENDENTE (IDDEPENDENTE, NOME, DATANASCIMENTO, IDCLIENTE)
                            VALUES(@IDDEPENDENTE, @NOME, @DATANASCIMENTO, @IDCLIENTE)";
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Dependente obj)
        {
            var query = @"UPDATE DEPENDENTE SET(NOME = @NOME, DATANASCIMENTO = @DATANACIMENTO, IDCLIENTE = @IDCLIENTE)
                        WHERE IDDEPENDENTE = @IDDEPENDENTE";
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query,obj);
            }
        }

        public void Excluir(Dependente obj)
        {
            var query = @"DELETE DEPENDENTE WHERE IDDEPENDENTE = @IDDEPENDENTE";
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Dependente> Consultar()
        {
            var query = @"SELECT * FROM DEPENDENTE  ORDER BY NOME ASC";
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Dependente>(query).ToList();
            }
           
        }

        public Dependente ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM DEPENDENTE WHERE IDDEPENDENTE = @ID";
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Dependente>(query, new {id}).FirstOrDefault();
            }
        }
    }
}
