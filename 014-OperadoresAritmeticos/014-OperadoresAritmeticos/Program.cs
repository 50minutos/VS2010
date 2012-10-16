using System;

namespace _014_OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ - * / %

            int x = 10;
            int y = 3;

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
            
            Console.WriteLine();

            Console.WriteLine("{0} / {1} = {2}", x, y, (float)x / y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / (double)y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / (decimal)y);

            Console.ReadKey();
        }
    }
}
