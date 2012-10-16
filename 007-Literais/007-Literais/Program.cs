using System;

namespace _007_Literais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int -> {0}", 10);  //int -> System.Int32 (struct)
            Console.WriteLine("long -> {0}", 10L); //long -> System.Int64 (struct)
            Console.WriteLine("double -> {0}", 10.10); //double -> System.Double (struct)
            Console.WriteLine("float -> {0}", 10.10F); //float -> System.Single (struct)
            Console.WriteLine("decimal -> {0}", 10.10M); //decimal -> System.Decimal (struct)
            Console.WriteLine("char -> {0}", 'x'); //char -> System.Char (struct)
            Console.WriteLine("String -> {0}", "XX"); //string -> System.String (class)
            Console.WriteLine("bool -> {0}", true); //bool -> System.Boolean (struct)
            
            Console.ReadKey();
        }
    }
}
