using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _124_ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>() {
                new Livro(){Titulo = "SQL é fácil"}, 
                new Livro(){Titulo = "Acesso a dados com C# - LINQ"}, 
                new Livro(){Titulo = "LINQ sem mistério"}, 
                new Livro(){Titulo = "LINQ to SQL"}, 
                new Livro(){Titulo = "ABC do Truco"}
            };

            var livrosDeLINQ = livros
                               .Where(livro => livro.Titulo.Contains("LINQ"));

            foreach (var item in livrosDeLINQ)
            {
                Console.WriteLine(item.Titulo);
            }

            Console.ReadKey();
        }
    }

    class Livro
    {
        public string Titulo { get; set; }
    }
}