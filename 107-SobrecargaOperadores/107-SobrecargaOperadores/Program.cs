using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _107_SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Terreno t1 = new Terreno() { frente = 12, fundo = 20 };
            Terreno t2 = new Terreno() { frente = 8, fundo = 20 };
            Terreno novo = t1 + t2;
            Terreno terrenos = new Terreno() { frente = 8, fundo = 15 } * 3;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(novo);
            Console.WriteLine(terrenos);
            
            Console.WriteLine();

            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1 < t2);

            Console.WriteLine();
            
            Console.WriteLine(t2 == terrenos);
            Console.WriteLine(t2 != terrenos);

            Console.WriteLine();

            Console.WriteLine(++t1);
            Console.WriteLine(t1--);
            Console.WriteLine(t1);

            Console.ReadKey();
        }
    }

    class Terreno
    {
        public int frente { get; set; }
        public int fundo { get; set; }

        public int CalcularArea()
        {
            return this.frente * this.fundo;
        }

        public static Terreno operator +(Terreno t1, Terreno t2)
        {
            if (t1.fundo != t2.fundo) throw new ArgumentException("os terrenos devem ter a mesma medida de 'fundo'");
            Terreno retorno = new Terreno();
            
            retorno.fundo = t1.fundo;
            retorno.frente = t1.frente + t2.frente;

            return retorno;
        }

        public static Terreno operator *(Terreno t, int i)
        {
            Terreno retorno = new Terreno();
            
            retorno.fundo = t.fundo;
            retorno.frente = t.frente * i;

            return retorno;
        }

        public static bool operator >(Terreno t1, Terreno t2)
        {
            return t1.CalcularArea() > t2.CalcularArea();
        }

        public static bool operator <(Terreno t1, Terreno t2)
        {
            return !(t1 > t2);
        }

        public static bool operator ==(Terreno t1, Terreno t2)
        {
            return t1.CalcularArea() == t2.CalcularArea();
        }

        public static bool operator !=(Terreno t1, Terreno t2)
        {
            return !(t1 == t2);
        }

        public static Terreno operator ++(Terreno t)
        {
            Terreno retorno = new Terreno() { frente = t.frente + 1, fundo = t.fundo };

            return retorno;
        }

        public static Terreno operator --(Terreno t)
        {
            Terreno retorno = new Terreno() { frente = t.frente - 1, fundo = t.fundo };

            return retorno;
        }

        public override bool Equals(object obj)
        {
            return this == (Terreno)obj;
        }

        public override int GetHashCode()
        {
            return this.CalcularArea();
        }

        public override string ToString()
        {
            return String.Format("{0} x {1}", this.frente, this.fundo);
        }
    }
}
