using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            RH.Salarios s = new RH.Salarios();

            s.Nome = "Chico";
            s.Salario = 1000;
            s.Descontos = 500;
            s.Comissoes = 145;

            Console.WriteLine(s.CalcularSalario());

            s.Nome = "Agnaldo";
            s.Salario = 2000;
            s.Descontos = 1500;
            s.Comissoes = 0;

            Console.WriteLine(s.CalcularSalario());

            Console.ReadKey();
        }
    }
}
