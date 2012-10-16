using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _236_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                EntityKey ek = new EntityKey("VS2010Entities.PESSOA", "COD_PESSOA", 8);

                PESSOA p = (PESSOA)ie.GetObjectByKey(ek);

                if (p != null)
                    p.NOME_PESSOA = "EMA FROST";

                foreach (var item in ie.PESSOA)
                {
                    Console.WriteLine(item.NOME_PESSOA);
                }

                Console.WriteLine("------------------------");

                ie.SaveChanges();

                foreach (var item in ie.PESSOA)
                {
                    Console.WriteLine(item.NOME_PESSOA);
                }

                Console.ReadKey();
            }
        }
    }
}
