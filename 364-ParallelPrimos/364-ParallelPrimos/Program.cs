using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;

namespace _364_ParallelPrimos
{
    class Program
    {
        static ArrayList primos = new ArrayList();

        static void Main(string[] args)
        {
            Console.Write("Digite um número até {0}: ", Int32.MaxValue);
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nn = {0}", n);

            DateTime inicio = DateTime.Now;
            //MaxDegreeOfParallelism = 1 só para funcionar
            Parallel.For(2, n + 1, new ParallelOptions() { MaxDegreeOfParallelism = 2 }, item => { if (TestarPrimo(item)) primos.Add(item); });

            Thread.Sleep(2000);

            Console.WriteLine("\nUsando Parallel.For demorou {0} "
                + "para processar e temos {1} primos no intervalo... o maior deles é {2}",
                DateTime.Now - inicio,
                primos.Count,
                primos[primos.Count - 1]);

            primos.Clear();

            inicio = DateTime.Now;

            for (int i = 2; i <= n; i++)
            {
                if (TestarPrimoOtimizado(i))
                    primos.Add(i);
            }

            Console.WriteLine("\nUsando TestarPrimoOtimizado demorou {0} "
                + "para processar e temos {1} primos no intervalo... o maior deles é {2}",
                DateTime.Now - inicio,
                primos.Count,
                primos[primos.Count - 1]);

            primos.Clear();

            inicio = DateTime.Now;

            for (int i = 2; i <= n; i++)
            {
                if (TestarPrimo(i))
                    primos.Add(i);
            }

            Console.WriteLine("\nUsando TestarPrimo demorou {0} "
                + "para processar e temos {1} primos no intervalo... o maior deles é {2}",
                DateTime.Now - inicio,
                primos.Count,
                primos[primos.Count - 1]);

            primos.Clear();


            Console.ReadKey();
        }

        private static bool TestarPrimo(int n)
        {
            bool primo = true;

            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }

            return primo;
        }

        private static bool TestarPrimoOtimizado(int n)
        {
            bool primo = true;

            foreach (int item in primos)
            {
                if (n < Math.Pow(item, 2)) break;

                if (n % item == 0)
                {
                    primo = false;
                    break;
                }
            }

            return primo;
        }
    }
}