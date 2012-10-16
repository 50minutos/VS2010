using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _060_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 43, 56, 7, 34, 54, 7, 76, 23 };

            foreach (int item in numeros) //read-only
            {
                Console.WriteLine(item);      
            }

            Console.ReadKey();
        }
    }
}
