using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _227_Agregacao
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
                        select new { Sexo = agrupados.Key, QuantidadeDeRegistros = agrupados.Count(), SomaDosCodigos = agrupados.Sum<Pessoa>(p => p.CodigoPessoa) };

            ObjectDumper.Write(dados);

            Console.ReadKey();
        }
    }
}
