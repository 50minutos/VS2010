using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _068_NumerosPerfeitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //a soma dos divisores (exceto o próprio número) é o número
            //1 + 2 + 3 = 6

            for (int i = 1; i <= 1000; i++)
            {
                if (TestarPerfeito(i))
                    Console.Write("{0,4}", i);
            }

            Console.ReadKey();
        }

        private static bool TestarPerfeito(int numero)
        {
            bool retorno = true;

            int soma = 0;

            for (int i = 1; i <= numero/2; i++)
            {
                soma += numero % i == 0 ? i : 0;
            }

            if (soma != numero)
                retorno = false;

            return retorno;
        }
    }
}
