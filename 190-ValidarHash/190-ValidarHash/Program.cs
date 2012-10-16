using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace _190_ValidarHash
{
    class Program
    {
        private static byte ToByte(String s)
        {
            return Convert.ToByte(s);
        }

        static void Main(string[] args)
        {
            //validação de hash - sha1
            StreamReader sr = new StreamReader("Arquivo.txt");

            String mensagem = sr.ReadToEnd();

            sr.Close();

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            UnicodeEncoding ue = new UnicodeEncoding();

            byte[] bytes = ue.GetBytes(mensagem);
            byte[] hash = sha1.ComputeHash(bytes);

            sr = new StreamReader(String.Format("{0}.hash", sha1.GetType().Name));

            String linha = sr.ReadLine();

            sr.Close();

            String[] bytesDoArquivo = linha.Trim().Split(' ');

            Converter<String, byte> conversor = new Converter<String, byte>(ToByte);

            //ToByte - método que converte uma String para um byte
            //Converter - sabe percorrer o array de Strings e converter cada elemento para byte usando o método ToByte que eu criei

            byte[] gravado = Array.ConvertAll<String, byte>(bytesDoArquivo, conversor);

            bool ok = true;

            for (int i = 0; i < gravado.Length; i++)
            {
                if (hash[i] != gravado[i])
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                Console.WriteLine("O arquivo é válido");
            else
                Console.WriteLine("Mexeram no arquivo!!!");

            Console.ReadKey();
        }
    }
}
