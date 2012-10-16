using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _115_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] palavrasDaFrase = "C♯ , também escrito como C# ou C Sharp ( em português lê-se \" cê charp \" ) , é uma linguagem de programação orientada a objetos , fortemente tipada , desenvolvida pela Microsoft como parte da plataforma .NET . A sua sintaxe orientada a objetos foi baseada no C++ mas inclui muitas influências de outras linguagens de programação , como Object Pascal e Java .".Split(' ');

            var palavras = from palavra in palavrasDaFrase
                           orderby palavra.Length //ascending|descending
                           select palavra;

            foreach (var p in palavras)
                Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
