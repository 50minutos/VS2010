using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _114_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "eu escrevi algo nessa string e quero manipular usando LINQ";

            foreach (var item in frase)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var letras = from x in frase
                         select x;
            
            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            
            var vogais = frase.Where<char>(x => "aeiouAEIOU".Contains(x));

            foreach (var item in vogais)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
