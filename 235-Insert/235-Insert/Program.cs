using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _235_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                ie.AddToPESSOA(new PESSOA() { NOME_PESSOA = "Rainha Branca", SEXO_PESSOA = "F" });

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