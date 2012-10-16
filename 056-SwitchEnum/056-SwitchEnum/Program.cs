using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _056_SwitchEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa() { nome = "Chico", estadoCivil = EstadoCivil.divorciado };

            String msg = String.Empty;

            switch (p.estadoCivil)
            {
                case EstadoCivil.solteiro:
                    msg = "balaaaada!!!";
                    break;
                case EstadoCivil.casado:
                    msg = "pois é...";
                    break;
                case EstadoCivil.divorciado:
                    msg = "tomou, negão!!!";
                    break;
                case EstadoCivil.viúvo:
                    msg = "ops...";
                    break;
                case EstadoCivil.outro:
                    msg = "eheheheheh";
                    break;
            }

            Console.WriteLine("{0}: {1}", p.nome, msg);

            Console.ReadKey();
        }
    }

    enum EstadoCivil
    {
        solteiro, casado, divorciado, viúvo, outro
    }

    class Pessoa
    {
        public String nome;
        public EstadoCivil estadoCivil;
    }
}
