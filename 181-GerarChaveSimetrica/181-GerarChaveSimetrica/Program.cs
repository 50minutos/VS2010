using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _181_GerarChaveSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //criptografia 
            //algoritmo de criptografia
            //mensagem
            //mensagem cifrada
            //chave de criptografia

            //ponta solta

            //abcdefghijklmnopqrstuvwxyz
            //paranoia e bom para senhas, entendeu?
            //parnoiebmshtd ucfgjklqvwxyz
            //puacrfngojikelbqmvswhxtydz -> chave

            //mensagem = opabeleza
            //cifrada =  bqpurkrzp
            //           opabeleza

            //abcdefghijklmnopqrstuvwxyz
            //bbddundss - cifrada com rotação da chave
            //puacrfngojikelbqmvswhxtydz 1
            //zpuacrfngojikelbqmvswhxtyd 2
            //dzpuacrfngojikelbqmvswhxty 3
            //ydzpuacrfngojikelbqmvswhxt 4
            //tydzpuacrfngojikelbqmvswhx 5
            //xtydzpuacrfngojikelbqmvswh 6
            //hxtydzpuacrfngojikelbqmvsw 7
            //whxtydzpuacrfngojikelbqmvs 8
            //swhxtydzpuacrfngojikelbqmv 9

            /*
               Algoritmos
               ----------
               DES: DESCryptoServiceProvider 
               RC2: RC2CryptoServiceProvider 
               Rijndael: RijndaelManaged 
               TripleDES: TripleDESCryptoServiceProvider 
            */

            //criação de chaves simétricas
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            Console.WriteLine(tdes.IV); //64 bits
            Console.WriteLine(tdes.Key); //192 bits

            Console.WriteLine();

            Console.WriteLine(MontarString(tdes.IV));

            Console.WriteLine();

            Console.WriteLine(MontarString(tdes.Key));

            tdes.GenerateIV();
            tdes.GenerateKey();

            Console.WriteLine();
            Console.WriteLine();

            //byte[] meuIV = { 12, 23, 54, 65, 23, 76, 87, 89 };
            //byte[] minhaChave = { 12, 23, 54, 65, 23, 76, 87, 189, 112, 123, 154, 165, 123, 176, 187, 189, 102, 230, 254, 5, 213, 167, 178, 9 };

            //tdes.IV = meuIV;
            //tdes.Key = minhaChave;

            Console.WriteLine(MontarString(tdes.IV));

            Console.WriteLine();

            Console.WriteLine(MontarString(tdes.Key));

            Console.ReadKey();
        }

        private static String MontarString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (var item in array)
                {
                    sb.Append(String.Format("{0,4}", item));
                }

            return sb.ToString();
        }
    }
}
