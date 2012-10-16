using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Soap;

namespace _173_SerializaçãoObjetoComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("saida.xml", FileMode.Create, FileAccess.Write))
            {
                Pessoa avoMaterno = new Pessoa() { nome = "Zé Diogo" };

                Pessoa meuPai = new Pessoa() { nome = "Antonio" };
                Pessoa minhaMae = new Pessoa() { nome = "Elisa", pai = avoMaterno };

                Pessoa eu = new Pessoa() { nome = "Agnaldo", pai = meuPai, mae = minhaMae };

                SoapFormatter soapFormatter = new SoapFormatter();
             
                soapFormatter.Serialize(fileStream, eu);
                
                fileStream.Close();
            }

            Process.Start("saida.xml");
        }
    }
    
    [Serializable]
    class Pessoa
    {
        public String nome;
        public Pessoa pai;
        public Pessoa mae;
    }
}
