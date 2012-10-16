using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _071_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            //boxing
            Object o = x as Object;
            //Object o = (Object)x;

            Console.WriteLine(o);

            Console.WriteLine(o.GetType().Name);

            //unboxing
            int y = Convert.ToInt32(o);
            //int y = Int32.Parse(o.ToString());
            
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
