using System;

namespace _042_PessoaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nascer();

            for (int i = 0; i < 3; i++)
            {
                pessoa.Acordar();
                pessoa.Comer();
                pessoa.Dormir();
            }

            pessoa.Morrer();

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public void Acordar() { Console.WriteLine("o pessoa acordou"); }
        public void Comer() { Console.WriteLine("o pessoa comeu"); }
        public void Dormir() { Console.WriteLine("o pessoa dormiu"); }
        public void Nascer() { Console.WriteLine("o pessoa nasceu"); }
        public void Morrer() { Console.WriteLine("o pessoa morreu"); }
    }
}
