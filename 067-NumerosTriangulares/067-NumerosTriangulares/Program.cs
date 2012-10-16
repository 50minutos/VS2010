using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _067_NumerosTriangulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 3, 6, 10, 15, 21, 28, 36...
            //  +2 +3 +4 ...

            int numero = 1;
            int i = 2;

            while(true)
            {
                numero += i++;

                if(numero > 1000)
                    break;
                
                Console.Write("{0,4}", numero);
            }

            Console.ReadKey();
        }
    }
}
