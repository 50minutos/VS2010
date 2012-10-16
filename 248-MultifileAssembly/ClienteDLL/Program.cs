using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilitarios;

namespace ClienteDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Codigo = 1;
            p.Nome = "Adão";

            Console.WriteLine("{0} - {1}", p.Codigo, p.Nome);

            Carro c = new Carro() { Marca = "VW", Modelo = "Fusca" };

            Console.WriteLine("{0} - {1}", c.Marca, c.Modelo);

            Console.WriteLine(new Data().Hoje());

            Console.ReadKey();
        }
    }
}
