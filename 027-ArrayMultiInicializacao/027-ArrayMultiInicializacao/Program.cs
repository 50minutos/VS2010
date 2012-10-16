using System;

namespace _027_ArrayMultiInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = { { 1, 2 }, { 10, 20 }, { 100, 200 } };

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
