using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _230_Associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=VS2010;Integrated Security=True");

            dc.Log = Console.Out;

            foreach (Pessoa p in dc.GetTable<Pessoa>())
            {
                Console.WriteLine("Pessoa: {0}", p.NomePessoa);

                foreach (Filho f in p.Filhos)
                {
                    Console.WriteLine("   Filho: {0}", f.NomeFilho);
                }
            }

            Console.WriteLine();

            var comFilhos = from p in dc.GetTable<Pessoa>()
                            where p.Filhos.Any()
                            select p;

            ObjectDumper.Write(comFilhos);
            Console.WriteLine();

            var semFilhos = from p in dc.GetTable<Pessoa>()
                            where !p.Filhos.Any()
                            select p;

            ObjectDumper.Write(semFilhos, 1);
            Console.WriteLine();

            var comAlgumFilhoIniciadoPorA = from p in dc.GetTable<Pessoa>()
                                            where p.Filhos.Any(f => f.NomeFilho.StartsWith("A"))
                                            select p;

            ObjectDumper.Write(comAlgumFilhoIniciadoPorA);
            Console.WriteLine();

            var seOsFilhosChamamCHICO = from p in dc.GetTable<Pessoa>()
                                        where p.Filhos.Any()
                                        where p.Filhos.All(f => f.NomeFilho.Equals("CHICO"))
                                        select p;

            ObjectDumper.Write(seOsFilhosChamamCHICO);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
