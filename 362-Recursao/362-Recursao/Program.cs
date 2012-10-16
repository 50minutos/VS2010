using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _362_Recursao
{
    class Program
    {
        static void Main(string[] args)
        {
            //fatorial tem pior desempenho para MUITAS execuções
            Stopwatch s = new System.Diagnostics.Stopwatch();

            s.Start();
            Console.WriteLine("{0:n0}", FatorialP(10));
            Console.WriteLine(s.ElapsedTicks);
            
            s.Reset();

            s.Start();
            Console.WriteLine("{0:n0}", FatorialR(10));
            Console.WriteLine(s.ElapsedTicks);
            
            Console.ReadKey();
        }

        static int FatorialP(int x)
        {
            int f = 1;

            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }

            return f;
        }

        static int FatorialR(int x)
        {
           return x <= 1 
               ? 1
               : x * FatorialR(x - 1);
        }
    }
}
