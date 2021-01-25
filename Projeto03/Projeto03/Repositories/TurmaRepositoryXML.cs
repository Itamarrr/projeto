using Projeto03.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Projeto03.Entities
{
    public class TurmaRepositoryXML : ITurmaRepository
    {
        public void Exportar(Turma turma)
        {
            // caminho para salvar o arquivo onde fica o arquivo
            var path = "C:\\Itamarc#Projeto1\\projeto\\Projeto03\\Arquivo_XML\\" + turma.Id + ".xml";

            // serializando os dados da turma para XML
            var xml = new XmlSerializer(turma.GetType()); //tenho que passar o parametro obrigatorio GetType()

            //abrindo o arquivo em modo de escrita
            using (var streamWriter = new StreamWriter(path))
            {
                xml.Serialize(streamWriter, turma);
                //streamWriter.WriteLine(xml);
            }
        }
    }
}
