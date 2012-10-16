using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _339_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinamica d = new Dinamica();

            Console.WriteLine(d.Propriedade);
            Console.WriteLine(d.Metodo());

            Console.WriteLine(d.Metodo("eita nóis"));
            Console.WriteLine(d.Metodo(DateTime.Now));

            Console.ReadKey();
        }
    }

    class Dinamica
    {
        private static dynamic campo;

        public dynamic Propriedade { get; set; }

        public dynamic Metodo(dynamic d = null)
        {
            dynamic variavelLocal = d is String ? d.ToUpper() : Dinamica.campo;

            return variavelLocal;
        }

        public Dinamica()
        {
            this.Propriedade = 10;
        }

        static Dinamica()
        {
            Dinamica.campo = 1000;
        }
    }
}
