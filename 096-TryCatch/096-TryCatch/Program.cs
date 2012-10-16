using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _096_TryCatch
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
