using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace _341_Comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();

            s.Start();
            for (int i = 0; i < 100; i++)
                MostrarInstance();
            Console.WriteLine("   -> {0} ms", s.ElapsedMilliseconds);
            s.Reset();

            s.Start();
            for (int i = 0; i < 100; i++)
                MostrarInvoke();
            Console.WriteLine("   -> {0} ms", s.ElapsedMilliseconds);
            s.Reset();

            s.Start();
            for (int i = 0; i < 100; i++)
                MostrarDynamic();
            Console.WriteLine("   -> {0} ms", s.ElapsedMilliseconds);
            s.Stop();

            Console.ReadKey();
        }

        private static void MostrarDynamic()
        {
            Assembly a = Assembly.GetExecutingAssembly();

            Type t = a.GetType("Somadora");

            dynamic sd = Activator.CreateInstance(t, null);

            dynamic x = sd.Somar(1, 2);

            Console.Write(x);
        }

        private static void MostrarInvoke()
        {
            Assembly a = Assembly.GetExecutingAssembly();

            Type t = a.GetType("Somadora");

            Object cr = Activator.CreateInstance(t, null);

            MethodInfo mi = t.GetMethod("Somar");

            Object x = mi.Invoke(cr, new Object[] { 1, 2 });

            Console.Write(Convert.ToInt32(x));
        }

        private static void MostrarInstance()
        {
            Somadora si = new Somadora();

            int x = si.Somar(1, 2);

            Console.Write(x);
        }
    }
}

class Somadora
{
    public int Somar(int x, int y) { return x + y; }
}
