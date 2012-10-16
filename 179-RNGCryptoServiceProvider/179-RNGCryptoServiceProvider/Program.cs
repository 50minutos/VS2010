using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _179_RNGCryptoServiceProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            //geração de sequência de bytes aleatórios
            byte[] chave = new byte[16]; //128 bits
            //ou new byte[8] ou new byte[32] ou new byte[n]
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            //RNG = random number generator

            for (int i = 0; i < 10; i++)
            {
                //rng.GetBytes(chave);
                rng.GetNonZeroBytes(chave);

                Console.WriteLine(MontarString(chave));
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static String MontarString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (byte item in array)
                    sb.Append(String.Format("{0,4}", item));

            return sb.ToString();
        }
    }
}
