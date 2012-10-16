using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _250_GAC;

namespace _251_UsaGAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Codigo = 1, Nome = "Adão" };

            Console.WriteLine(p);

            Calculadora c = new Calculadora();

            Console.WriteLine(c.Somar(1, 2));
            Console.WriteLine(c.Subtrair(1, 2));

            Console.ReadKey();
        }
    }
}
