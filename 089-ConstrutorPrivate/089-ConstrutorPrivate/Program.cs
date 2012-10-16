using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _089_ConstrutorPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuadrilateroRegular qr= new QuadrilateroRegular();
            QuadrilateroRegular.lado = 10;

            Console.WriteLine(QuadrilateroRegular.lado);
            Console.WriteLine(QuadrilateroRegular.CalcularArea());
            Console.WriteLine(QuadrilateroRegular.CalcularPerimetro());

            Console.ReadKey();
        }
    }

    class QuadrilateroRegular
    {
        public static double lado;

        private QuadrilateroRegular()
        {

        }

        public static double CalcularPerimetro() { return 4 * lado; }
        public static double CalcularArea() { return Math.Pow(lado, 2); }
    }
}
