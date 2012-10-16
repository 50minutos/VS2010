using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _126_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "O SQL Server 2008 R2 foi lançado em maio de algum ano.";

            var qtdCaracteresNumericos = texto
                .Where(c => Char.IsNumber(c))
                .Count();

            Console.WriteLine(qtdCaracteresNumericos);

            Console.ReadKey();
        }
    }
}
