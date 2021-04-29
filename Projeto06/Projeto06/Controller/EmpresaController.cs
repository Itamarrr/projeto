using Projeto06.Entities;
using Projeto06.Enums;
using Projeto06.Helpers;
using Projeto06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.Controllers
{
  /// <summary>
  /// Classe de controle para processos de Empresa
  /// </summary>
  public class EmpresaController
  {
    //atributo
    private readonly IEmpresaRepository empresaRepository;

    //construtor para inicialização do atributo
    public EmpresaController(IEmpresaRepository empresaRepository)
    {
      this.empresaRepository = empresaRepository;
    }

    //método para executar o fluxo de cadastro da empresa
    public void CadastrarEmpresa()
    {
      Console.WriteLine("\nCADASTRO DE EMPRESA\n");

      try
      {
        var empresa = new Empresa();
        empresa.Funcionarios = new List<Funcionario>();

        empresa.Id = Guid.NewGuid();
        empresa.RazaoSocial = ConsoleHelper.Read("Razão Social: ");
        empresa.NomeFantasia = ConsoleHelper.Read("Nome Fantasia: ");
        empresa.Cnpj = ConsoleHelper.Read("CNPJ: ");

        var qtd = int.Parse(ConsoleHelper.Read("\nNúmero de Funcionários: "));

        for (int i = 0; i < qtd; i++)
        {
          Console.WriteLine($"\nEntre com os dados do {i + 1}º Funcionário:");

          var funcionario = new Funcionario();

          funcionario.Id = Guid.NewGuid();
          funcionario.Nome = ConsoleHelper.Read("Nome do Funcionário: ");
          funcionario.Cpf = ConsoleHelper.Read("CPF: ");
          funcionario.DataAdmissao = DateTime.Parse(ConsoleHelper.Read("Data de Admissão: "));
          funcionario.TipoContratacao = (TipoContratacao)int.Parse(ConsoleHelper.Read("Tipo de Contratação: "));

          //adicionando o funcionario na empresa.
          empresa.Funcionarios.Add(funcionario);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine("\nErro: " + e.Message);
      }
    }
  }
}
