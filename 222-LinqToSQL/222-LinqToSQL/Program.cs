using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _222_LinqToSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            //Table<Pessoa> pessoas = dc.GetTable<Pessoa>();

            var pessoas = from p in dc.GetTable<Pessoa>()
                          select p;

            //ObjectDumper.Write(pessoas);

            Console.WriteLine();

            var nomes = from p in pessoas
                        select p.NomePessoa;

            var lista = from p in nomes
                        where p.Equals("ABEL")
                        select p;

            ObjectDumper.Write(lista);

            Console.ReadKey();
        }
    }
}
