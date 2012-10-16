using System;

namespace _029_ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = { "Bruno", "Antonio (Netinho)", "Pedro", "Agnaldo" };

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Array.Sort(nomes);

            Console.WriteLine();
            
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
