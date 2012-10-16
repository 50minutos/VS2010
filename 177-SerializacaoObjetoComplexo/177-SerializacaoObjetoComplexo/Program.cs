using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace _177_SerializacaoObjetoComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa vo = new Pessoa() { codigo = 0, nome = "JOÃO DOS SANTOS" };
            Pessoa p = new Pessoa() { codigo = 1, nome = "ANTONIO", pai = vo };
            Pessoa m = new Pessoa() { codigo = 2, nome = "ELISA" };
            Pessoa eu = new Pessoa() { codigo = 3, nome = "AGNALDO", pai = p, mae = m };

            FileStream fs = new FileStream("saida.xml", FileMode.Create, FileAccess.Write);

            #region List<Pessoa>

            List<Pessoa> eus = new List<Pessoa>() { eu, eu, eu };

            XmlSerializer serializer = new XmlSerializer(typeof(List<Pessoa>), new XmlRootAttribute("Pessoas"));

            serializer.Serialize(fs, eus);

            #endregion

            #region Pessoa

            //XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));

            //serializer.Serialize(fs, eu);

            #endregion

            fs.Close();

            Process.Start("saida.xml");
        }
    }

    public class Pessoa
    {
        [XmlAttribute]
        public int codigo;

        [XmlAttribute(AttributeName = "nomeDoSujeito")]
        public String nome;

        [XmlElement(ElementName = "Pai")]
        public Pessoa pai;

        public Pessoa mae;
    }
}
