using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _359_Interlocked
{
    class Program
    {
        static void Main(string[] args)
        {
            Util u = new Util();

            Console.WriteLine(u.x);

            Thread t = new Thread(new ThreadStart(u.Incrementar));
            t.Start();
            Thread.Sleep(500);

            t = new Thread(new ThreadStart(u.Atribuir));
            t.Start();
            Thread.Sleep(500);

            t = new Thread(new ThreadStart(u.AtribuirSe));
            t.Start();
            Thread.Sleep(500);

            t = new Thread(new ThreadStart(u.Decrementar));
            t.Start();
            Thread.Sleep(500);

            t = new Thread(new ThreadStart(u.Somar));
            t.Start();
            Thread.Sleep(500);

            Console.WriteLine(u.x);

            Console.ReadKey();
        }
    }

    class Util
    {
        public int x = 0;

        public void Incrementar()
        {
            Interlocked.Increment(ref this.x);
            Console.WriteLine("Incrementar: {0}", this.x);
        }

        public void Decrementar()
        {
            Interlocked.Decrement(ref this.x);
            Console.WriteLine("Decrementar: {0}", this.x);
        }

        public void Atribuir()
        {
            Interlocked.Exchange(ref this.x, 10);
            Console.WriteLine("Atribuir: {0}", this.x);
        }

        public void AtribuirSe()
        {
            Interlocked.CompareExchange(ref this.x, 100, 10);
            Console.WriteLine("AtribuirSe: {0}", this.x);
        }

        public void Somar()
        {
            Interlocked.Add(ref this.x, 10);
            Console.WriteLine("Somar: {0}", this.x);
        }
    }
}