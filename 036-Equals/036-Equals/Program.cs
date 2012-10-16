using System;

namespace _036_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Object();
            Object p = new Object();
            Object q = o;

            Console.WriteLine(o.Equals(p));
            Console.WriteLine(o.Equals(q));

            Console.WriteLine(Object.Equals(p, q));

            Console.ReadKey();
        }
    }
}
