using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _370_AttributeCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.CodigoPessoa = 10;
            p.NomePessoa = "zé da silva";

            String comando = String.Format("INSERT INTO {0} (", p.GetType().GetCustomAttributes(typeof(NomeNoBanco), true));

            foreach (var item in p.GetType().GetProperties())
            {
                comando += String.Format("{0}, ", item.GetCustomAttributes(typeof(NomeNoBanco), false));
            }

            comando = comando.Substring(0, comando.Length - 2) + ") values (";

            foreach (var item in p.GetType().GetProperties())
            {
                comando += String.Format("'{0}', ", item.GetValue(p, null));
            }

            comando = comando.Substring(0, comando.Length - 2) + ")";

            Console.WriteLine(comando);

            Console.ReadKey();
        }
    }

    [NomeNoBanco("PESSOA")]
    class Pessoa
    {
        [ChavePrimaria(true)]
        [NomeNoBanco("COD_PESSOA")]
        public int CodigoPessoa { get; set; }

        [NomeNoBanco("NOME_PESSOA")]
        public String NomePessoa { get; set; }
    }

    class ChavePrimaria : Attribute
    { 
        public bool Tem { get; set; }

        public ChavePrimaria()
        {

        }

        public ChavePrimaria(bool tem)
        {
            this.Tem = tem;
        }

        public override bool ToString()
        {
            return this.Tem;
        }
    }
    
    class NomeNoBanco : Attribute
    {
        public String Nome { get; set; }

        public NomeNoBanco()
        {

        }

        public NomeNoBanco(String nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
