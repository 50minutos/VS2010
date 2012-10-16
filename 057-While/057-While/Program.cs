using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _057_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 5) //pode não executar
            {
                Console.WriteLine("primeiro: {0}", x++);
            }

            while (x <= 5)
            {
                Console.WriteLine("segundo: {0}", x++);
            }

            Console.ReadKey();
        }
    }
}
