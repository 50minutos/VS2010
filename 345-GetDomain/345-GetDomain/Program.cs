using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _345_GetDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain ad = Thread.GetDomain();

            Console.WriteLine(ad.FriendlyName);

            Console.ReadKey();
        }
    }
}
