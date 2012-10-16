using System;

namespace _044_Optional
{
    class Program

    {
        static void Main(string[] args)
        {
            Pessoa.Comer("arroz com feijão");
            Pessoa.Comer("pipoca");
            Pessoa.Comer();

            Console.WriteLine(Calculadora.ExtrairRaiz(27, 3));
            Console.WriteLine(Calculadora.ExtrairRaiz(27));
            Console.WriteLine(Calculadora.ExtrairRaiz(indice: 4, numero: 16)); 

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public static void Comer(String oQue = "qualquer coisa"){Console.WriteLine("a pessoa comeu {0}", oQue);}
    }

    class Calculadora
    {
        public static double ExtrairRaiz(double numero, double indice = 2)
        {
            return Math.Pow(numero, 1 / indice);
        }
    }
}
