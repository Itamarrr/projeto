using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Entities
{
  public class Pedido
  {
    public Guid IdPedido { get; set; }
    public Guid IdCliente { get; set; }
    public DateTime DataPedido { get; set; }

    #region Associações

    public Cliente Cliente { get; set; }

    #endregion
  }
}
