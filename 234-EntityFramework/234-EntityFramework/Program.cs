using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _234_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                Console.WriteLine("PESSOAS");

                foreach (var item in ie.PESSOA)
                {
                    Console.WriteLine("{0} - {1} - {2}", item.CodPessoa, item.NomePessoa, item.SexoPessoa);
                }

                Console.WriteLine("FILHOS");

                foreach (var item in ie.FILHO)
                {
                    Console.WriteLine("{0} - {1} - {2}", item.COD_FILHO, item.NOME_FILHO, item.COD_PAI);
                }

                Console.ReadKey();
            }
        }
    }
}