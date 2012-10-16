using System;

namespace _030_ArrayMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = { "Bruno", "Antonio (Netinho)", "Pedro", "Agnaldo", "Bruno" };

            Console.WriteLine(Array.IndexOf(nomes, "pedro"));
            Console.WriteLine(Array.IndexOf(nomes, "Bruno"));
            Console.WriteLine(Array.LastIndexOf(nomes, "Bruno"));

            Array.Sort(nomes);
            Array.Reverse(nomes);
            
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
