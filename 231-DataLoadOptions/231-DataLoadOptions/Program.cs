using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _231_DataLoadOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<Pessoa>(p => p.Filhos);

            dc.LoadOptions = dlo;

            ObjectDumper.Write(dc.GetTable<Pessoa>().Where<Pessoa>(p => p.CodigoPessoa == 1), 1);

            Console.ReadKey();
        }
    }
}
