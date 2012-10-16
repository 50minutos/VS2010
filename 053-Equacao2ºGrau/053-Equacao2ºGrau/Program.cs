using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _053_EquacaoSegundoGrau
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax² + bx + c = 0 onde:
            //   a != 0 
            //Calcular delta: b² - 4ac
            //Se:
            //   delta < 0 -> não tem solução em R
            //   delta == 0 -> tem uma solução em R
            //   delta > 0 -> tem duas soluções em R

            double a = 1;
            double b = 0;
            double c = -2;
            
            //0, 1, 1 -> não é equação do 2º grau
            //1, -1, 1 -> não existe solução em R
            //1, 2, 1 -> existe uma solução em R: -1
            //1, 3, -4 -> existem duas soluções em R: 1 e -4

            String msg = String.Empty;

            if (a == 0)
            {
                msg = "não é equação do 2º grau";
            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {
                    msg = "não existe solução em R";
                }
                else
                {
                    if (d == 0)
                    {
                        msg = String.Format("existe uma solução em R:\n\t{0}",
                            -b / (2 * a));
                    }
                    else
                    {
                        msg = String.Format("existem duas soluções em R:\n\t{0} e {1}",
                            (-b + Math.Sqrt(d)) / (2 * a), 
                            (-b - Math.Sqrt(d)) / (2 * a));
                    }
                }
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
