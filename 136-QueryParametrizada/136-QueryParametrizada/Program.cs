using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _136_QueryParametrizada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o sexo (M ou F): ");
            char sexo = Console.ReadLine().ToUpper()[0];

            List<Pessoa> lista = new List<Pessoa>();
            
            lista.Add(new Pessoa() { nome = "Adão", sexo = 'M', idade = 30 });
            lista.Add(new Pessoa() { nome = "Eva", sexo = 'F', idade = 30 });
            lista.Add(new Pessoa() { nome = "Caim", sexo = 'M', idade = 1 });
            lista.Add(new Pessoa() { nome = "Abel", sexo = 'M', idade = 1 });

            var pessoasPorSexo = from p in lista
                                 where p.sexo == sexo
                                 select p;

            ObjectDumper.Write(pessoasPorSexo);

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
