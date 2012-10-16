using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace _353_AsyncState
{
    delegate int Operacao(int x, int y);

    class Program
    {
        static bool terminou = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Operacao o = new Operacao(Somar);

            IAsyncResult iar = o.BeginInvoke(10, 5, new AsyncCallback(OperacaoCompleta), "uma string qualquer");

            while (!terminou)
            {
                Console.WriteLine("      aguardando...");
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        static void OperacaoCompleta(IAsyncResult iar)
        {
            AsyncResult ar = (AsyncResult)iar;

            Operacao o = (Operacao)ar.AsyncDelegate;

            Console.WriteLine("{0} - {1}", o.Method.Name, o.EndInvoke(iar));

            String mensagem = iar.AsyncState.ToString();

            Console.WriteLine("mensagem: {0}", mensagem);

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