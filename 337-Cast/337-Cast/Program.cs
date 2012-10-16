using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _337_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Object p = new Pessoa() { Nome = "Caim" };

            Console.WriteLine(p);

            Console.WriteLine(((Pessoa)p).Nome);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public String Nome { get; set; }
    }
}
