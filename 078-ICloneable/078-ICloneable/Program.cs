using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _078_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa() { Nome = "Adão" };
            Pessoa y = x;
            Pessoa z = x.Clone() as Pessoa;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }

    class Pessoa : ICloneable
    {
        public String Nome { get; set; }

        public Object Clone()
        {
            return this.MemberwiseClone(); //shallow copy
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", this.GetHashCode(), this.Nome) ;
        } 
    }
}
