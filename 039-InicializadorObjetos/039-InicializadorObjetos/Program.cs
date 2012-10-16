using System;

namespace _039_InicializadorObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordenada c1 = new Coordenada();

            c1.x = 10;
            c1.y = 20;

            Coordenada c2 = new Coordenada() { x = 1, y = 2 };

            Coordenada c3 = new Coordenada() { y = 100 };

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.ReadKey();
        }
    }

    class Coordenada
    {
        public int x;
        public int y;
    }
}
