using System;
using _003_Namespace.Classes;
using _003_Namespace.Estruturas;

namespace _003_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Carro carro = new Carro();

            Hotel hotel;
            Casa casa;

            Sexo sexo = Sexo.masculino;

            Console.WriteLine(hotel);
            Console.WriteLine(casa);
            Console.WriteLine(sexo);
            
            //CTRL+K, CTRL+C -> comentar as linhas selecionadas
            //CTRL+K, CTRL+U -> remover comentários das linhas selecionadas

            //CTRL+K, CTRL+D -> reformatar
        }
    }
}
