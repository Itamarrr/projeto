
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.Entities
{
  /// <summary>
  /// Entidade de modelo de dados para Empresa
  /// </summary>
  public class Empresa
  {
    public Guid Id { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string Cnpj { get; set; }

    #region Associações

    public List<Funcionario> Funcionarios { get; set; }

    #endregion
  }
}
