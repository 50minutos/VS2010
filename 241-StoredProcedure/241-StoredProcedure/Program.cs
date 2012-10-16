using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace _241_StoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VS2010Entities ie = new VS2010Entities())
            {
                ObjectParameter n1 = new ObjectParameter("X", 30);
                ObjectParameter n2 = new ObjectParameter("Y", 20);
                ObjectParameter resultado = new ObjectParameter("SOMA", typeof(int));

                int saida = ie.ExecuteFunction("Somar", n1, n2, resultado);

                Console.WriteLine(saida);
                Console.WriteLine(resultado.Value);

                int retorno = ie.Somar(30, 20, resultado);

                Console.WriteLine(retorno);
                Console.WriteLine(resultado.Value);

                Console.ReadKey();
            }
        }
    }
}
