using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _226_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            var dados = from p in dc.GetTable<Pessoa>()
                        group p by p.SexoPessoa into agrupados
                        orderby agrupados.Key
                        select new { Sexo = agrupados.Key, Pessoas = agrupados };

            ObjectDumper.Write(dados, 1);

            Console.WriteLine();

            foreach (var agrupado in dados)
            {
                Console.WriteLine("Sexo: {0}", agrupado.Sexo);

                foreach (Pessoa p in agrupado.Pessoas)
                {
                    Console.WriteLine("\tpessoa: {0}", p.NomePessoa);
                }
            }

            Console.ReadKey();
        }
    }
}
