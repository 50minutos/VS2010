using System;

using DLL;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
           Texto t = new Texto();

           Console.WriteLine(t.Gerar());

           Console.ReadKey();
        }
    }
}
