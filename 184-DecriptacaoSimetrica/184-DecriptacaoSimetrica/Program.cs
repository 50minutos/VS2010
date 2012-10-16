using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace _184_DecriptacaoSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //decriptação simétrica
            RijndaelManaged rm = new RijndaelManaged();

            byte[] k = new byte[rm.Key.Length];
            byte[] iv = new byte[rm.IV.Length];

            LerChave(k, iv, "Chaves.sec");

            LerArquivo(rm, k, iv);

            Process.Start("Destino.txt");
            Process.Start("Decriptado.txt");
        }

        private static void LerArquivo(RijndaelManaged rm, byte[] k, byte[] iv)
        {
            FileStream fs = new FileStream("Destino.txt", FileMode.Open, FileAccess.Read);

            CryptoStream cs = new CryptoStream(fs,
                rm.CreateDecryptor(k, iv),
                CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cs);

            StreamWriter sw = new StreamWriter("Decriptado.txt");

            sw.WriteLine(sr.ReadToEnd());

            sr.Close();
            sw.Close();
        }

        private static void LerChave(byte[] k, byte[] iv, String nomeArquivo)
        {
            StreamReader sr = new StreamReader(nomeArquivo, Encoding.UTF8);

            String[] keys = sr.ReadLine().Trim().Split(' ');
            String[] ivs = sr.ReadLine().Trim().Split(' ');

            sr.Close();

            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Convert.ToByte(keys[i]);
            }

            for (int i = 0; i < iv.Length; i++)
            {
                iv[i] = Convert.ToByte(ivs[i]);
            }
        }
    }
}
