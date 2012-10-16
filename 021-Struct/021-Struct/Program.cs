using System;

namespace _022_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("a coordenada é ({0}, {1})", x, y);

            Coordenada c = new Coordenada();

            Console.WriteLine("a coordenada é ({0}, {1})", c.X, c.Y);

            c.X = 10;
            c.Y = 5;

            Console.WriteLine("a coordenada é ({0}, {1})", c.X, c.Y);

            Console.ReadKey();
        }
    }

    struct Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
