using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace _189_GerarhashMD5
{
    class Program
    {
        static void Main(string[] args)
        {
            //geração de hash com MD5
            StreamReader sr = new StreamReader("Arquivo.txt");

            String mensagem = sr.ReadToEnd();

            sr.Close();

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bytes = Encoding.Default.GetBytes(mensagem);

            byte[] hash = md5.ComputeHash(bytes);

            Gravar(hash, md5.GetType().Name);

            Process.Start("notepad", String.Format("{0}.hash", md5.GetType().Name));
        }

        private static void Gravar(byte[] bytes, String classe)
        {
            StreamWriter sw = new StreamWriter(String.Format("{0}.hash", classe), false, Encoding.UTF8);

            sw.WriteLine(MontarString(bytes));

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
