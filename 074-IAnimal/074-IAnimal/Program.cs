using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _074_IAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            
            a.Nascer();
            a.Acordar();
            a.Comer();
            a.Dormir();
            a.Morrer();

            IAnimal iAnimal;
            //iAnimal = new IAnimal();

            iAnimal = new Animal();

            iAnimal.Nascer();
            iAnimal.Morrer();

            (iAnimal as Animal).Acordar();
            (iAnimal as Animal).Comer();
            (iAnimal as Animal).Dormir();

            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        void Nascer(); //membros NÃO tem visibilidade definida aqui!!!
        void Morrer();
    }

    class Animal : IAnimal
    {
        public void Nascer() { Console.WriteLine("O animal nasceu"); }
        public void Morrer() { Console.WriteLine("O animal morreu"); }

        public void Acordar() { Console.WriteLine("O animal acordou"); }
        public void Comer() { Console.WriteLine("O animal comeu"); }
        public void Dormir() { Console.WriteLine("O animal dormiu"); }
    }
}
