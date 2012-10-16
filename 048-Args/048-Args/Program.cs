using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _048_Args
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(1, 2, 3));
            Console.WriteLine(Somar(2, 3));
            Console.WriteLine(Somar(1, 2, 3, 4, 5, 6, 7, 8));

            Console.WriteLine(Somar(new int[] { 10, 20, 30, 40 }));

            Console.ReadKey();
        }

        static int Somar(params int[] numeros)
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
