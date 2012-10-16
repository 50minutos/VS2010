using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _090_Destrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto o = new Objeto();

            o = null;

            GC.Collect();

            Console.ReadKey();
        }
    }

    class Objeto
    {
        public Objeto()
        {
            Console.WriteLine("passei no construtor Objeto()");
        }

        ~Objeto() //gera o método Finalize, é chamado pelo GC, não pode ser chamado
        {
            Console.WriteLine("passei no destrutor ~Objeto()");
        }
    }
}
