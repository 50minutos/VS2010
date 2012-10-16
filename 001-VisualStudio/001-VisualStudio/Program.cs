using System;

namespace _001_VisualStudio
{
    /// <summary>
    /// Programa que executa métodos de Animal
    /// </summary>
    class Program //por padrão o tipo é internal (todos os tipos dentro do mesmo assembly o "enxergam")
    {
        /// <summary>
        /// método inicial da classe
        /// </summary>
        /// <param name="args">argumentos passados em linha de comando</param>
        static void Main(string[] args)
        {
            //comentários em linha

            /*
             comentários
             em
             bloco
             */
            
            //F5 -> executar no modo DEBUG
            //CTRL+F5 -> executar sem DEBUG
            //SHIFT+F5 -> break

            //CTRL+SHIFT+U -> maiúsculas
            //CTRL+U -> minúsculas

            //CTRL+L -> apagar a linha

            //SHIFT+ALT+F10 -> menu de contexto (gerar ou referenciar)
            
            //F12 -> navegar para a definição
            //CTRL+- -> voltar

            Animal a = new Animal();

            a.Acordar();
            a.Comer();
            a.Dormir();

            Console.ReadKey();
        }
    }
}
