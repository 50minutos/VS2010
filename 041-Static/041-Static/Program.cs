using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _041_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { nome = "ADÃO", Sexo = Sexo.masculino };
            Pessoa q = new Pessoa() { nome = "EVA", Sexo = Sexo.feminino };

            Console.WriteLine("{0}\n\t{1}\n\t{2}\n\t{3}", p.nome, p.Sexo, Pessoa.COR_DO_SANGUE, Pessoa.fumante);
            Console.WriteLine("{0}\n\t{1}\n\t{2}\n\t{3}", q.nome, q.Sexo, Pessoa.COR_DO_SANGUE, Pessoa.fumante);

            Console.WriteLine();

            Pessoa.fumante = true;

            Console.WriteLine("{0}\n\t{1}\n\t{2}\n\t{3}", p.nome, p.Sexo, Pessoa.COR_DO_SANGUE, Pessoa.fumante);
            Console.WriteLine("{0}\n\t{1}\n\t{2}\n\t{3}", q.nome, q.Sexo, Pessoa.COR_DO_SANGUE, Pessoa.fumante);

            Console.ReadKey();
        }
    }

    enum Sexo
    {
        masculino, 
        feminino
    }

    class Pessoa
    {
        public const String COR_DO_SANGUE = "vermelho";
        
        public String nome;
        public Sexo Sexo;

        public static bool fumante;
    }
}
