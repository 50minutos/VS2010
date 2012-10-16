using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _125_DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> numeros =
                            new Dictionary<int, String>();

            numeros.Add(1, "um");
            numeros.Add(2, "dois");
            numeros.Add(3, "tres");
            numeros.Add(4, "quatro");
            numeros.Add(5, "cinco");
            numeros.Add(6, "seis");
            numeros.Add(7, "sete");
            numeros.Add(8, "oito");
            numeros.Add(9, "nove");
            numeros.Add(10, "dez");

            //6 = 0110 -> 6 & 1 -> 0110 & 0001 = 0000
            //7 = 0111 -> 7 & 1 -> 0111 & 0001 = 0001

            var pares = from numero in numeros
                        where (numero.Key & 1) == 0 //x % 2 == 0
                        select numero.Value;

            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in numeros)
            {
                Console.WriteLine("{0} = {1} -> {2}", item, item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
