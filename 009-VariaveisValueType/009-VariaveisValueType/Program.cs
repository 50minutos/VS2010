using System;

namespace _009_VariaveisValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            //tipo nome;
            int x;
            char c;
            bool b;

            //não podemos usar a variável antes de atribuir um valor

            //atribuir
            //nome = valor;
            x = 10;
            c = 'a';
            b = true;

            Console.WriteLine(x);
            Console.WriteLine(c);
            Console.WriteLine(b);

            //declarar múltiplas variáveis
            //tipo nome1, nome2, ...;

            int m, n, o, p;

            //atribuir conteúdo a múltiplas variáveis
            //nome1 = nome2 = nome3 = ... = valor;

            m = n = o = p = 1000;

            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);

            //declarar e atribuir valor
            //tipo nome = valor;

            int i = 10, j = 10;

            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}
