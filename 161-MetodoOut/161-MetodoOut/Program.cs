using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _161_MetodoOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int sub;
 
            Somar(10, 20, out soma, out sub);

            Console.WriteLine(soma);
            Console.WriteLine(sub);

            Console.ReadKey();
        }

        static void Somar(int x, int y, out int soma, out int sub)
        {
            soma = x + y;
            sub = x - y;
        }
    }
}
