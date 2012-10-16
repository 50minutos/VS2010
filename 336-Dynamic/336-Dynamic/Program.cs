using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _336_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;

            //x = "uma string";

            //-----------------------------

            String nome = "Adão";
            dynamic variavel = "São Paulo";

            Console.WriteLine(nome.GetType());
            Console.WriteLine(variavel.GetType());

            variavel = 10;
            Console.WriteLine(variavel.GetType());

            variavel = 10.54;
            Console.WriteLine(variavel.GetType());

            variavel = true;
            Console.WriteLine(variavel.GetType());

            Console.ReadKey();
        }
    }
}
