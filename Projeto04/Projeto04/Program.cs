using Projeto04.Controllers;
using System;

namespace Projeto04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var clienteController = new ClienteController();
                clienteController.CadastrarCliente();
                Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO");
            }
            catch (Exception e)
            {

                Console.WriteLine("\n ERRO" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
