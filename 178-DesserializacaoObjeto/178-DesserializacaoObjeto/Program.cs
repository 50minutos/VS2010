using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace _178_DesserializacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream arquivoEscrita = new FileStream("saida.txt", FileMode.Create, FileAccess.Write))
            {
                Pessoa p = new Pessoa() { Codigo = 1, Nome = "Adão" };

                SoapFormatter sf = new SoapFormatter();

                sf.Serialize(arquivoEscrita, p);

                arquivoEscrita.Close();
            }

            using (FileStream arquivoLeitura = new FileStream("saida.txt", FileMode.Open, FileAccess.Read))
            {
                SoapFormatter sf = new SoapFormatter();
               
                Pessoa p = sf.Deserialize(arquivoLeitura) as Pessoa;

                arquivoLeitura.Close();
                
                if(p != null)
                    Console.WriteLine("{0} - {1}", p.Codigo, p.Nome);
            }

            Console.ReadKey();
        }
    }

    [Serializable]
    class Pessoa
    {
        public int Codigo { get; set; }

        public String Nome { get; set; }
    }
}
