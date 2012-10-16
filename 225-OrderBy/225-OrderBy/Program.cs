using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _225_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            var porNomeAsc = from p in dc.GetTable<Pessoa>()
                             orderby p.NomePessoa //ascending
                             select p;

            ObjectDumper.Write(porNomeAsc);

            Console.WriteLine();

            var porNomeDesc = dc.GetTable<Pessoa>()
                .OrderByDescending(p => p.NomePessoa)
                .Select(p => p);

            ObjectDumper.Write(porNomeDesc);

            Console.ReadKey();
        }
    }
}
