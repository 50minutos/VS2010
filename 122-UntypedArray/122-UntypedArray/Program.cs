using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _122_UntypedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] array = { new Random(), 102.234, "SQL Server", 'S', 10, "Saturday Night" };

            var tipos = array
                .Select(item => item.GetType().Name)
                .OrderBy(x => x);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in tipos)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
