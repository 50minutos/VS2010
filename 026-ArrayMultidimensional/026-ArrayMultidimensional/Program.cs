using System;

namespace _026_ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] inteiros = new int[3, 2];

            foreach (var item in inteiros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            inteiros[0, 0] = inteiros[1, 0] = inteiros[1, 1] = inteiros[2, 1] = 1;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("{0} ", inteiros[linha, coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
