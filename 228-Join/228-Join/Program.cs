using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _228_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext(@"Data Source=.\sqlexpress;Initial Catalog=vs2010;Integrated Security=True");

            dc.Log = Console.Out;

            var pessoas = dc.GetTable<Pessoa>();
            var filhos = dc.GetTable<Filho>();

            var todosANSI82 = from p in pessoas
                              from f in filhos
                              where p.CodigoPessoa == f.CodigoPessoa
                              select new { p.NomePessoa, f.NomeFilho };

            ObjectDumper.Write(todosANSI82);

            Console.WriteLine();

            var todosANSI92 = from p in pessoas
                              join f in filhos
                              on p.CodigoPessoa equals f.CodigoPessoa
                              select new { p.NomePessoa, f.NomeFilho };

            ObjectDumper.Write(todosANSI92);

            Console.ReadKey();
        }
    }
}

/*
--CRIAR A TABELA FILHO
 
CREATE TABLE FILHO
(
	COD_FILHO INT IDENTITY, 
	NOME_FILHO VARCHAR(50), 
	COD_PAI INT REFERENCES PESSOA
)

--POPULAR
INSERT INTO FILHO 
VALUES ('CAIM', 1), 
	('ABELARDO', 1), 
	('ZEFA', 1)
 */