using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _066_NumerosPrimosV3
{
    class Program
    {
        static List<int> primos = new List<int>();

        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (TestarPrimo(i))
                    primos.Add(i);
            }

            foreach (var item in primos)
            {
                Console.Write("{0,4}", item);
            }
            
            Console.ReadKey();
        }

        private static bool TestarPrimo(int numero)
        {
            bool retorno = true;

            foreach (var item in primos)
            {
                if (numero % item == 0)
                {
                    retorno = false;
                    break;
                }

                if(item > Math.Sqrt(numero)) 
                    break;
            }

            return retorno;
        }
    }
}
