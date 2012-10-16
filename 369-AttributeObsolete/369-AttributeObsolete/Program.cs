using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _369_AttributeObsolete
{
    /// <summary>
    /// classe qualquer coisa
    /// </summary>
    class Program
    {
        /// <summary>
        /// método principal
        /// </summary>
        /// <param name="args">argumentos do método</param>
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicadora.Multiplica(10, 3));
            Console.WriteLine(Multiplicadora.Multiplicar(10,3));

            //TODO fazer a lógica aqui...
            
            Console.ReadKey();
        }
    }

    /// <summary>
    /// classe que sabe fazer multiplicações de int
    /// </summary>
    class Multiplicadora
    {
        /// <summary>
        /// método que multiplica dois inteiros
        /// </summary>
        /// <param name="x">primeiro valor</param>
        /// <param name="y">segundo valor</param>
        /// <returns></returns>
        [Obsolete("Use Multiplicar(int, int)")]
        public static int Multiplica(int x, int y)
        {
            int resultado = 0;

            for (int i = 0; i < y; i++)
            {
                resultado += x;
            }

            return resultado;
        }

        /// <summary>
        /// método que multiplica dois inteiros
        /// </summary>
        /// <param name="x">primeiro valor</param>
        /// <param name="y">segundo valor</param>
        /// <returns></returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}

