using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _077_ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f;

            f = new Triangulo();
            f.X = 1;
            f.Imprimir();

            f = new Quadrado();
            f.X = 2;
            f.Imprimir();

            f = new Pentagono();
            f.X = 1;
            f.Imprimir();

            f = new Circulo();
            f.X = 1;
            f.Imprimir();

            Console.ReadKey();

        }
    }

    abstract class Figura //abstract indica que a classe NÃO PODE ser instanciada
    {
        public double X { get; set; }

        public abstract double CalcularArea(); //abstract indica que o método NÃO tem implementação e DEVE ser sobreposto
        public abstract double CalcularPerimetro();

        public void Imprimir()
        {
            Console.WriteLine(this.GetType().Name);

            Console.WriteLine("   medida.......: {0}", this.X);
            Console.WriteLine("   área.........: {0}", this.CalcularArea());
            Console.WriteLine("   perímetro....: {0}", this.CalcularPerimetro());

            Console.WriteLine();
        }
    }

    class Quadrado : Figura
    {
        public override double CalcularArea() { return Math.Pow(this.X, 2); } //override indica que estamos sobrepondo o método da classe base
        public override double CalcularPerimetro() { return this.X * 4; }
    }

    class Circulo : Figura
    {
        public override double CalcularArea() { return Math.PI * Math.Pow(this.X, 2); }
        public override double CalcularPerimetro() { return 2 * Math.PI * this.X; }
    }

    class Pentagono : Figura
    {
        public override double CalcularArea() { return (Math.Pow(this.X, 2) * Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 4; }
        public override double CalcularPerimetro() { return 5 * this.X; }
    }

    class Triangulo : Figura //Equilatero
    {
        public override double CalcularArea()
        {
            double sp = this.CalcularPerimetro() / 2;

            return Math.Sqrt(sp * Math.Pow(sp - this.X, 3));
        }

        public override double CalcularPerimetro() { return 3 * this.X; }
    }
}
