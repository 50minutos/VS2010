using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _081_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> nomes = new HashSet<string>();

            nomes.Add("Marcelinho");
            nomes.Add("Leandro");
            nomes.Add("Felipe");
            nomes.Add("Flávio");
            nomes.Add("Rafael");
            nomes.Add("Felipe");
            nomes.Add("Flávio");
            nomes.Add("Felipe");
            nomes.Add("Flávio");
            nomes.Add("Felipe");
            nomes.Add("Flávio");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
