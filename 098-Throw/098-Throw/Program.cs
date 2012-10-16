using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _098_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            try
            {
                double x = Convert.ToDouble(Console.ReadLine());

                if (x == 0)
                    throw new DivideByZeroException();

                Console.WriteLine(10 / x);
            }
            catch (OverflowException)
            {
                Console.WriteLine("O número é muito grande");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("O valor não pode ser ZERO");
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor deve ser numérico");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
