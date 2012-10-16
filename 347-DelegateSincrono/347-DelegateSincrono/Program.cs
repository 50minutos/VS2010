using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _347_DelegateSincrono
{
    delegate int Operacao(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Operacao o = new Operacao(Somar);

            Console.WriteLine("{0} - {1}", o.Method.Name, o(10, 5));

            o = new Operacao(Subtrair);

            Console.WriteLine("{0} - {1}", o.Method.Name, o.Invoke(10, 5));

            Console.ReadKey();
        }

        static int Somar(int x, int y)
        {
            Console.WriteLine("   estou na Thread {0}", Thread.CurrentThread.ManagedThreadId);
            return x + y;
        }

        static int Subtrair(int x, int y)
        {
            Console.WriteLine("   estou na Thread {0}", Thread.CurrentThread.ManagedThreadId);
            return x - y;
        }
    }
}
