using System;

namespace _020_OperadoresTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            //typeof is as

            Console.WriteLine(typeof(Int32)); //retorna o tipo

            Object x = new Object();

            Random r = new Random();

            Console.WriteLine(r is Random); //teste de tipo

            x = r as Object; //conversão de tipos

            Console.WriteLine(x);

            int i = 10;
            String s = "abacate";

            Console.WriteLine("{0} -> tamanho = {1}", i, sizeof(int));
            Console.WriteLine("{0} -> quantidade de caracteres = {1}", s, s.Length);
            Console.WriteLine("{0} -> tamanho = {1}", 'a', sizeof(char));
            
            Console.ReadKey();

            //ASCII ->             0000 0000   a             1111 1111
            //UNICODE -> 0000 0000 0000 0000   a   1111 1111 1111 1111
        }
    }
}
