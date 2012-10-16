using System;

namespace _021_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Cor cor = Cor.Vermelho;
            Sexo sexo = Sexo.Masculino;
            Season season = Season.Fall;

            Console.WriteLine("{0} -> {1}", (int)cor, cor);
            Console.WriteLine("{0} -> {1}", (int)sexo, sexo);
            Console.WriteLine("{0} -> {1}", (int)season, season);

            if(season == Season.Autumn)
                Console.WriteLine("a estação é: outono");

            Console.ReadKey();
        }
    }

    enum Sexo : byte
    { 
        Masculino, 
        Feminino
    }
    
    enum Cor
    { 
        Amarelo, 
        Vermelho, 
        Azul, 
        Verde, 
        Branco, 
        Roxo, 
        Preto
    }

    enum Season
    { 
        Summer, 
        Winter, 
        Autumn, 
        Spring, 
        Fall = Autumn
    }
}
