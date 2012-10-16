using System;

namespace _028_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            int[] y = { 1, 2 };
            int[] z = { 1, 2, 3, 4, 5, 6 };

            int[][] numeros = { x, y, z };

            for (int linha = 0; linha < numeros.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < numeros[linha].Length; coluna++)
                {
                    Console.Write("{0} ", numeros[linha][coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
