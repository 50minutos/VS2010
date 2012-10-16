using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _116_LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = { "Agnaldo", "Marcelinho", "Leandro", "Felipe", "Flávio", "Rafael" };

            XElement xml = new XElement("nomes", /*root*/
               from n in nomes
               select new XElement("nome", n)
           );

            Console.WriteLine("<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?>");
            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }
}
