using System;

namespace _020c_OperadoresDeslocamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // >> <<
            int x = 7; //0000 0111

            Console.WriteLine(x >> 1); //0000 0011 -> 3
            Console.WriteLine(x << 2); //0000 1110 -> 0001 1100 -> 28
            Console.WriteLine(x >> 2 << 2); //4 0000 0100

            Console.ReadKey();
        }
    }
}
