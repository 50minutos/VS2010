using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _239_CreateQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                String sql = "SELECT VALUE FROM VS2010Entities.PESSOA as Pessoa where Pessoa.NOME_PESSOA LIKE '%A%'";

                var pessoas = ie.CreateQuery<PESSOA>(sql);

                foreach (var item in pessoas)
                {
                    Console.WriteLine(item.NOME_PESSOA);
                }

                Console.ReadKey();
            }
        }
    }
}
