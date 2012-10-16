using System;

namespace _023_CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor a ser sacado: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            int valor = Int32.Parse(Console.ReadLine());

            //notas = 100, 50, 20, 10, 5, 2
            //moedas = 1

            Console.WriteLine("{0}  nota(s) de R$ 100,00", valor / 100); valor %= 100;
            Console.WriteLine("{0}  nota(s) de R$  50,00", valor / 50); valor %= 50;
            Console.WriteLine("{0}  nota(s) de R$  20,00", valor / 20); valor %= 20;
            Console.WriteLine("{0}  nota(s) de R$  10,00", valor / 10); valor %= 10;
            Console.WriteLine("{0}  nota(s) de R$   5,00", valor / 5); valor %= 5;
            Console.WriteLine("{0}  nota(s) de R$   2,00", valor / 2); valor %= 2;
            Console.WriteLine("{0} moeda(s) de R$   1,00", valor);

            Console.ReadKey();
        }
    }
}
