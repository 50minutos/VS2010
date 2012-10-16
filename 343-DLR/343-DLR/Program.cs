using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace _343_DLR
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptRuntime py = Python.CreateRuntime();

            dynamic random = py.UseFile("random.py");

            var items = Enumerable.Range(1, 5).ToArray();

            for (int i = 0; i < 10; i++)
            {
                random.shuffle(items);

                foreach (int item in items)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
