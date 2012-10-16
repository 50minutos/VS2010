using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _338_Runtime
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = "Adão";

            Console.WriteLine(x.ToUpper());
            //Console.WriteLine(x.ToMaisOuMenos());
            Console.WriteLine(x.ToLower());

            Console.ReadKey();
        }
    }
}
