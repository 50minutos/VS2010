using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _232_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            var filhosDoAdao = from f in dc.GetTable<Filho>()
                                  where f.CodigoPessoa == 1
                                  select f;

            ObjectDumper.Write(filhosDoAdao);
            
            Console.WriteLine();

            foreach (Filho filho in filhosDoAdao)
            {
                filho.NomeFilho += "*";
            }

            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Filho>());

            Console.ReadKey();
        }
    }
}
