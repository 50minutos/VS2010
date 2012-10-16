using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _354_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - início", Thread.CurrentThread.ManagedThreadId);

            bool multiThread = true;

            Util u = new Util();

            for (int i = 0; i < 3; i++)
            {
                if (multiThread)
                {
                    Thread t = new Thread(new ThreadStart(u.Imprimir));
                    t.Start();
                }
                else
                {
                    u.Imprimir();
                }
            }

            Console.WriteLine("{0} - fim", Thread.CurrentThread.ManagedThreadId);

            Console.ReadKey();
        }
    }

    class Util
    {
        public void Imprimir()
        {
            int[] numeros = Enumerable.Range(1, 10).ToArray<int>();

            foreach (var item in numeros)
                Console.WriteLine("{0} - {1}", Thread.CurrentThread.ManagedThreadId, item);
        }
    }
}
