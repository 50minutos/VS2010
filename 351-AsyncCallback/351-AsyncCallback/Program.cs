using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _351_AsyncCallback
{
    delegate int Operacao(int x, int y);

    class Program
    {
        static bool terminou = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Operacao o = new Operacao(Somar);

            IAsyncResult iar = o.BeginInvoke(10, 5, new AsyncCallback(OperacaoCompleta), null);

            while (!terminou)
            {
                Thread.Sleep(1000);
                Console.WriteLine("      aguardando...");
            }

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            Console.ReadKey();
        }

        static void OperacaoCompleta(IAsyncResult iar)
        {
            Console.WriteLine("terminou = {0}", terminou = true);
        }

        static int Somar(int x, int y)
        {
            Console.WriteLine("   estou na Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(3000);

            return x + y;
        }
    }
}
