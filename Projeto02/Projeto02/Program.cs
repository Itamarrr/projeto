using Projeto02.Entities;
using Projeto02.Entities.Enum;
using Projeto02.Repositories;
using System;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXPORTAÇÃO DO DADOS DO FUNCIONARIO PARA FORMATO JSON");
            //itamar criando objeto
            //Funcionario funcionario = new Funcionario();
            var funcionario = new Funcionario(); //criando uma variavel que recebe um objeto  funcionario
            funcionario.Setor = new Setor(); //inicializando setor
            funcionario.Funcao = new Funcao(); //inicializando Funcao


            funcionario.Id = Guid.NewGuid();
            funcionario.Nome = "Itamar";
            funcionario.DataNascimento = new DateTime(1984, 02, 03);
            funcionario.Cpf = "109.123.387-03";
            funcionario.DataNascimento = new DateTime(2020, 12, 30);
            funcionario.Situacao = SituacaoFuncionario.Admitido;
            //Funão 
            funcionario.Funcao.Id = Guid.NewGuid();
            funcionario.Funcao.Descricao = "Programador de Sistemas";
            //Setor
            funcionario.Setor.Id = Guid.NewGuid();
            funcionario.Setor.Nome = "Engenharia de Software";

                        
            try
            {
                var funcionarioRepository = new FuncionarioRepository();

                funcionarioRepository.ExportarJson(funcionario);

                Console.WriteLine("Arquivo Json gravado com sucesso");
            }
            catch (Exception e) //Capitura de erro
            {
                Console.WriteLine(e.Message); //mensagem de erro
            }
        }
    }
}
