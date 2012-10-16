using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _161_MetodoRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000, y = 10;
            
            //só tem sentido ref e out com value type

            Swap(ref x, ref y);

            Console.WriteLine("x = {0} e y = {1}", x, y);

            Console.ReadKey();
        }

        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
