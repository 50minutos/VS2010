using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace _185_DecriptacaoAssimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //decriptação assimétrica
            RijndaelManaged rm = new RijndaelManaged();

            LerCripto(rm);

            Gravar(rm);

            Process.Start("notepad", "Chaves.sec");
        }

        private static void LerCripto(RijndaelManaged rm)
        {
            StreamReader sr = new StreamReader("ChavesCriptografadas.sec", Encoding.UTF8);

            string[] criptoKs = sr.ReadLine().Trim().Split(' ');
            string[] criptoIVs = sr.ReadLine().Trim().Split(' ');

            sr.Close();

            byte[] ks = new byte[criptoKs.Length];
            byte[] ivs = new byte[criptoIVs.Length];

            for (int i = 0; i < ks.Length; i++)
            {
                ks[i] = Convert.ToByte(criptoKs[i]);
            }

            for (int i = 0; i < ivs.Length; i++)
            {
                ivs[i] = Convert.ToByte(criptoIVs[i]);
            }

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            Ler(rsa);

            byte[] k = rsa.Decrypt(ks, false);
            byte[] iv = rsa.Decrypt(ivs, false);

            rm.Key = k;
            rm.IV = iv;
        }

        private static byte ToByte(String s)
        {
            return Convert.ToByte(s);
        }

        private static void Ler(RSACryptoServiceProvider rsa)
        {
            StreamReader sr = new StreamReader("ChavePublicaPrivada.sec", Encoding.UTF8);

            String[] modulus = sr.ReadLine().Trim().Split(' ');
            String[] exponent = sr.ReadLine().Trim().Split(' ');

            String[] p = sr.ReadLine().Trim().Split(' ');
            String[] q = sr.ReadLine().Trim().Split(' ');
            String[] dp = sr.ReadLine().Trim().Split(' ');
            String[] dq = sr.ReadLine().Trim().Split(' ');
            String[] inverseQ = sr.ReadLine().Trim().Split(' ');
            String[] d = sr.ReadLine().Trim().Split(' ');

            sr.Close();

            RSAParameters rsap = new RSAParameters();

            byte[] bytes = new byte[modulus.Length];
            bytes = Array.ConvertAll<String, byte>(modulus, new Converter<string, byte>(ToByte));
            rsap.Modulus = bytes;

            bytes = new byte[exponent.Length];
            bytes = Array.ConvertAll<String, byte>(exponent, new Converter<string, byte>(ToByte));
            rsap.Exponent = bytes;

            bytes = new byte[p.Length];
            bytes = Array.ConvertAll<String, byte>(p, new Converter<string, byte>(ToByte));
            rsap.P = bytes;

            bytes = new byte[q.Length];
            bytes = Array.ConvertAll<String, byte>(q, new Converter<string, byte>(ToByte));
            rsap.Q = bytes;

            bytes = new byte[dp.Length];
            bytes = Array.ConvertAll<String, byte>(dp, new Converter<string, byte>(ToByte));
            rsap.DP = bytes;

            bytes = new byte[dq.Length];
            bytes = Array.ConvertAll<String, byte>(dq, new Converter<string, byte>(ToByte));
            rsap.DQ = bytes;

            bytes = new byte[inverseQ.Length];
            bytes = Array.ConvertAll<String, byte>(inverseQ, new Converter<string, byte>(ToByte));
            rsap.InverseQ = bytes;

            bytes = new byte[d.Length];
            bytes = Array.ConvertAll<String, byte>(d, new Converter<string, byte>(ToByte));
            rsap.D = bytes;

            rsa.ImportParameters(rsap);
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

        private static void Gravar(RijndaelManaged rm)
        {
            StreamWriter sw = new StreamWriter("Chaves.sec", false, Encoding.UTF8);

            sw.WriteLine(MontarString(rm.Key));
            sw.WriteLine(MontarString(rm.IV));

            sw.Close();
        }
    }
}
