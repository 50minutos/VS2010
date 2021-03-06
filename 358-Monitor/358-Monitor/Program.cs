﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _358_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Util u = new Util();

            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(u.Imprimir));
                t.Start();
            }

            Console.ReadKey();
        }
    }

    class Util
    {
        private Object objLock = new Object();

        public void Imprimir()
        {
            Monitor.Enter(objLock);
            
            Console.WriteLine("\nimprimindo");

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in numeros)
                Console.Write("{0} ", item);

            Console.WriteLine();

            Monitor.Exit(objLock);
        }
    }
}