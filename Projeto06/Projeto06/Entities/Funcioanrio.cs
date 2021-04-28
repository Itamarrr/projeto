
using Projeto06.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.Entities
{
  /// <summary>
  /// Entidade de modelo de dados para Funcionário
  /// </summary>
  public class Funcionario
  {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataAdmissao { get; set; }

    #region Associações

    public TipoContratacao TipoContratacao { get; set; }

    #endregion
  }
}
