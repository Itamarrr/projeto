using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto06.Helpers
{
  /// <summary>
  /// Classe utilitária para tarefas de Console (Prompt de Comando)
  /// </summary>
  public class ConsoleHelper
  {
    //método estático
    public static string Read(string message)
    {
      Console.Write(message);
      return Console.ReadLine();
    }
  }
}
