using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _252_GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(String);

            Object o = null;

            Random r = new Random();

            switch (r.Next(1, 4))
            {
                case 1:
                    o = new Object();
                    break;
                case 2:
                    o = new Random();
                    break;
                case 3:
                    o = new Int32();
                    break;
            }

            Type t2 = o.GetType();

            Type t3 = Type.GetType("system.int32", false, true);

            Type t4 = Type.GetType("_252_GetType.Externa", false, true);
            Type t5 = Type.GetType("_252_GetType.Externa+Interna", false, true);

            MostrarDados(t1);
            MostrarDados(t2);
            MostrarDados(t3);
            MostrarDados(t4);
            MostrarDados(t5);

            Console.ReadKey();
        }

        private static void MostrarDados(Type t)
        {
            Console.WriteLine("{0}\n{1}\n{2}\n\n", t.Name, t.Namespace, t.Assembly);
        }
    }

    class Externa
    {
        class Interna
        {

        }
    }
}
