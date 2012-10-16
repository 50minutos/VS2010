using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _118_LINQToXMLObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Palestrante[] palestrantes = 
            {
                new Palestrante(1, "Agnaldo Diogo dos Santos", "LINQ"), 
                new Palestrante(2, "Alexandre Lopes", "Filestream"),
                new Palestrante(3, "Marcelo Sincic", "Sharepoint"), 
                new Palestrante(4, "Laerte Jr", "Powershell"),
                new Palestrante(5, "Thiago Zavaschi", "Office"), 
                new Palestrante(6, "Roberto Fonseca", "SSIS")
            };

            XElement xml = new XElement("palestrantes", /*root*/
                from palestrante in palestrantes
                select new XElement("palestrante",
                    new XAttribute("codigo", palestrante.codigo),
                    new XAttribute("nome", palestrante.nome),
                    new XAttribute("palestra", palestrante.palestra)
                )
            );

            Console.WriteLine("<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?>");
            Console.WriteLine(xml);

            Console.ReadKey();
        }
    }

    class Palestrante
    {
        public int codigo;
        public String nome;
        public String palestra;

        public Palestrante(int codigo, String nome, String palestra)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.palestra = palestra;
        }
    }
}
