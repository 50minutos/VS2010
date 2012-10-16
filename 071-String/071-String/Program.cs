using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _071_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Object();
            Object p = new Object();

            Console.WriteLine(o.Equals(p));

            String a = new String(new char[] {'a', 'g', 'n', 'a', 'l', 'd', 'o'});
            String b = "agnaldo";

            Console.WriteLine(a.Equals(b));

            Console.ReadKey();
        }
    }
}
