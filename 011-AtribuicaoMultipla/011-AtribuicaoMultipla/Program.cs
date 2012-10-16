using System;

namespace _011_AtribuicaoMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            short s;
            int i;
            long l;

            //b = s = i = l = 10;

            l = i = s = b = 10;

            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(l);
            
            Console.ReadKey();
        }
    }
}
