using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _072_MetodoGenerico
{
    class Program
    {
        class Pessoa
        {
            public String Nome { get; set; }

            public override string ToString()
            {
                return this.Nome;
            }
        }

        class Bola
        {
            public String Esporte { get; set; }

            public override string ToString()
            {
                return this.Esporte;
            }
        }

        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3 };
            String[] palavras = { "ADÃO", "EVA" };
            Pessoa[] pessoas = { new Pessoa() { Nome = "adão" }, new Pessoa() { Nome = "eva" } };
            Bola[] bolas = { new Bola() { Esporte = "tênis de mesa" }, new Bola() { Esporte = "futebol" } };

            Imprimir(numeros);
            Imprimir(palavras);
            Imprimir(pessoas);
            Imprimir(bolas);

            Console.ReadKey();
        }

        private static void Imprimir<T>(T[] colecao)
        {
            Console.WriteLine(colecao.GetType().Name);

            foreach (var item in colecao)
            {
                Console.WriteLine("   {0}", item);
            }

            Console.WriteLine();
        }

        //private static void Imprimir(Bola[] colecao)
        //{
        //    Console.WriteLine(colecao.GetType().Name);

        //    foreach (var item in colecao)
        //    {
        //        Console.WriteLine("   {0}", item);
        //    }

        //    Console.WriteLine();
        //}

        //private static void Imprimir(Pessoa[] colecao)
        //{
        //    Console.WriteLine(colecao.GetType().Name);

        //    foreach (var item in colecao)
        //    {
        //        Console.WriteLine("   {0}", item);
        //    }

        //    Console.WriteLine();
        //}

        //private static void Imprimir(String[] colecao)
        //{
        //    Console.WriteLine(colecao.GetType().Name);

        //    foreach (var item in colecao)
        //    {
        //        Console.WriteLine("   {0}", item);
        //    }

        //    Console.WriteLine();
        //}

        //private static void Imprimir(int[] colecao)
        //{
        //    Console.WriteLine(colecao.GetType().Name);

        //    foreach (var item in colecao)
        //    {
        //        Console.WriteLine("   {0}", item);
        //    }

        //    Console.WriteLine();
        //}
    }
}
