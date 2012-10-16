using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumidorWS
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyPessoa.WSPessoaSoapClient p = new ProxyPessoa.WSPessoaSoapClient();

            Console.WriteLine(p.Somar(10,20));
            Console.WriteLine(p.HelloWorld());

            foreach (var item in p.Selecionar())
            {
                Console.WriteLine(item.CodPessoa);
                Console.WriteLine(item.NomePessoa);
                Console.WriteLine(item.SexoPessoa);
               
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
