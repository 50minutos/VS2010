using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Soap;

namespace _174_SerializacaoColecao
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("saida.xml", FileMode.Create, FileAccess.Write))
            {
                Pessoa p = new Pessoa() { nome = "Antonio" };
                Pessoa m = new Pessoa() { nome = "Elisa" };

                Pessoa eu = new Pessoa() { nome = "Agnaldo", pai = p, mae = m };
                //SoapFormatter não suporta coleções genéricas
                ArrayList familia = new ArrayList() { p, m, eu };

                new SoapFormatter().Serialize(fs, familia);

                fs.Close();
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
