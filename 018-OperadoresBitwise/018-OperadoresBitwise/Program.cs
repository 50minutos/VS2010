using System;

namespace _019_OperadoresBitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            // & | ^ ~
            //& -> retorna 1 se TODOS forem 1
            //| -> retorna 1 se ALGUM for 1
            //^ -> retorna 1 se os bits forem diferentes
            //~ -> inverte o bit 0/1 

            //1234 -> 4 * 1 + 3 * 10 + 2 * 100 + 1 * 1000
            //1010 -> 0 * 1 + 1 * 2 + 0 * 4 + 1 * 8 

            int x = 6; //0000 0110
            int y = 4; //0000 0100

            Console.WriteLine(x & y); //4
            Console.WriteLine(x | y); //6
            Console.WriteLine(x ^ y); //2
            Console.WriteLine(~x); //-7 -> somar 1 e mudar o sinal

            //1111 1001 -> 1 + 0 + 0 + 8 + 16 + 32 + 64 = 121 (- 128) = -7

            /*
             nenhuma =   0
             a =         1
             b =         2
             a + b =     3
             c =         4
             a + c =     5
             b + c =     6
             a + b + c = 7
             
             resposta = 6
             */
        }
    }
}
