using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace _182_CriptografiaSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //criptografia simétrica
            RijndaelManaged rm = new RijndaelManaged();

            GravarChaves(rm, "Chaves.sec");

            GravarArquivo(rm, "Origem.txt", "Destino.txt");

            Process.Start("notepad", "Chaves.sec");
            Process.Start("Origem.txt");
            Process.Start("Destino.txt");
        }

        private static void GravarArquivo(RijndaelManaged rm, String nomeArquivo, String nomeArquivoDestino)
        {
            FileStream fs = new FileStream(nomeArquivoDestino,
                FileMode.Create,
                FileAccess.Write);

            CryptoStream cs = new CryptoStream(fs,
                rm.CreateEncryptor(rm.Key, rm.IV),
                CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cs);

            StreamReader sr = new StreamReader(nomeArquivo);

            sw.WriteLine(sr.ReadToEnd());

            sr.Close();
            sw.Close();
        }

        private static void GravarChaves(RijndaelManaged rm, String nomeArquivoDestino)
        {
            StreamWriter sw = new StreamWriter(nomeArquivoDestino, false, Encoding.UTF8);

            sw.WriteLine(MontarString(rm.Key));
            sw.WriteLine(MontarString(rm.IV));

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
