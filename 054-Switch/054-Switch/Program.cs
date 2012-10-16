using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _054_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaDaSemana = 1;

            String msg = String.Empty;

            switch (diaDaSemana)
            {
                case 1:
                    msg = "dom";
                    break;
                case 2:
                    msg = "seg";
                    break;
                case 3:
                    msg = "ter";
                    break;
                case 4: 
                    msg = "qua"; 
                    break;
                case 5: 
                    msg = "qui"; 
                    break;
                case 6: 
                    msg = "sex"; 
                    break;
                case 7: 
                    msg = "sáb"; 
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
