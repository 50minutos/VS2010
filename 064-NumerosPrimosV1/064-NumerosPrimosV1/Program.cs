using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _064_NumerosPrimosV1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                if(TestarPrimo(i))
                Console.Write("{0,4}",i);
            }

            Console.ReadKey();
        }

        private static bool TestarPrimo(int numero)
        {
            bool retorno = true;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    retorno = false;
                }
            }

            return retorno;
        }
    }
}
