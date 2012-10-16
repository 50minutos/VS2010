using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _137_SortParametrizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a ordem desejada ([N]ome, [I]dade ou [S]exo): ");
            char ordem = Console.ReadLine().ToUpper()[0];

            switch (ordem)
            {
                case 'N': Ordenar(p => p.nome); break;
                case 'I': Ordenar(p => p.idade); break;
                case 'S': Ordenar(p => p.sexo); break;
            }

            Console.ReadKey();
        }

        static void Ordenar<T>(Func<Pessoa, T> seletor)
        {
            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(new Pessoa() { nome = "Adão", sexo = 'M', idade = 30 });
            lista.Add(new Pessoa() { nome = "Eva", sexo = 'F', idade = 30 });
            lista.Add(new Pessoa() { nome = "Caim", sexo = 'M', idade = 1 });
            lista.Add(new Pessoa() { nome = "Abel", sexo = 'M', idade = 1 });

            var pessoas = lista.OrderBy(seletor);

            ObjectDumper.Write(pessoas);
        }
        }

    class Pessoa
    {
        public String nome;
        public char sexo;
        public int idade;
    }
}
