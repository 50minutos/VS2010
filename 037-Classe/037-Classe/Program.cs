using System;

namespace _037_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine(p.nome == null);

            p.nome = "Adão";
            Console.WriteLine(p.nome);

            Console.ReadKey();
        }
    }

    /*internal*/
    class Pessoa //o tipo só pode ser acessado DENTRO do assembly
    {
        /*private*/
        int codigo; //o campo só pode ser acessado DENTRO da classe
        public String nome; //o campo pode ser acessado livremente
    }
}
