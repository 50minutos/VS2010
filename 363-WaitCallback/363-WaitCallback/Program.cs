using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _363_WaitCallback
{
    class Program
    {
        static void Main(string[] args)
        {
            Util u = new Util();

            WaitCallback wc = new WaitCallback(u.Imprimir);

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(wc);
            }

            Console.WriteLine("10 threads foram enfileiradas");

            Console.ReadKey();
        }
    }

    class Util
    {
        public void Imprimir(Object o)
        {
            Console.WriteLine("\nimprimindo {0}", Thread.CurrentThread.ManagedThreadId);

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in numeros)
                Console.Write("{0} ", item);
        }
    }
}
