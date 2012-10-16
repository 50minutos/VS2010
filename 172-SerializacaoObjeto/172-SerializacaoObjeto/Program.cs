using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Soap;

namespace _172_SerializacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("saida.xml", FileMode.Create, FileAccess.Write))
            {
                Dados d = new Dados();

                SoapFormatter sf = new SoapFormatter();
                
                sf.Serialize(fs, d);

                fs.Close();
            }

            Process.Start("saida.xml");
        }
    }

    [Serializable] //atributo
    class Dados
    {
        [NonSerialized]
        public String dadosPrivados = "isso é secreto!!!";

        public String dadosPublicos = "isso é público";
    }
}
