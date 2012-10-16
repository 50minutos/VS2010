using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _046_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(x += 0.1);
            }

            Console.ReadKey();
        }
    }
}
