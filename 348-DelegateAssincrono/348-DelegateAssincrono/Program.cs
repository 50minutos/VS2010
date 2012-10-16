using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _348_DelegateAssincrono
{
    delegate int Operacao(int x, int y);
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Operacao o = new Operacao(Somar);

            IAsyncResult iar = o.BeginInvoke(10, 5, null, null);

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            o = new Operacao(Subtrair);

            iar = o.BeginInvoke(10, 5, null, null);

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            Console.ReadKey();
        }

        static int Somar(int x, int y)
        {
            Console.WriteLine("   chamado pela Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(3000);

            return x + y;
        }

        static int Subtrair(int x, int y)
        {
            Console.WriteLine("   chamado pela Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(1000);

            return x - y;
        }
    }
}