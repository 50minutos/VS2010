using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _238_LinqToEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                var pessoas = from p in ie.PESSOA
                              where p.NOME_PESSOA.Contains("A")
                              select new { p.COD_PESSOA, p.NOME_PESSOA };

                foreach (var item in pessoas)
                {
                    Console.WriteLine("{0} -> {1}", item.COD_PESSOA, item.NOME_PESSOA);
                }

                Console.ReadKey();
            }
        }
    }
}
