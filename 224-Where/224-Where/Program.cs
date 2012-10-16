using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _224_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            List<Pessoa> pessoas = dc.GetTable<Pessoa>().ToList<Pessoa>();

            var mulheres = from p in pessoas
                           where p.SexoPessoa == 'F'
                           select p;

            ObjectDumper.Write(mulheres);

            Console.WriteLine();

            var contemA = from p in pessoas
                          where p.NomePessoa.Contains("A")
                          select p;

            ObjectDumper.Write(contemA);

            Console.WriteLine();

            var comecaComA = from p in pessoas
                             where p.NomePessoa.StartsWith("A")
                             select p;

            ObjectDumper.Write(comecaComA);

            Console.ReadKey();
        }
    }
}
