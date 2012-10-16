using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _147_PaginacaoSkipTake
{
    public class Cidade
    {
        public int CodigoCidade { get; set; }
        public String NomeCidade { get; set; }
        public String SiglaEstado { get; set; }
    }

    public class IteratorCidade
    {
        public static IEnumerable<Cidade> ObterCidades()
        {
            yield return new Cidade() { CodigoCidade = 1, NomeCidade = "São Paulo", SiglaEstado = "SP" };
            yield return new Cidade() { CodigoCidade = 2, NomeCidade = "Rio de Janeiro", SiglaEstado = "RJ" };
            yield return new Cidade() { CodigoCidade = 3, NomeCidade = "São João da Boa Vista", SiglaEstado = "SP" };
            yield return new Cidade() { CodigoCidade = 4, NomeCidade = "Belo Horizonte", SiglaEstado = "MG" };
        }
    }
}