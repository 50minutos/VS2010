using System;

namespace _017_OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // == != < > <= >=

            int x = 10;
            int y = 5;

            Console.WriteLine(x == y);
            Console.WriteLine(x == y * 2);
            Console.WriteLine(x != y);
            Console.WriteLine(x < y);
            Console.WriteLine(x / 2 <= y);
            Console.WriteLine(x > y);
            Console.WriteLine(x / 2 >= -y);

            Console.ReadKey();
        }
    }
}
