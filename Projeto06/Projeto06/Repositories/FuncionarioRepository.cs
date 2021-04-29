using Newtonsoft.Json;
using Projeto06.Entities;
using Projeto06.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto06.Repositories
{
  /// <summary>
  /// Classe de repositório de dados para Funcionário
  /// </summary>
  public class FuncionarioRepository : IFuncionarioRepository
  {
    public void Exportar(Funcionario obj)
    {
      string path = $"c:\\temp\\funcionario_{obj.Id}.json";

      var json = JsonConvert.SerializeObject(obj, Formatting.Indented);

      using (var streamWriter = new StreamWriter(path))
      {
        streamWriter.WriteLine(json);
      }
    }
  }
}
