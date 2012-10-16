using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using _243_CalculadoraDLL;

namespace _244_ClienteCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            int x = 10, y = 3;

            Console.WriteLine(c.Somar(x, y));
            Console.WriteLine(c.Subtrair(x, y));
            Console.WriteLine(c.Multiplicar(x, y));
            Console.WriteLine(c.Dividir(x, y));

            Console.ReadKey();
        }
    }
}
