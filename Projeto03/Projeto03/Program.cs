using Projeto03.Entities;
using Projeto03.Interfaces;
using System;
using System.Collections.Generic;

namespace Projeto03
{
   public class Program
    {
        static void Main(string[] args)
        {
                    Console.Write("\n******************************\n");
                    Console.WriteLine(" CADASTRO DE TURMAS!        **");
                    Console.Write("******************************\n");
           
            try
            {
                // crinaod um objeto da classe turma 
                var turma = new Turma(); // inicializando minha variavel como tipo Turma instanciando ou criando objeto
                turma.Id = Guid.NewGuid(); // gerando o Id da turma ou seja achave Guid da turma pois isso o user não digita

                Console.Write("\n Digite o nome da Turma..: ");
                turma.Nome = Console.ReadLine(); // LE O QUE É DIGITADO E RETORNA COMOSTRING

                Console.Write("\n Digite a Data de Inicio da Turma..: ");
                turma.DataInicio = DateTime.Parse(Console.ReadLine()); // parse converte ai esta de string para DateTime

                //***DADOS DO PROFESSOR     
                turma.Professor = new Professor(); // instancia Professor que esta no Turma 
                turma.Professor.Id = Guid.NewGuid();

                Console.WriteLine("Digite o nome do Professor..:");
                turma.Professor.Nome = Console.ReadLine();

                Console.WriteLine("\n Digite o Email do Professor..:");
                turma.Professor.Email = Console.ReadLine();

                //*** DADOS DO ALUNO
                turma.Alunos = new List<Aluno>();
                Console.WriteLine("Quntos Alunos deseja nessa Turma\n");
                var qtd = int.Parse(Console.ReadLine()); // obs o for aceita somente int lembrar 
                for (int i = 0; i < qtd; i++)
                {
                    var aluno = new Aluno(); // instanciando dentro do for para cada vez que ele passar no for criar um novo aluno ou seja novos objetos
                    aluno.Id = Guid.NewGuid();

                    Console.WriteLine("Digite o nome do Aluno..:");
                    aluno.Nome = Console.ReadLine();

                    Console.WriteLine("Digite a Matricula do Aluno..:");
                    aluno.Matricula = Console.ReadLine();

                    Console.WriteLine("Digite a Data de Nascimento do Aluno..:");
                    aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

                    turma.Alunos.Add(aluno); //foi criado um for para criar a lista agora estou add em tura.Alunos assim ficara dentro do json
                }
                


                // OPÇÃO DE A
                Console.Write(" \n Informe (1) para XML ou (2) JSON..: ");

                var opcao = int.Parse(Console.ReadLine()); // parse esta passando o string para inteiro


                ITurmaRepository turmaRepository = null; // -> vazio

                switch (opcao)
                {
                    case 1:  // XML
                        turmaRepository = new TurmaRepositoryXML(); // POLIMOFISMO EU PEGO A MESMA VARIAVEL E INICIALIZO DE FORMAS DIFERENTE
                            break; 

                    case 2: // JSON
                        turmaRepository = new TurmaRepositoryJSON(); // POLIMOFISMO EU PEGO A MESMA VARIAVEL E INICIALIZO DE FORMAS DIFERENTE
                        break;

                    default: // NENHUMA OPCAO
                        break;
                }

                turmaRepository.Exportar(turma);
            }
            catch (Exception e)
            {

                // imprimendo mensagem de erro 
                Console.WriteLine("Ocorreu um erro"+ e.Message);
            }

            Console.ReadKey();
        }
    }
}
