using Projeto06.Controllers;
using Projeto06.Repositories;
using System;

namespace Projeto06
{
  class Program
  {
    static void Main(string[] args)
    {
      //criando um objeto da classe EmpresaRepository
      var empresaRepository = new EmpresaRepository();

      //Injeção de dependência!
      //criando um objeto da classe EmpresaController passando como
      //parametro no construtor a instancia da classe EmpresaRepository
      var empresaController = new EmpresaController(empresaRepository);

      //executando a operação de cadastro..
      empresaController.CadastrarEmpresa();

      Console.ReadKey();
    }
  }
}

