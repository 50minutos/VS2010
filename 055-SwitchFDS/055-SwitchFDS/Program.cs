using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _055_SwitchFDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaDaSemana = 3;

            String msg = String.Empty;

            switch (diaDaSemana)
            {
                case 1:
                case 7:
                    msg = "final de semana";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    msg = "dia útil";
                    break;
                default:
                    msg = "dia inexistente";
                    break;
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
