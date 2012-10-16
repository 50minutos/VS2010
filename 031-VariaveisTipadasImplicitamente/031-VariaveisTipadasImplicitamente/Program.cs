using System;

namespace _031_VariaveisTipadasImplicitamente
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicitly-typed variable
            //var nome = valor;
            var x = 10; //int x = 10;
            var y = "agnaldo"; //String y = "agnaldo";
            var z = new Object(); //Object z = new Object();
            var p = new Pessoa(); //Pessoa p = new Pessoa();
            var a = new int[]{ 1, 2, 3 }; //int[] a = new int[]{1,2,3}; -> ainda muda no compilado
            Console.WriteLine("{0} -> value type? {1}", x.GetType(), x.GetType().IsValueType);
            Console.WriteLine("{0} -> value type? {1}", y.GetType(), y.GetType().IsValueType);
            Console.WriteLine("{0} -> value type? {1}", z.GetType(), z.GetType().IsValueType);
            Console.WriteLine("{0} -> value type? {1}", p.GetType(), p.GetType().IsValueType);
            Console.WriteLine("{0} -> value type? {1}", a.GetType(), a.GetType().IsValueType);

            Console.ReadKey();
        }
    }

    class Pessoa
    { 
    
    }
}
