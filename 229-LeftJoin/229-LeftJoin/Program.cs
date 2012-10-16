using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _229_LeftJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            var pessoas = dc.GetTable<Pessoa>();
            var filhos = dc.GetTable<Filho>();

            var todos = from p in pessoas
                        join f in filhos
                        on p.CodigoPessoa equals f.CodigoPessoa
                            into resultado
                        from r in resultado.DefaultIfEmpty()
                        select new { p.NomePessoa, r.NomeFilho };

            ObjectDumper.Write(todos);

            Console.ReadKey();
        }
    }
}
