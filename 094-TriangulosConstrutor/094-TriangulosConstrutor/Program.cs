using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _094_TriangulosConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t;
            
            t = CriarTriangulo();

            Imprimir(t);

            Console.ReadKey();
        }

        private static void Imprimir(Triangulo t)
        {
            Console.WriteLine(t.GetType().Name);
            
            Console.WriteLine(t.a);
            Console.WriteLine(t.b);
            Console.WriteLine(t.c);

            Console.WriteLine();
        }

        private static Triangulo CriarTriangulo()
        {
            Triangulo retorno = null;

            Random r = new Random();

            switch (r.Next(1,4))
            {
                case 1: retorno = new Escaleno(3, 4, 5); break;
                case 2: retorno = new Equilatero(1); break;
                case 3: retorno = new Isosceles(2, 1); break;
            }

            return retorno;
        }
    }

    abstract class Triangulo
    {
        public double a;
        public double b;
        public double c;

        public Triangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class Escaleno : Triangulo
    {
        public Escaleno(double a, double b, double c) : base(a, b, c) { }
    }

    class Equilatero : Triangulo 
    {
        public Equilatero(double lado) : base(lado, lado, lado) { }
    }

    class Isosceles : Triangulo
    {
        public Isosceles(double iguais, double diferente) : base(iguais, iguais, diferente) { }
    }
}
