using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _079_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inteiros = new List<int>();
            
            inteiros.Add(1);
            inteiros.Add(11);
            inteiros.Add(111);
            inteiros.Add(1111);
            
            foreach (var item in inteiros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
