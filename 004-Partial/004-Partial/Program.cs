
using System;
namespace _004_Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Codigo = 1;
            p.Nome = "ADÃO";
            p.Sexo = 'M';

            p.Acordar();
            p.Comer();
            p.Dormir();

            Console.ReadKey();
        }
    }
}
