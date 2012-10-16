using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _133_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = from p in IteratorProduto.ObterProdutos()
                           orderby p.tipo, p.estoque descending, p.nome
                           select p;

            ObjectDumper.Write(produtos);
            Console.WriteLine();

            var maisProdutos = IteratorProduto.ObterProdutos()
                .OrderBy(p => p.tipo)
                .ThenByDescending(p => p.estoque)
                .ThenBy(p => p.nome)
                .Select(p => p);

            ObjectDumper.Write(maisProdutos);
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    class Produto
    {
        public String tipo;
        public String nome;
        public double preco;
        public int estoque;
    }

    static class IteratorProduto
    {
        public static IEnumerable<Produto> ObterProdutos()
        {
            yield return new Produto() { tipo = "FERRAMENTA", nome = "MARTELO", preco = 45.65, estoque = 20 };
            yield return new Produto() { tipo = "FERRAMENTA", nome = "CHAVE FENDA", preco = 9.8, estoque = 20 };
            yield return new Produto() { tipo = "FERRAMENTA", nome = "SERROTE", preco = 120.50, estoque = 123 };
            yield return new Produto() { tipo = "FERRAMENTA", nome = "SARGENTO", preco = 50.50, estoque = 1 };
            yield return new Produto() { tipo = "FERRAMENTA", nome = "KIT PARAFUSO", preco = 2.50, estoque = 0 };
            yield return new Produto() { tipo = "MÓVEL", nome = "CADEIRA", preco = 150.09, estoque = 10 };
            yield return new Produto() { tipo = "MÓVEL", nome = "MESA", preco = 2.50, estoque = 2 };
        }
    }
}