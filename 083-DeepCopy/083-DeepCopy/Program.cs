using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _083_DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { Codigo = 1, Dados = new Dados() { Nome = "Zé", Sexo = 'M' }, Observacao = "uma observação" };
            Pessoa q = p.Clone() as Pessoa;

            q.Codigo = 2;
            q.Dados.Nome = "Ana";
            q.Dados.Sexo = 'F';
            q.Observacao = "alterei a observação";

            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.ReadKey();
        }
    }

    class Dados : ICloneable
    {
        public String Nome { get; set; }
        public char Sexo { get; set; }
      
        public override string ToString()
        {
            return String.Format("{0} -> {1}", this.Nome, this.Sexo);
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Pessoa : ICloneable
    {
        public int Codigo { get; set; }
        public Dados Dados { get; set; }
        public String Observacao { get; set; }
        
        public Object Clone()
        {
            Pessoa tmp = this.MemberwiseClone() as Pessoa;
            tmp.Dados = (Dados)this.Dados.Clone();
            
            return tmp;
        }

        public override string ToString()
        {
            return String.Format("{0} possui os dados: {1} e {2}", this.Codigo, this.Dados, this.Observacao);
        }
    }
}
