using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RH
{
    public class Salarios
    {
        public String Nome { get; set; }
        
        public double Salario { get; set; }
        public double Descontos { get; set; }
        public double Comissoes { get; set; }

        public double CalcularSalario()
        {
            return this.Salario + this.Comissoes - this.Descontos;
        }
    }
}
