using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _124_AutoImplementedProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Codigo = 1;
            p.Nome = "Adão";
            p.Sexo = 'M';

            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.SexoTexto);

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        //field (campo) deve ser private
        //property (propriedade) pode ser pública

        private int codigo; //backing field
        public int Codigo //property
        {
            get { return this.codigo; }
            set {
                if (value <= 0) throw new ArgumentException("o código deve ser maior que zero");

                this.codigo = value; 
            }
        }

        public String Nome { get; set; } //auto implementadas

        private char sexo;

        public char Sexo
        {
            set 
            {
                if (!"MmFf".Contains(value)) throw new ArgumentException("O sexo deve ser M ou F");
                this.sexo = value; 
            }
        }

        public String SexoTexto
        {
            get 
            {
                return this.sexo == 'M' || this.sexo == 'm' ? "MASC" : "FEM"; 
            }
        }
    }
}
