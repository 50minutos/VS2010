using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _097_TryCatches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(10 / x);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("O número é muito grande");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("O valor não pode ser ZERO");
            }
            catch (FormatException ex)
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
