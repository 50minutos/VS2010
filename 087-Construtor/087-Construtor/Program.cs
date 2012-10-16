using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _087_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto o = new Objeto();
            Imprimir(o);

            Objeto p = new Objeto(10, "opa", 'Y', true, DateTime.Now);
            Imprimir(p);

            Console.ReadKey();
        }

        private static void Imprimir(Objeto o)
        {
            Console.WriteLine(o.i);
            Console.WriteLine(o.s);
            Console.WriteLine(o.c);
            Console.WriteLine(o.b);
            Console.WriteLine(o.d);
            Console.WriteLine();
        }
    }

    class Objeto
    {
        public int i;
        public String s;
        public char c;
        public bool b;
        public DateTime d;

        public Objeto() //construtor com a mesma assinatura do construtor default
        {
            this.d = DateTime.Now;
        }

        public Objeto(int i, String s, char c, bool b, DateTime d)
        {
            this.i = i;
            this.s = s;
            this.c = c;
            this.b = b;
            this.d = d;
        }
    }
}
