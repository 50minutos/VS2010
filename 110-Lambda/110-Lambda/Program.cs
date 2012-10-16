using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _110_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //expressão lambda -> in => lógica 

            Func<int, bool> Par = x => x % 2 == 0;
            Func<int, int, int> Somar = (x, y) => x + y;

            Console.WriteLine(Par(Somar(1, 45)));

            Console.WriteLine();

            String[] palavras = "qualquer coisa foi escrita aqui dentro".Split(' ');

            var itens = palavras.Where(x => x.StartsWith("c"));

            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }

            var maisItens = from x in palavras
                            where x.StartsWith("c")
                            select x;

            Console.ReadKey();
        }
    }
}
