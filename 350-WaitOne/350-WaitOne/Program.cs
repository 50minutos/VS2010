using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _350_WaitOne
{
    delegate int Operacao(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Operacao o = new Operacao(Somar);

            IAsyncResult iar = o.BeginInvoke(10, 5, null, null);

            while (!iar.AsyncWaitHandle.WaitOne(1000, true))
                Console.WriteLine("      aguardando...");

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            o = new Operacao(Subtrair);

            iar = o.BeginInvoke(10, 5, null, null);

            while (!iar.AsyncWaitHandle.WaitOne(5000, true))
                Console.WriteLine("      aguardando...");

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            Console.ReadKey();
        }

        static int Somar(int x, int y)
        {
            Console.WriteLine("   estou na Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(6000);

            return x + y;
        }

        static int Subtrair(int x, int y)
        {
            Console.WriteLine("   estou na Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(6000);

            return x - y;
        }
    }
}