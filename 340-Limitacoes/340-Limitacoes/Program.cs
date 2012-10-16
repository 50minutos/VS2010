using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _340_Limitacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo(typeof(Program));
            Metodo("texto");

            int[] x = { 1, 2, 3, 4, 5, 6 };

            foreach (var item in x)
                Metodo(item);
            //  Metodo(item => item);

            //Metodo(null);
            //Metodo(Metodo.GetType());

            Console.ReadKey();
        }

        static void Metodo(dynamic d)
        {
            Console.WriteLine(d);

            //foreach (var item in from x in d select x)
            //    Console.WriteLine(item);
        }
    }
}
