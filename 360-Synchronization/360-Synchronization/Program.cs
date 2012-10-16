using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace _360_Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Util u = new Util();

            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(u.Imprimir));
                t.Start();
            }

            Console.ReadKey();
        }
    }

    [Synchronization]
    class Util : ContextBoundObject
    {
        public void Imprimir()
        {
            Console.WriteLine("\nimprimindo");

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in numeros)
                Console.Write("{0} ", item);

            Console.WriteLine();
        }
    }
}