using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace _346_CurrentContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = Thread.CurrentContext;

            Console.WriteLine(c);

            foreach (var item in c.ContextProperties)
                Console.WriteLine("   {0} - {1}", item.Name, item);

            Console.ReadKey();
        }
    }
}
