using System;

namespace _020b_OperadorNullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            //se o primeiro valor for null, usa o segundo valor

            String o = null;
            String p = "String p";
            String q = "String q";

            Console.WriteLine(o ?? p ?? q);

            Console.ReadKey();
        }
    }
}
