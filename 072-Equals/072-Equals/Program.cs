using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _072_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Codigo = 1, Nome = "chico" };
            Pessoa q = new Pessoa() { Codigo = 2, Nome = "chico" };

            Console.WriteLine(p.Equals(q));

            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(q.GetHashCode());
            
            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public override bool Equals(object obj)
        {
            Pessoa outra = obj as Pessoa;

            return this.Nome.Equals(outra.Nome) && this.Codigo == outra.Codigo;
        }

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode() + this.Codigo;
        }
    }
}
