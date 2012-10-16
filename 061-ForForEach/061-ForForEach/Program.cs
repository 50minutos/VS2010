using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _061_ForForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]++;
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
