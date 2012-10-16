using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

[Table(Name = "PESSOA")]
class Pessoa
{
    [Column(Name = "COD_PESSOA", IsPrimaryKey = true)]
    public int CodigoPessoa { get; set; }

    [Column(Name = "NOME_PESSOA")]
    public String NomePessoa { get; set; }

    [Column(Name = "SEXO_PESSOA")]
    public char SexoPessoa { get; set; }
}
