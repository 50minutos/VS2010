using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _123_TypedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = 
            {
                new Pessoa { Codigo = 1, Nome = "Adão" }, 
                new Pessoa{Codigo = 2, Nome = "Eva"}, 
                new Pessoa{Codigo = 3, Nome = "Caim"}, 
                new Pessoa{Codigo = 4, Nome = "Abel"} 
            };

            var filhos = pessoas
                .Where(pessoa => pessoa.Codigo > 2);

            foreach (var item in filhos)
            {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine();

            var nomes = pessoas
                .Where(pessoa => pessoa.Codigo > 2)
                .Select(pessoa => pessoa.Nome);

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome{ get; set; }
    }
}
