using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _355_ParameterizedThreadStart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool multiThread = true;

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Util u = new Util(numeros);

            for (int i = 0; i < 3; i++)
            {
                if (multiThread)
                {
                    Thread t = new Thread(new ParameterizedThreadStart(u.Imprimir));
                    t.Start(u);
                }
                else
                {
                    u.Imprimir(u);
                }
            }

            Console.ReadKey();
        }
    }

    class Util
    {
        int[] lista;

        public Util(int[] lista)
        {
            this.lista = lista;
        }

        public void Imprimir(Object o)
        {
            if (o is Util)
                foreach (var item in (o as Util).lista)
                    Console.WriteLine("{0} - {1}", Thread.CurrentThread.ManagedThreadId, item);
        }
    }
}
