using System;

namespace _022a_StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            c.Ano = 1987;
            c.Marca = "FIAT";
            c.Modelo = "147 L";
            c.Combustivel = Combustivel.álcool;

            Carro novo = new Carro();
            novo.Ano = 2011;
            novo.Marca = "FIAT";
            novo.Modelo = "Palio";
            novo.Combustivel = Combustivel.álcool | Combustivel.gasolina | Combustivel.glp;

            Console.WriteLine("{0} - {1} - {2} - {3}", c.Ano, c.Marca, c.Modelo, ObterCombustivel(c.Combustivel));
            Console.WriteLine("{0} - {1} - {2} - {3}", novo.Ano, novo.Marca, novo.Modelo, ObterCombustivel(novo.Combustivel));

            Console.ReadKey();
        }

        private static String ObterCombustivel(Combustivel c)
        {
            String retorno = "";

            foreach (Combustivel item in System.Enum.GetValues(typeof(Combustivel)))
            {
                if ((c & item) == item)
                    retorno += item + ", ";
            }

            return retorno.Substring(0, retorno.Length-2);
        }
    }

    enum Combustivel
    { 
        álcool = 0x1,
        gasolina = 0x2,
        diesel = 0x4,
        glp = 0x8
    }

    struct Carro
    {
        public int Ano { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
    }
}
