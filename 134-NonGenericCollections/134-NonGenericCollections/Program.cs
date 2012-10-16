using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace _134_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pessoas = new ArrayList();

            pessoas.Add("Agnaldo");
            pessoas.Add("Alexandre");
            pessoas.Add("Vítor");
            pessoas.Add("Sincic");
            pessoas.Add("Laerte");
            pessoas.Add("Thiago");
            pessoas.Add("Roberto");

            //var lista = from p in pessoas
            //            select p;
            ////Could not find an implementation of the query pattern for source type 'System.Collections.ArrayList'.  'Select' not found.  Consider explicitly specifying the type of the range variable 'p'.

            var listaCast = from p in pessoas.Cast<String>()
                            select p;

            ObjectDumper.Write(listaCast);
            Console.WriteLine();

            var listaDeclaracaoTipo = from String p in pessoas
                                      select p;

            ObjectDumper.Write(listaDeclaracaoTipo);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
