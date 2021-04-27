using Projeto05.Entities;
using Projeto05.Repositories;
using System;

namespace Projeto05
{
  class Program
  {
    static void Main(string[] args)
    {
      var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_Projeto05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

      try
      {
        //criando produtos..
        var produto1 = new Produto { IdProduto = Guid.NewGuid(), Nome = "Mouse", Preco = 40 };
        var produto2 = new Produto { IdProduto = Guid.NewGuid(), Nome = "Notebook", Preco = 3000 };

        //criando um cliente..
        var cliente = new Cliente { IdCliente = Guid.NewGuid(), Nome = "Ana Paula", Cpf = "12345678900" };

        //gravando os produtos..
        var produtoRepository = new ProdutoRepository(connectionstring);
        produtoRepository.Inserir(produto1);
        produtoRepository.Inserir(produto2);

        //gravando o cliente..
        var clienteRepository = new ClienteRepository(connectionstring);
        clienteRepository.Inserir(cliente);

        Console.WriteLine("\nDados gravados com sucesso!");
      }
      catch (Exception e)
      {
        Console.WriteLine("\nErro: " + e.Message);
      }

      Console.ReadKey();
    }
  }
}


