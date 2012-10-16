using System;

namespace _043_MetodoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 3;

            Console.WriteLine(CalculadoraStatic.Somar(x, y));
            Console.WriteLine(CalculadoraStatic.Subtrair(x, y));
            Console.WriteLine(CalculadoraStatic.Multiplicar(x, y));
            Console.WriteLine(CalculadoraStatic.Dividir(x, y));

            Console.WriteLine();

            Calculadora c = new Calculadora() { a = 10, b = 3 };

            Console.WriteLine(c.Somar());
            Console.WriteLine(c.Subtrair());
            Console.WriteLine(c.Multiplicar());
            Console.WriteLine(c.Dividir());

            Console.ReadKey();
        }
    }

    class CalculadoraStatic
    {
        public static double Somar(double a, double b) { return a + b; }
        public static double Subtrair(double a, double b) { return a - b; }
        public static double Multiplicar(double a, double b) { return a * b; }
        public static double Dividir(double a, double b) { return a / b; }
    }

    class Calculadora
    {
        public double a;
        public double b;

        public double Somar() { return this.a + this.b; }
        public double Subtrair() { return this.a - this.b; }
        public double Multiplicar() { return this.a * this.b; }
        public double Dividir() { return this.a / this.b; }
    }
}
