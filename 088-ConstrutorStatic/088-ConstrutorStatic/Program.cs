using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _088_ConstrutorStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Classe.PI);

            Console.WriteLine(new Classe().E);

            Console.WriteLine(Classe.numero);

            Console.ReadKey();
        }
    }

    class Classe
    {
        public const double PI = 3.14159; //toda constante é static
        public readonly double E;
        public static int numero;

        public Classe()
        {
            this.E = 2.718281828459045;
        }

        static Classe()
        {
            numero = 1000;
        }
    }
}
