using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _076_IVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            
            c.Ano = 2011;
            c.Marca = "Honda";
            c.Modelo = "Civic";
            c.Combustivel = "gas";

            Imprimir(c);

            Aviao a = new Aviao();
            a.Ano = 1943;
            a.Marca = "Boing";
            a.Modelo = "B-52";
            a.Combustivel = "que";

            Imprimir(a);

            Console.ReadKey();
        }

        private static void Imprimir(IVeiculo v)
        {
            Console.WriteLine(v.GetType().Name);
            
            Console.WriteLine("   {0}", v.Ano);
            Console.WriteLine("   {0}", v.Marca);
            Console.WriteLine("   {0}", v.Modelo);
            Console.WriteLine("   {0}", v.Combustivel);
            
            Console.WriteLine();
        }
    }

    interface IVoador
    {
        void Voar();
    }

    interface IVeiculo
    {
        int Ano { get; set; }
        String Marca { get; set; }
        String Modelo { get; set; }
        String Combustivel { get; set; }

        void Ligar();
        void Desligar();
    }

    class Carro : IVeiculo
    {
        public int Ano { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Combustivel { get; set; }

        public void Ligar() { Console.WriteLine("ligou"); }
        public void Desligar() { Console.WriteLine("desligou"); }
    }

    class Aviao : IVeiculo, IVoador
    {
        public int Ano { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Combustivel { get; set; }

        public void Ligar() { Console.WriteLine("ligou"); }
        public void Desligar() { Console.WriteLine("desligou"); }

        public void Voar() { Console.WriteLine("voou"); }
    }
}
