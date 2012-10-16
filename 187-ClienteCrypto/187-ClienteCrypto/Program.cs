using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _186_Crypto;

namespace _187_ClienteCrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Helper.Encriptar("agnaldo é instrutor"));

            Console.WriteLine(Helper.Decriptar(Helper.Encriptar("agnaldo é instrutor")));

            Console.ReadKey();
        }
    }
}
