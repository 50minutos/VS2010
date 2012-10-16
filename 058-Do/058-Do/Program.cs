using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _058_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            do //executa PELO MENOS uma vez
            {
                Console.WriteLine("primeiro: {0}", x++);
            } while (x <= 5);

            do
            {
                Console.WriteLine("segundo: {0}", x++);
            } while (x <= 5);

            Console.ReadKey();
        }
    }
}
