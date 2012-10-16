using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _135_GroupByMultiplosCriterios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            
            lista.Add(new Pessoa() { nome = "Adão", sexo = 'M', idade = 30 });
            lista.Add(new Pessoa() { nome = "Eva", sexo = 'F', idade = 30 });
            lista.Add(new Pessoa() { nome = "Caim", sexo = 'M', idade = 1 });
            lista.Add(new Pessoa() { nome = "Abel", sexo = 'M', idade = 1 });

            var pessoasPorSexo = from p in lista
                                 group p by p.sexo; //critério único

            ObjectDumper.Write(pessoasPorSexo, 1);
            Console.WriteLine();

            //foreach (var colecao in pessoasPorSexo)
            //{
            //    foreach (var pessoa in colecao)
            //    {
            //        Console.WriteLine(pessoa.nome);
            //    }
            //}

            var pessoasPorSexoPorIdade = from p in lista
                                         group p by new { p.sexo, p.idade };

            ObjectDumper.Write(pessoasPorSexoPorIdade, 1);
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public String nome;
        public char sexo;
        public int idade;
    }
}
