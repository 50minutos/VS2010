using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _356
{
    class Program
    {
        static void Main(string[] args)
        {
            //para mostrar: [CTRL] + [F5]

            Util u = new Util();

            Thread t = new Thread(new ThreadStart(u.Imprimir));

            t.IsBackground = false;

            t.Start();
        }
    }

    class Util
    {
        public void Imprimir()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 50; i++)
                foreach (var item in numeros)
                    Console.Write("{0} ", item);
        }
    }
}
