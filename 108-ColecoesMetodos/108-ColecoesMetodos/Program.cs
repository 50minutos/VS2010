using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _108_ColecoesMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nomes = new List<String>() { "epaminondas", "eva", "chico", "tião", "eva" };

            List<String> outrosNomes = new List<String>() { "adão", "eva", "agnaldo" };

            Console.WriteLine("quantidade de elementos: {0}", nomes.Count);
            Console.WriteLine("posição da 1a. \"eva\" dentro da lista: {0}", nomes.IndexOf("eva"));
            Console.WriteLine("posição da última \"eva\" dentro da lista: {0}", nomes.LastIndexOf("eva"));

            Console.WriteLine();

            nomes.Remove("chico");

            nomes.RemoveAll(x => x.Contains('e'));

            nomes.AddRange(outrosNomes);

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            nomes.Sort();

            nomes.ForEach(new Action<string>(Imprimir));

            Console.ReadKey();
        }

        static void Imprimir(String x) { Console.WriteLine("-> {0}", x); }
    }
}
