using System;
using System.Collections.Generic;
using System.Text;

namespace _049_MetodoDeExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = "odlanga";

            Console.WriteLine(x.Inverter());

            int[] i = { 12, 23, 3, 4, 56 };

            i.Imprimir();

            Console.ReadKey();
        }
    }

    static class Helper //classe static para o método de extensão
    {
        public static String Inverter(this String s) //método static
        {
            String retorno = String.Empty;

            foreach (var item in s)
            {
                retorno = item + retorno;
            }

            return retorno;
        }

        public static void Imprimir(this int[] numeros)
        {
            Console.WriteLine("----------------------");

            foreach (var item in numeros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n----------------------");
        }
    }
}
