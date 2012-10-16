using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _059_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //sempre "zera" a variável
            {
                Console.WriteLine("primeiro: {0}", i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("segundo: {0}", i);
            }

            Console.ReadKey();
        }
    }
}
