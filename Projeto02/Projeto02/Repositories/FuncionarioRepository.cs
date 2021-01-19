using Newtonsoft.Json;
using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto02.Repositories
{
    /// <summary>
    /// Classe para armazenamento de dados funcionario em arquivo
    /// </summary>
  public  class FuncionarioRepository
    {
        /// <summary>
        /// Metodo para exportar os dados do funcionario para JSON
        /// </summary>
        /// <param name="funcionario"> OBIJETO DA CLASSE ENTIDADE FUNCIONARIO</param>
        public void ExportarJson(Funcionario funcionario)
        {
            //var nomearquivo = ("funcionario_" + funcionario.Id + ".json");// concatenando antigamente
            var nomearquivo = ($"funcionario_ {funcionario.Id}.json");// concatenando maneira nova de concatenar

            using (var streamWriter = new StreamWriter("C:\\Itamarc#Projeto1\\projeto\\Projeto02\\Arquivo_JSON\\" + nomearquivo))
            {

                //SERIALIZANDO PRA CRIAR ESSE CAMPO É SÓ DAR O COMANDO #REGION
                #region SERIALIZAÇÃO OS DADOS DO OBJETO FUNCIONARIO EM FORMATO JSON OU XML OU TXT ETC O CAMANDO Formatting.Indented SERVE PRA ENDENTAR O JSON
                var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);
                streamWriter.WriteLine(json);
                #endregion

            }

        }
        
    }
}
