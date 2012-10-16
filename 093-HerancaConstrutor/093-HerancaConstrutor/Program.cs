using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _093_HerancaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero m = new Mamifero("burro");
            m.Nascer();
            m.Mamar();
            m.Morrer();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        private String especie;

        public Animal(String especie)
        {
            this.especie = especie;
        }

        public void Nascer() { Console.WriteLine("o animal nasceu"); }
        public virtual void Morrer() { Console.WriteLine("o animal morreu"); }
    }

    class Mamifero : Animal
    {
        public Mamifero(String especie) : base(especie)
        {
            
        }

        public void Mamar() { Console.WriteLine("o mamifero mamou"); }
        public override void Morrer()
        {
            Console.WriteLine("o mamifero morreu");
        }
    }
}
