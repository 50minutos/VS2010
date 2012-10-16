using System;

namespace _045_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Somadora s = new Somadora();

            Console.WriteLine(s.Somar(1, 3));
            Console.WriteLine(s.Somar(1.0, 3.45));

            Console.WriteLine(s.Somar(1, 14.56));
            Console.WriteLine(s.Somar(1.5F, 14.56F));

            Console.ReadKey();
        }
    }

    class Somadora
    {
        //métodos sobrecarregados -> assinaturas únicas (nome e tipos dos argumentos)
        public int Somar(int x, int y) { return x + y; } //Somar(int, int)
        public double Somar(double x, double y) { return x + y; } //Somar(double, double)
    }
}
