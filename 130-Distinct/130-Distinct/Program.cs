using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _130_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Cidade[] cidades = new Cidade[]{
                new Cidade(){ nomeCidade="São Paulo", siglaEstado="SP"}, 
                new Cidade(){ nomeCidade="Rio de Janeiro", siglaEstado="RJ"}, 
                new Cidade(){ nomeCidade="Campos", siglaEstado="RJ"}, 
                new Cidade(){ nomeCidade="São João da Boa Vista", siglaEstado="SP"}, 
                new Cidade(){ nomeCidade="Sorocaba", siglaEstado="SP"}, 
                new Cidade(){ nomeCidade="Niterói", siglaEstado="RJ"}, 
                new Cidade(){ nomeCidade="Belo Horizonte", siglaEstado="MG"}, 
                new Cidade(){ nomeCidade="Campinas", siglaEstado="SP"}
            };

            var estados = cidades
                .Select(cidade => cidade.siglaEstado)
                .Distinct()
                .OrderBy(estado => estado);

            foreach (var item in estados)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }

    class Cidade
    {
        public String nomeCidade;
        public String siglaEstado;
    }
}
