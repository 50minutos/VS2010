using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Diagnostics;

namespace _170_Serializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream arquivo = new FileStream("saida.txt", FileMode.Create, FileAccess.Write))
            {
                String texto = "qualquer coisa";
                int inteiro = 10;
                //double _double = 10.10;
                //decimal _decimal = 1234567.1234567M;

                SoapFormatter formatador = new SoapFormatter();

                //formatador.Serialize(arquivo, texto);
                //formatador.Serialize(arquivo, inteiro);
                //formatador.Serialize(arquivo, _double);
                //formatador.Serialize(arquivo, _decimal);
                formatador.Serialize(arquivo, String.Format("{0} vale {1:c}", texto, inteiro));

                arquivo.Close();
            }

            Process.Start("saida.txt");
        }
    }
}
