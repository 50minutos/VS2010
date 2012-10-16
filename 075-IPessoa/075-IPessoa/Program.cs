using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _075_IPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            IPessoa p;
            
            p = new Homem();

            p.Acordar();
            p.Comer();
            ((Homem)p).JogarTruco();
            p.Dormir();

            Console.WriteLine();

            p = new Mulher();

            ((Mulher)p).Falar();
            p.Acordar();
            ((Mulher)p).Falar();
            p.Comer();
            ((Mulher)p).Falar();
            p.Dormir();
            ((Mulher)p).Falar();

            Console.ReadKey();
        }
    }

    interface IPessoa
    {
        void Acordar();
        void Comer();
        void Dormir();
    }

    class Homem : IPessoa
    {
        public void Acordar() { Console.WriteLine("o homem acordou"); }
        public void Comer() { Console.WriteLine("o homem comeu com a boca aberta e falando"); }
        public void Dormir() { Console.WriteLine("o homem dormiu"); }
        public void JogarTruco() { Console.WriteLine("Patão!!!"); }
    }

    class Mulher : IPessoa
    {
        public void Acordar() { Console.WriteLine("a mulher acordou falando"); }
        public void Comer() { Console.WriteLine("a mulher comeu"); }
        public void Dormir() { Console.WriteLine("a mulher quis discutir a relação antes de dormir"); }
        public void Falar() { Console.WriteLine("bla bla bla bla bla bla"); }
    }
}
