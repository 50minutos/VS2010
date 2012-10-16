using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _113_TipoAnonimo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new { codigo = 1, nome = "adão" };
            var p2 = new { codigo = 2, nome = "eva" };
            var p3 = new { codigo = 3, nome = "cobra", comprimento = 1.5 };

            Console.WriteLine("{0} -> {1} - {2} - {3}", p1, p1.GetType().Name, p1.codigo, p1.nome);
            Console.WriteLine("{0} -> {1} - {2} - {3}", p2, p2.GetType().Name, p2.codigo, p2.nome);
            Console.WriteLine("{0} -> {1} - {2} - {3}", p3, p3.GetType().Name, p3.codigo, p3.nome);

            Console.WriteLine();

            Livro[] livros = { new Livro() { Codigo = 1, Titulo = "ABC do TRUCO", Preco = 10.3}, 
                                new Livro() { Codigo = 2, Titulo = "SEJA UM DOUBLE CLICATOR DE SUCESSO", Preco = 20}, 
                                new Livro() { Codigo = 3, Titulo = "ABC do PALITINHO", Preco = 10.32}, 
                                new Livro() { Codigo = 4, Titulo = "C# É FÁCIL", Preco = 110.2} 
                             };

            var dados = from livro in livros
                        select new { livro.Titulo, PrecoDolar = livro.Preco/1.55};

            foreach (var item in dados)
            {
                Console.WriteLine("{0} -> {1}", item.Titulo, item.PrecoDolar);
            }

            Console.ReadKey();
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
        public double Preco { get; set; }
    }
}
