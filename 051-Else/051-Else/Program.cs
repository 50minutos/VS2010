using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _051_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaDaSemana = 6;

            if (diaDaSemana == 1)
                Console.WriteLine("domingo");
            else if (diaDaSemana == 2)
                Console.WriteLine("segunda");
            else if (diaDaSemana == 3)
                Console.WriteLine("terça");
            else if (diaDaSemana == 4)
                Console.WriteLine("quarta");
            else if (diaDaSemana == 5)
                Console.WriteLine("quinta");
            else if (diaDaSemana == 6)
                Console.WriteLine("sexta");
            else if (diaDaSemana == 7)
                Console.WriteLine("sábado");
            else
                Console.WriteLine("dia incorreto");
           
            Console.ReadKey();
        }
    }
}
