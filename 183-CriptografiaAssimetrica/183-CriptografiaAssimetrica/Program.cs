using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace _183_CriptografiaAssimetrica
{
    /*
    * a) criptografar o arquivo com algoritmo simétrico (***)
    * b) mandar o arquivo para o receptor (***)
    * c) criptografar a chave simétrica com algoritmo assimétrico
    */

    class Program
    {
        static void Main(string[] args)
        {
            //criptografia assimétrica
            RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider();

            Gravar(rsa);

            RijndaelManaged rm =
                new RijndaelManaged();

            Gravar(rm);

            byte[] criptoK = rsa.Encrypt(rm.Key, false);
            byte[] criptoIV = rsa.Encrypt(rm.IV, false);

            Gravar(criptoK, criptoIV);

            Process.Start("notepad", "Chaves.sec");//S
            Process.Start("notepad", "ChavePublica.sec");//A
            Process.Start("notepad", "ChavePublicaPrivada.sec");//A
            Process.Start("notepad", "ChavesCriptografadas.sec"); //SC
        }

        private static void Gravar(String nomeArquivo, RSAParameters p)
        {
            StreamWriter sw = new StreamWriter(nomeArquivo, false, Encoding.UTF8);

            sw.WriteLine(MontarString(p.Modulus));
            sw.WriteLine(MontarString(p.Exponent));
            sw.WriteLine(MontarString(p.P));
            sw.WriteLine(MontarString(p.Q));
            sw.WriteLine(MontarString(p.DP));
            sw.WriteLine(MontarString(p.DQ));
            sw.WriteLine(MontarString(p.InverseQ));
            sw.WriteLine(MontarString(p.D));

            sw.Close();
        }

        private static void Gravar(RijndaelManaged rm)
        {
            StreamWriter sw = new StreamWriter("Chaves.sec", false, Encoding.UTF8);

            sw.WriteLine(MontarString(rm.Key));
            sw.WriteLine(MontarString(rm.IV));

            sw.Close();
        }

        private static void Gravar(RSACryptoServiceProvider rsa)
        {
            RSAParameters p = rsa.ExportParameters(false);
            Gravar("ChavePublica.sec", p);

            p = rsa.ExportParameters(true);
            Gravar("ChavePublicaPrivada.sec", p);
        }


        private static void Gravar(byte[] criptoK, byte[] criptoIV)
        {
            StreamWriter sw = new StreamWriter("ChavesCriptografadas.sec", false, Encoding.UTF8);

            sw.WriteLine(MontarString(criptoK));
            sw.WriteLine(MontarString(criptoIV));

            sw.Close();
        }

        private static String MontarString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (var item in array)
                {
                    sb.Append(String.Format("{0} ", item));
                }

            return sb.ToString();
        }
    }
}
