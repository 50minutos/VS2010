using System;

namespace _012_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            //cast
            //(tipoDestino)variavel;

            long l = 10;
            
            int i = (int)l;

            int j = Convert.ToInt32(l);

            int k = Int32.Parse("123");

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            
            Console.ReadKey();
        }
    }
}
