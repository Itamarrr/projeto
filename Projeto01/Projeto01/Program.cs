using Projeto01.Entities;
using System;

namespace Projeto01 // localização da minha classse no projeto
{
    public class Program // definição da classe
    {
        static void Main(string[] args) // esta rotina tem essa assinatura ele é o metodo utilizado pra executar o programa
        {
            Console.WriteLine("********* CADASTRO DE CLIENTE ******");

            // Criando o objeto pra classe Cliente com isso eu tenho  acesso as informações da classe Cliente
            var cliente = new Cliente();

            cliente.id = Guid.NewGuid();
            
            Console.Write(" Digite o Nome do Cliente..: ");

            cliente.Nome = Console.ReadLine(); // armazenando oque o cliente digitou na tela na varialvel nome 


            Console.Write(" Digite o CPF do Cliente..: ");

            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de Nascimento..: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write(" Digite o Email do Cliente..: ");

            cliente.Email = Console.ReadLine();


            //imprimindo os dados do cliente 
            Console.WriteLine("Cadastro realizado com sucesso sera criado altomaticamente um codigo para o novo Cliente");
            Console.WriteLine("Para dar continuidade no cadastro favor precionar a tecla enter");
            Console.ReadKey();
            Console.WriteLine("\n Codigo do Cliente..: \n" + cliente.id);

            Console.WriteLine("\n Nome do Cliente..: \n" + cliente.Nome);

            Console.WriteLine("\n Email do Cliente..: \n" + cliente.Email);

            Console.ReadKey(); // serve pra parar a execução no prompet e sai somente quando aperta uma tecla
        }
    }
}
