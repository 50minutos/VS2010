using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _169_WS
{
    public class Pessoa
    {
        public int CodPessoa { get; set; }
        public String NomePessoa { get; set; }
        public char SexoPessoa { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int codPessoa, String nomePessoa, char sexoPessoa)
        {
            this.CodPessoa = codPessoa;
            this.NomePessoa = nomePessoa;
            this.SexoPessoa = sexoPessoa;
        }
    }
}
