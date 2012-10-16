using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilitarios
{
    public class Data
    {
        public DateTime Hoje() { return DateTime.Now; }
    }
}

//usando o VS 2010 Command Prompt!!!
//entrar na pasta dos fontes e compilar com:  
//csc /t:module Carro.cs
//csc /t:module Pessoa.cs
//csc /t:library /addmodule:Carro.netmodule /addmodule:Pessoa.netmodule /out:Utilitarios.dll Data.cs