using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _047_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 43, 6, 3, 234, 5, 67, 34, 7 };

            Console.WriteLine(Somar(numeros));
            Console.WriteLine(Somar(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            Console.ReadKey();
        }

        static int Somar(int[] numeros)
        {
            int retorno = 0;

            foreach (var item in numeros)
            {
                retorno += item;
            }

            return retorno;
        }
    }
}
