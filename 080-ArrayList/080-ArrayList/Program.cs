using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace _080_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("agnaldo");
            lista.Add(DateTime.Now);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
