using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace _367_AttributeSerializable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Codigo = 1, Nome = "Adão", salario = 1200.00 };

            Console.WriteLine("{0} - {1} - {2}", p.Codigo, p.Nome, p.salario);

            SoapFormatter formatador = new SoapFormatter();

            MemoryStream ms = new MemoryStream();

            formatador.Serialize(ms, p);

            //----------------------------------------------

            ms.Position = 0;

            //Console.WriteLine(new StreamReader(ms).ReadToEnd());

            Pessoa q = (Pessoa)formatador.Deserialize(ms);

            Console.WriteLine("{0} - {1} - {2}", q.Codigo, q.Nome, q.salario);

            Console.ReadKey();
        }
    }

    [Serializable]
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        [NonSerialized]
        public double salario;
    }

}
