using Projeto04.Entities;
using Projeto04.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto04.Controllers
{
   public class ClienteController 
    {
        public void CadastrarCliente()
        {
            Console.WriteLine("CADASTRO DE CLIENTE \n");
            var cliente = new Cliente();
            

            cliente.IdCliente = Guid.NewGuid();

            Console.Write("ENTRE COM O NOME DO CLIENTE..:");
            cliente.Nome = Console.ReadLine();

            Console.Write("ENTRE COM O CPF DO CLIENTE..:");
            cliente.Cpf = Console.ReadLine();

            var clienteRepository = new ClienteRepository();
            clienteRepository.Inserir(cliente);

            Console.Write("***** CLIENTE CADASTRADO COM SUCESSO! *****");

            Console.WriteLine("\n INFORME O NUMERO DE DEPENDENTES..: ");
            var qtd = int.Parse(Console.ReadLine());

            var dependenteRepository = new DependenteRepository();

            for (int i = 0; i < qtd; i++)
            {
                var dependente = new Dependente();
                
                dependente.IdDependente = Guid.NewGuid(); // gerando chave..

                Console.WriteLine("\n DIGITE O NOME DO DEPENDENTE..: ");
                dependente.Nome = Console.ReadLine();

                Console.WriteLine("\n DIGITE A DATA NASCIMENTO DO DEPENDENTE..: " );
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());

                // RELACIONAR O DEPENDENTE AO CLIENTE
                dependente.IdCliente = cliente.IdCliente;
                dependenteRepository.Inserir(dependente); // granvando no banco
                Console.WriteLine("\n DEPENDENTE CADASTRADO COM SUCESSO \n");
            }
        }
       
    }
}
