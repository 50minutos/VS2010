using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _073_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, -4, 5, -659, 545 };
            Array.Sort(numeros);

            foreach (var item in numeros)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine();

            String[] nomes = { "adão", "eva", "caim", "abel" };
            Array.Sort(nomes);

            foreach (var item in nomes)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            Console.WriteLine();

            DateTime[] datas = { new DateTime(1966, 9, 12), DateTime.Now, new DateTime(2000, 1, 1) };
            Array.Sort(datas);

            foreach (var item in datas)
            {
                Console.Write("{0} ", item.ToShortDateString());
            }

            Console.WriteLine();
            Console.WriteLine();

            Pessoa[] pessoas = {
                               new Pessoa(){Nome = "adão"}, 
                               new Pessoa(){Nome = "eva"}, 
                               new Pessoa(){Nome = "caim"}, 
                               new Pessoa(){Nome = "abel"} 
                               };

            Array.Sort(pessoas);

            foreach (var item in pessoas)
            {
                Console.Write("{0} ", item.Nome);
            }

            Console.WriteLine();
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }

    //class Pessoa : IComparable
    class Pessoa : IComparable<Pessoa>
    {
        public String Nome { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Pessoa outra = obj as Pessoa;

        //    return this.Nome.CompareTo(outra.Nome);
        //}

        public int CompareTo(Pessoa other)
        {
            return this.Nome.CompareTo(other.Nome);
        }
    }
}
