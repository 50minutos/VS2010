using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _091_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Objeto o = new Objeto())
            {
                Console.WriteLine("  dentro do using");
            }

            GC.Collect();

            Console.ReadKey();
        }
    }

    class Objeto : IDisposable
    {
        public Objeto()
        {
            Console.WriteLine("passei no construtor Objeto()");
        }

        public void Dispose()
        {
            Console.WriteLine("passei no Dispose()");
        }

        ~Objeto()
        {
            Console.WriteLine("passei no destrutor ~Objeto()");
        }
    }
}
