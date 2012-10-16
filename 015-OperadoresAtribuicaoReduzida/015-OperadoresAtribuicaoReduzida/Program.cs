using System;

namespace _015_OperadoresAtribuicaoReduzida
{
    class Program
    {
        static void Main(string[] args)
        {
            // += -= *= /= %=

            int x = 10;
            int y = 3;

            Console.WriteLine("{0} += {1} = {2}", x, y, x += y); //x = x + y
            Console.WriteLine("{0} -= {1} = {2}", x, y, x -= y); //x = x - y
            Console.WriteLine("{0} *= {1} = {2}", x, y, x *= y); //x = x * y
            Console.WriteLine("{0} /= {1} = {2}", x, y, x /= y); //x = x / y
            Console.WriteLine("{0} %= {1} = {2}", x, y, x %= y); //x = x % y
            Console.WriteLine("x = {0}", x);

            Console.ReadKey();
        }
    }
}
