using System;

namespace _038_EscopoVariaveis
{
    class Program
    {
        int y = 10; //variavel de instância

        static void Main(string[] args)
        {
            Console.WriteLine(Classe.y);

            Classe c = new Classe();
            Console.WriteLine(c.x);

            Console.WriteLine(new Program().y);

            int x = 1000;
            Console.WriteLine(x);

            {
                int i = 10000;
                Console.WriteLine(i);

                Console.WriteLine(x);
            }

            {
                int i = -1;
                Console.WriteLine(i);
            }

            //SHIFT+ALT+ENTER -> FULL SCREEN

            Console.ReadKey();
        }
    }

    class Classe
    {
        public int x = 1;
        public static int y = 100;
    }
}
