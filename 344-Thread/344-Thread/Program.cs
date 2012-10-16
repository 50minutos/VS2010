using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _344_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;

            Console.WriteLine("culture...: {0}", t.CurrentCulture);
            Console.WriteLine("UI culture: {0}", t.CurrentUICulture);
            Console.WriteLine("id........: {0}", t.ManagedThreadId);
            Console.WriteLine("prioridade: {0}", t.Priority);

            Console.WriteLine("nome......: {0}", t.Name);
            t.Name = "Thread principal";
            Console.WriteLine("nome......: {0}", t.Name);

            Console.ReadKey();
        }
    }
}
