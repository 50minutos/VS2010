using System;

namespace _024_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //coleção de elementos do mesmo tipo
            //zero based
            //tamanho fixo
            //reference type
            //na inicialização cada elemento recebe valor (0 para números, false para lógicos, null para objetos)
            
            //declarar
            //tipo[] nome;

            int[] inteiros;

            //inicializar
            //nome = new tipo[quantidadeDeElementos];
            inteiros = new int[3];

            foreach (var item in inteiros)
            {
                Console.WriteLine(item);
            }

            //atribuir
            //nome[índice] = valor;

            inteiros[1] = 1000;

            for (int i = 0; i < inteiros.Length; i++)
            {
                Console.WriteLine("inteiros[{0}] -> {1}", i, inteiros[i]);
            }

            Console.ReadKey();
        }
    }
}
