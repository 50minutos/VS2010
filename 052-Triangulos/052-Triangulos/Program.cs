using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _052_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //é triângulo quando:
            //   os lados são maiores que zero
            //   a soma dos lados menores é maior que o lado maior
            //sendo triângulo, temos:
            //   equilátero: três lados iguais
            //   escaleno: três lados diferentes
            //   isósceles: dois lados iguais

            int a = 3;
            int b = 4;
            int c = 5;

            String msg = String.Empty;

            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                msg = "não é triângulo";
            else 
                if(a == b && b ==c)
                    msg = "equilátero";
                else
                    if(a!=b && b != c && a != c)
                        msg = "escaleno";
                    else
                        msg = "isósceles";

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
