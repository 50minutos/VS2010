using System;

namespace _020a_OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //condição ? true : false

            var x = new Random();
            var i = 10;

            Console.WriteLine("{0} -> {1} type", x.GetType(), x.GetType().IsValueType ? "value" : "reference");
            Console.WriteLine("{0} -> {1} type", i.GetType(), i.GetType().IsValueType ? "value" : "reference");

            Console.ReadKey();
        }
    }
}
