using Projeto05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Interfaces
{
  public interface IClienteRepository
      : IBaseRepository<Cliente, Guid>
  {
