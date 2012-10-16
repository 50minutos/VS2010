using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _120_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = ObterNumeros(10);

            foreach (int numero in ObterNumeros(2).ToArray<int>())
                Console.WriteLine(numero);

            Console.WriteLine();

            foreach (int numero in ObterNumeros(5))
                Console.WriteLine(numero);

            Console.WriteLine();

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static IEnumerable<int> ObterNumeros(int qtd)
        {
            Random r = new Random(qtd);

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("   gerei");
                yield return r.Next(1, 11);
            }
        }
    }
}
