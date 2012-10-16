using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _250_GAC
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", this.Codigo, this.Nome);
        }
    }

    public class Calculadora
    {
        public double Somar(double a, double b) { return a + b; }
        public double Subtrair(double a, double b) { return a - b; }
    }
}
