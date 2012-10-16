using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _131_ToArrayToListToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Cidade> cidades = IteratorCidade.ObterCidades();

            ObjectDumper.Write(cidades);
            Console.WriteLine();

            Cidade[] arrayCidades = cidades.ToArray<Cidade>();

            ObjectDumper.Write(arrayCidades);
            Console.WriteLine();

            List<Cidade> listCidades = cidades.ToList<Cidade>();

            ObjectDumper.Write(listCidades);
            Console.WriteLine();

            Dictionary<int, Cidade> dictionaryCidades = cidades.ToDictionary(cidade => cidade.codigoCidade);

            ObjectDumper.Write(dictionaryCidades, 1);
            Console.WriteLine();

            Cidade c = dictionaryCidades[3];
            ObjectDumper.Write(c);

            Console.ReadKey();

        }
    }

    class Cidade
    {
        public int codigoCidade;
        public String nomeCidade;
        public String siglaEstado;
    }

    static class IteratorCidade
    {
        public static IEnumerable<Cidade> ObterCidades()
        {
            yield return new Cidade() { codigoCidade = 1, nomeCidade = "São Paulo", siglaEstado = "SP" };
            yield return new Cidade() { codigoCidade = 2, nomeCidade = "Rio de Janeiro", siglaEstado = "RJ" };
            yield return new Cidade() { codigoCidade = 3, nomeCidade = "São João da Boa Vista", siglaEstado = "SP" };
            yield return new Cidade() { codigoCidade = 4, nomeCidade = "Belo Horizonte", siglaEstado = "MG" };
        }
    }
}
