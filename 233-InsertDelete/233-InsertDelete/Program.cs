using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _233_InsertDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            Table<Filho> filhosDoAdao = dc.GetTable<Filho>();

            ObjectDumper.Write(filhosDoAdao);
            Console.WriteLine();

            Filho ooops = new Filho() { NomeFilho = "TIANA", CodigoPessoa = 1 };

            filhosDoAdao.InsertOnSubmit(ooops);
            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Filho>());
            Console.WriteLine();

            filhosDoAdao.DeleteOnSubmit(ooops);
            dc.SubmitChanges();

            ObjectDumper.Write(dc.GetTable<Filho>());

            Console.ReadKey();
        }
    }
}
