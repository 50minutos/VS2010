using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _086_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t;

            t = new Escaleno();
            t.a = 3;
            t.b = 4;
            t.c = 5;

            Console.WriteLine(t);

            t = new Isosceles();
            t.a = t.b = 2;
            t.c = 1;

            Console.WriteLine(t);

            t = new Equilatero();
            t.a = t.b = t.c = 1;

            Console.WriteLine(t);

            Console.ReadKey();
        }
    }

    abstract class Triangulo //abstract indica que a classe não pode ser instanciada
    {
        public double a;
        public double b;
        public double c;

        public double CalcularPerimetro() { return this.a + this.b + this.c; }

        public double CalcularArea() 
        {
            double sp = this.CalcularPerimetro()/2;

            return Math.Sqrt(sp * (sp - this.a) * (sp - this.b) * (sp - this.c));
        }

        public override string ToString()
        {
            return String.Format("Tipo: {0}\n\ta........: {1}\n\tb........: {2}\n\tc........: {3}\n\tárea.....: {4}\n\tperímetro: {5}\n\n", this.GetType().Name, this.a, this.b, this.c, this.CalcularArea(), this.CalcularPerimetro());
        }
    }

    class Equilatero : Triangulo { }
    class Escaleno : Triangulo { }
    class Isosceles : Triangulo { }
}
