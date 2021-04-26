using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Entities
{
  public class Cliente
  {
    //prop + 2x[tab]
    public Guid IdCliente { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
  }
}
