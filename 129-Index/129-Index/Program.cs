using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _129_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[]{
                new Pessoa(){nome="Agnaldo"}, 
                new Pessoa(){nome="Zé"}, 
                new Pessoa(){nome="Chico"}, 
                new Pessoa(){nome="Tião"}
            };

            //var pessoasComIndice = pessoas
            //    .OrderBy(pessoa => pessoa.nome)
            //    .Select((pessoa, index) => new { index, pessoa.nome });

            var pessoasComIndice = pessoas
                .Select((pessoa, index) => new { index, pessoa.nome })
                .OrderBy(pessoa => pessoa.nome);

            foreach (var item in pessoasComIndice)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public String nome;
    }
}
