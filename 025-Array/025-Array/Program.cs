using System;

namespace _025_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicialização de arrays
            int[] inteiros = { 1, 2, 5, -2, 5, 567, -87, 3, 2 };
            String[] nomes = { "Bruno", "Netinho", "Pedro"};

            foreach (var item in inteiros)
            {
                Console.WriteLine(item);
            }

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
