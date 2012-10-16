using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _132_MinMaxCountSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = IteratorProduto.ObterProdutos().Sum(p => p.estoque);

            var produtos = from p in IteratorProduto.ObterProdutos()
                           orderby (p.estoque)
                           select new { p.nome, p.preco, p.estoque, perc = (float)p.estoque / qtd * 100 };

            ObjectDumper.Write(produtos);

            Console.WriteLine();

            Console.WriteLine("menor preço...................: {0:c}\n", produtos.Min(p => p.preco));
            Console.WriteLine("maior preço...................: {0:c}\n", produtos.Max(p => p.preco));
            Console.WriteLine("média dos preços..............: {0:c}\n", produtos.Average(p => p.preco));
            Console.WriteLine("quantidade de peças em estoque: {0}\n", produtos.Sum(p => p.estoque));
            Console.WriteLine("quantidade de itens em estoque: {0}\n", produtos.Count());
            Console.WriteLine("itens com estoque zerado......: {0}", produtos.Count(p => p.estoque == 0));

            Console.WriteLine();
            Console.WriteLine();

            var maisCaros = IteratorProduto.ObterProdutos().OrderByDescending(p => p.preco).Take(2);

            ObjectDumper.Write(maisCaros);

            Console.ReadKey();
        }
    }

    class Produto
    {
        public String nome;
        public double preco;
        public int estoque;
    }

    static class IteratorProduto
    {
        public static IEnumerable<Produto> ObterProdutos()
        {
            yield return new Produto() { nome = "MARTELO", preco = 45.65, estoque = 10 };
            yield return new Produto() { nome = "CHAVE FENDA", preco = 9.8, estoque = 20 };
            yield return new Produto() { nome = "SERROTE", preco = 120.50, estoque = 123 };
            yield return new Produto() { nome = "SARGENTO", preco = 50.50, estoque = 1 };
            yield return new Produto() { nome = "KIT PARAFUSO", preco = 2.50, estoque = 0 };
        }
    }
}
