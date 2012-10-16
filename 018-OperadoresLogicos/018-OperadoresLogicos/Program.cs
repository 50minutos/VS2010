using System;

namespace _018_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& || !
            //&& -> retorna true se TODOS forem true
            //|| -> retorna true se ALGUM for true
            //! -> inverte o valor de true/false

            Console.WriteLine(true && false);

            Console.WriteLine(false || true);

            Console.WriteLine(!!true);

            Object o = null;
            Object p = new Object();

            //short circuit
            if(o != null && o.ToString() == "System.Object")
                Console.WriteLine("é objeto");
            else
                Console.WriteLine("é null ou não é objeto");

            Console.ReadKey();
        }
    }
}
