using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq.Mapping;

[Table(Name = "FILHO")]
class Filho
{
    [Column(Name = "COD_FILHO", IsPrimaryKey = true, IsDbGenerated=true)]
    public int CodigoFilho { get; set; }

    [Column(Name = "NOME_FILHO")]
    public String NomeFilho { get; set; }

    [Column(Name = "COD_PAI")]
    public int CodigoPessoa { get; set; }
}
