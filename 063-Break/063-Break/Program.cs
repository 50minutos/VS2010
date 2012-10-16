using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _063_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (true)
            {
                Console.WriteLine(x);

                if (++x > 10)
                    break;
            }

            Console.ReadKey();
        }
    }
}
