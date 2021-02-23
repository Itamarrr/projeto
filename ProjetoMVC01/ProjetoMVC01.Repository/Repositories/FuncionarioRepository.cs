using Dapper;
using ProjetoMVC01.Domain.DTOs;
using ProjetoMVC01.Domain.Entities;
using ProjetoMVC01.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjetoMVC01.Repository.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        //atributo
        private string connectionstring;

        //método construtor para receber como parametro o valor
        //da connectionstring do banco de dados..
        public FuncionarioRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void Inserir(Funcionario obj)
        {
            var query = @"INSERT INTO FUNCIONARIO(IDFUNCIONARIO, NOME, CPF, MATRICULA, DATAADMISSAO, IDEMPRESA) 
                          VALUES(@IDFUNCIONARIO, @NOME, @CPF, @MATRICULA, @DATAADMISSAO, @IDEMPRESA)";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Alterar(Funcionario obj)
        {
            var query = @"UPDATE FUNCIONARIO SET NOME = @NOME, CPF = @CPF, 
                          MATRICULA = @MATRICULA, DATAADMISSAO = @DATAADMISSAO, 
                          IDEMPRESA = @IDEMPRESA WHERE IDFUNCIONARIO = @IDFUNCIONARIO";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public void Excluir(Funcionario obj)
        {
            var query = @"DELETE FROM FUNCIONARIO WHERE IDFUNCIONARIO = @IDFUNCIONARIO";

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Funcionario> ObterTodos()
        {
            var query = @"SELECT * FROM FUNCIONARIO ORDER BY NOME";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public Funcionario ObterPorId(Guid id)
        {
            var query = @"SELECT * FROM FUNCIONARIO WHERE IDFUNCIONARIO = @ID";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { id }).FirstOrDefault();
            }
        }

        public Funcionario ObterPorCpf(string cpf)
        {
            var query = @"SELECT * FROM FUNCIONARIO WHERE CPF = @CPF";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { cpf }).FirstOrDefault();
            }
        }

        public Funcionario ObterPorMatricula(string matricula)
        {
            var query = @"SELECT * FROM FUNCIONARIO WHERE MATRICULA = @MATRICULA";

            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<Funcionario>(query, new { matricula }).FirstOrDefault();
            }
        }

        public List<ConsultaFuncionarioDTO> Consultar(FiltroFuncionarioDTO dto)
        {
            var query = "SELECT * FROM VW_FUNCIONARIOS WHERE 1=1 ";

            //verificando se o campo nome foi preenchido
            if(!string.IsNullOrEmpty(dto.Nome))
            {
                dto.Nome = $"%{dto.Nome}%";
                query += " AND NOME LIKE @NOME";
            }

            //verificando se o campo cpf foi preenchido
            if(!string.IsNullOrEmpty(dto.Cpf))
            {
                query += " AND CPF = @CPF";
            }

            //verificando se o campo matricula foi preenchido
            if (!string.IsNullOrEmpty(dto.Matricula))
            {
                query += " AND MATRICULA = @MATRICULA";
            }

            //verificando se o campo data inicio admissão não está vazio
            if (dto.DataInicioAdmissao != null && dto.DataInicioAdmissao != DateTime.MinValue)
            {
                query += " AND DATAADMISSAO >= @DATAINICIOADMISSAO";
            }

            //verificando se o campo data fim admissão não está vazio
            if (dto.DataFimAdmissao != null && dto.DataFimAdmissao != DateTime.MinValue)
            {
                query += " AND DATAADMISSAO <= @DATAFIMADMISSAO";
            }

            //conectando no SqlServer, executar e retornar a consulta
            using (var connection = new SqlConnection(connectionstring))
            {
                return connection.Query<ConsultaFuncionarioDTO>(query, dto).ToList();
            }
        }
    }
}
