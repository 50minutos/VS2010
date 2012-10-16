using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _069_MetodoOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;

            int z;

            Somar(x, y, out z);

            Console.WriteLine(z);

            Console.ReadKey();
        }

        private static void Somar(int x, int y, out int z)
        {
            z = x + y;
        }
    }
}
