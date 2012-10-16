using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _062_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x++ < 10)
            {
                if (x % 2 != 0)
                    continue;
                
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
