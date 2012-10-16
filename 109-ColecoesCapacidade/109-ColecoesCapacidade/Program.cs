using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _109_ColecoesCapacidade
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarLista();

            Console.WriteLine();

            MostrarHashSet();

            Console.ReadKey();
        }

        private static void MostrarHashSet()
        {
            HashSet<String> hashSet = new HashSet<String>();
            Imprimir(hashSet);

            hashSet.Add("agnaldo");
            hashSet.Add("agnaldo");
            hashSet.Add("agnaldo");
            hashSet.Add("agnaldo");
            hashSet.Add("agnaldo");

            Imprimir(hashSet);
        }

        private static void MostrarLista()
        {
            List<String> list = new List<String>();

            Imprimir(list);

            Console.WriteLine();

            list.Add("agnaldo");

            Imprimir(list);

            Console.WriteLine();

            list.Add("agnaldo");
            list.Add("agnaldo");
            list.Add("agnaldo");
            list.Add("agnaldo");

            Imprimir(list);

            list.TrimExcess();

            Console.WriteLine();

            Imprimir(list);

            Console.WriteLine();

            list.Add("agnaldo");

            Imprimir(list);
        }

        static void Imprimir(List<String> t)
        {
            Console.WriteLine("tipo: {0}", t.GetType().Name);
            Console.WriteLine("capacidade: {0}", t.Capacity);
            Console.WriteLine("quantidade de elementos: {0}", t.Count);
        }

        static void Imprimir(HashSet<String> t)
        {
            Console.WriteLine("tipo: {0}", t.GetType().Name);
            Console.WriteLine("quantidade de elementos: {0}", t.Count);
        }
    }
}
