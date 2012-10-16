using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _223_PaginacaoSkipTake
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=VS2010;Integrated Security=True");

            dc.Log = Console.Out;

            var tabela = from p in dc.GetTable<Pessoa>()
                         select p;

            var dados = from p in tabela
                        select new { p.CodigoPessoa, p.NomePessoa, p.SexoPessoa };

            var paginado = dados.Skip(1).Take(2);

            ObjectDumper.Write(paginado);

            Console.ReadKey();
        }
    }
}
