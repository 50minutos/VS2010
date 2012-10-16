using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace _188_GerarHashSHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                MD5: MD5CryptoServiceProvider 
                RIPEMD-160: RIPEMD160Managed
                SHA: SHA1CryptoServiceProvider e SHA1Managed
                Keyed hash: HMAC e MACTripleDES
            */

            //geração de hash com SHA1
            StreamReader sr = new StreamReader("Arquivo.txt");

            String mensagem = sr.ReadToEnd();

            sr.Close();

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            UnicodeEncoding ue = new UnicodeEncoding();
            
            byte[] bytes = ue.GetBytes(mensagem);

            byte[] hash = sha1.ComputeHash(bytes);

            Gravar(hash, sha1.GetType().Name);

            Process.Start("notepad", String.Format("{0}.hash", sha1.GetType().Name));

        }

        private static void Gravar(byte[] hash, String nomeDaClasse)
        {
            StreamWriter sw = new StreamWriter(String.Format("{0}.hash", nomeDaClasse), false, Encoding.UTF8);

            sw.WriteLine(MontarString(hash));

            sw.Close();
        }

        private static String MontarString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (var item in array)
                    sb.Append(String.Format("{0} ", item));

            return sb.ToString();
        }
    }
}
