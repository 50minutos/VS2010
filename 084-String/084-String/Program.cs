using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _084_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //String é imutável
            String x = "abc";

            x = x.ToUpper();
            x = x.ToLower();
            x += "xyz";

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
