using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _361_TimerCallback
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerCallback tc = new TimerCallback(Imprimir);

            Timer t = new Timer(tc, "estado", 0, 1000);

            Console.ReadKey();
        }

        static void Imprimir(Object o)
        {
            Console.WriteLine("{0} - {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), o);
        }
    }
}
