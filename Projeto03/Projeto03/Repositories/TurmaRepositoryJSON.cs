using Newtonsoft.Json;
using Projeto03.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto03.Entities
{
    /// <summary>
    /// CLASSE PARA ARMAZENAMENTO DE DADOS DE TURMA EM JSON
    /// </summary>
    public class TurmaRepositoryJSON : ITurmaRepository
    {
        public void Exportar(Turma turma)
        {
            var path = "C:\\Itamarc#Projeto1\\projeto\\Projeto03\\Arquivo_JSON\\" + turma.Id + ".json";

            // serializando os dados da turma para JSON
            var json = JsonConvert.SerializeObject(turma, Formatting.Indented);


            //abrindo o arquivo em modo de escrita
            using (var streamWriter = new StreamWriter(path))
            {
                // escrevendo os dados dentro do arquivo JSON
                streamWriter.WriteLine(json); // (Formatting.Indented) serve pra endentar meu arquivo 
            }
        }
    }
}
