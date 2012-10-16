using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _085_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("abc");

            sb.Append("xyz");
            sb.Append(" ABC");
            sb.Append("XYZ");

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
