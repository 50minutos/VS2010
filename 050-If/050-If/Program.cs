using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _050_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (condicao)
            //{ //se tiver somente um comando, as {} são opcionais
            //    bloco de comandos para condicao == true
            //}
            //else //opcional
            //{ //se tiver somente um comando, as {} são opcionais
            //    bloco de comandos para condicao == false
            //}
            
            int x = 10;

            if (x % 2 == 0)
            {
                Console.WriteLine("o número é par");
            }
            else
            {
                Console.WriteLine("o número é ímpar");
            }

            Console.ReadKey();
        }
    }
}
