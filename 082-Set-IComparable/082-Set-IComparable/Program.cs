using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _082_Set_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<Pessoa> pessoas = new MyList<Pessoa>()
            {
                new Pessoa(){ Nome = "Eva"}, 
                new Pessoa(){ Nome = "Adão"}, 
                new Pessoa(){ Nome = "Adão"} 
            };

            pessoas.Sort();

            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Pessoa : IComparable<Pessoa>
    {
        public String Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

        #region Para eliminar os repetidos

        public override int GetHashCode()
        {
            return this.Nome.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Nome.Equals((obj as Pessoa).Nome);
        }
        
        #endregion

        #region Para permitir o .Sort()

        public int CompareTo(Pessoa other)
        {
            return this.Nome.CompareTo(other.Nome);
        }

        #endregion
    }

    class MyList<T> : List<T>
    {
        public new void Add(T item)//new indica o desejo de se forçar uma sobreposição
        {
            if (!this.Contains<T>(item))
            {
                base.Add(item);
            }
        }
    }
}
