using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _127_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[] { 
                new Pessoa() { Codigo = 1, Nome = "Adao", Sexo='M' }, 
                new Pessoa() { Codigo = 2, Nome = "Eva", Sexo='F' },
                new Pessoa() { Codigo = 3, Nome = "Caim", Sexo='M' }, 
                new Pessoa() { Codigo = 4, Nome = "Abel", Sexo='M' } 
            };

            var homens = pessoas
                .Where(pessoa => pessoa.Sexo == 'M');

            ObjectDumper.Write(homens);

            Console.WriteLine();

            var mulheres = from p in pessoas
                           where p.Sexo == 'F'
                           select p;

            ObjectDumper.Write(mulheres);

            Console.ReadKey();

        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get;set; }
        public char Sexo { get;set; }
    }
}
