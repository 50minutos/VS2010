using System;

namespace _035_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            //Tipo nome;

            Object o;
            
            //inicializar
            //nome = new Tipo()

            o = new Object();

            Console.WriteLine(o.ToString());
            Console.WriteLine(o.GetHashCode());
            Console.WriteLine(o.GetType());

            o = null;

            Console.ReadKey();
        }
    }
}
