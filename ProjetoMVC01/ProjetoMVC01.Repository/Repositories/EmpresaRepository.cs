using Dapper;
using ProjetoMVC01.Domain.Entities;
using ProjetoMVC01.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjetoMVC01.Repository.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        //atributo
        private string connectionstring;

        //método construtor recebendo por parametro uma connectionstring
        public EmpresaRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Inserir(Empresa obj)
        {
            var query = @"INSERT INTO EMPRESA(IDEMPRESA, RAZAOSOCIAL, CNPJ) 
                          VALUES(@IDEMPRESA, @RAZAOSOCIAL, @CNPJ)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Empresa obj)
        {
            var query = @"UPDATE EMPRESA SET RAZAOSOCIAL = @RAZAOSOCIAL 
                          WHERE IDEMPRESA = @IDEMPRESA";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Empresa obj)
        {
            var query = @"DELETE FROM EMPRESA WHERE IDEMPRESA = @IDEMPRESA";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Empresa> ObterTodos()
        {
            var query = @"SELECT * FROM EMPRESA ORDER BY RAZAOSOCIAL";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query).ToList();
            }
        }

        public Empresa ObterPorId(Guid id)
        {
            var query = "SELECT * FROM EMPRESA WHERE IDEMPRESA = @ID";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { id }).FirstOrDefault();
            }
        }

        public Empresa ObterPorCnpj(string cnpj)
        {
            var query = @"SELECT * FROM EMPRESA WHERE CNPJ = @CNPJ";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { cnpj }).FirstOrDefault();
            }
        }

        public List<Empresa> ObterPorRazaoSocial(string razaoSocial)
        {
            var query = @"SELECT * FROM EMPRESA WHERE RAZAOSOCIAL LIKE @RAZAOSOCIAL ORDER BY RAZAOSOCIAL";

            //adicionando o caractere '%' para realizar a regra do LIKE
            razaoSocial = $"%{razaoSocial}%";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Empresa>(query, new { razaoSocial }).ToList();
            }
        }

        public int ObterQuntidadeFuncionarios(Guid idEmpresa)
        {
            var query = @"SELECT COUNT (*) FROM FUNCIONARIO WHERE IDEMPRESA = @IDEMPRESA";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<int>(query, new { idEmpresa }).FirstOrDefault();
            }
        }
    }
}
