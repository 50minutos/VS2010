using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace _175_SerializacaoXML
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto() { codigo = 1, nome = "martelo", Preco = 10.20 };

            XmlSerializer x = new XmlSerializer(typeof(Produto));

            FileStream fs = new FileStream("saida.xml", FileMode.Create, FileAccess.Write);

            x.Serialize(fs, p);

            fs.Close();

            Process.Start("saida.xml");
        }
    }

    public class Produto
    {
        public int codigo;
        public String nome;

        public double Preco { get; set; }
    }
}