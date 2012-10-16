using System;

namespace _016_OperadoresIncrementoDecremento
{
    class Program
    {
        static void Main(string[] args)
        {
            //++ --

            int x = 10;

            Console.WriteLine(x++); //x += 1 -> x = x + 1
            Console.WriteLine(++x); //x += 1 -> x = x + 1
            Console.WriteLine(x--); //x -= 1 -> x = x - 1
            Console.WriteLine(--x); //x -= 1 -> x = x - 1

            Console.WriteLine();

            Console.WriteLine(x += ++x); //x = x + ++x -> x = 10 + 11 -> 21

            x = 10;

            Console.WriteLine(x += x++); //x = x + x++ -> x = 10 + 10++ -> 20

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
