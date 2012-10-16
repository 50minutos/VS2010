using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _070_MetodoRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Dobrar(x);

            Console.WriteLine("depois do Dobrar (val): {0}", x);

            Dobrar(ref x);

            Console.WriteLine("depois do Dobrar (ref): {0}", x);

            Console.WriteLine();

            int[] xx = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Dobrar(xx);

            foreach (var item in xx)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void Dobrar(int[] xx)
        {
            for (int i = 0; i < xx.Length; i++)
            {
                xx[i] *= 2;
                Console.WriteLine("   dentro ({0}): {1}", i, xx[i]);
            }
        }

        private static void Dobrar(ref int x)
        {
            x *= 2;

            Console.WriteLine("   dentro: {0}", x);
        }

        private static void Dobrar(int x)
        {
            x *= 2;

            Console.WriteLine("   dentro: {0}", x);
        }
    }
}
