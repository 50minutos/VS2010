using System;

using X = Ferramentas;
using Y = Frutas;

using Sistema;
using Sistema.RH;
using Sistema.Producao;

namespace _242_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ////fully qualified name
            //Ferramentas.Serrote serrote = new Ferramentas.Serrote();
            //Ferramentas.Lima ferramentaLima = new Ferramentas.Lima();
            //Frutas.Laranja laranja = new Frutas.Laranja();
            //Frutas.Lima frutaLima = new Frutas.Lima();

            ////name clash
            //Serrote serrote = new Serrote();
            //Laranja laranja = new Laranja();
            //Ferramentas.Lima ferramentaLima = new Ferramentas.Lima();
            //Frutas.Lima frutaLima = new Frutas.Lima();
                        
            ////alias
            //SCG.List<String> lista;

            //X.Serrote serrote = new X.Serrote();
            //X.Lima ferramentaLima = new X.Lima();
            //Y.Laranja laranja = new Y.Laranja();
            //Y.Lima frutaLima = new Y.Lima();

            //Console.WriteLine(serrote);
            //Console.WriteLine(ferramentaLima);
            //Console.WriteLine(laranja);
            //Console.WriteLine(frutaLima);

            Gerente gerente = new Gerente();
            Funcionario funcionario = new Funcionario();
            Produto produto = new Produto();

            Console.ReadKey();
        }
    }
}

namespace Ferramentas
{
    public class Serrote { }
    public class Lima { }
}

namespace Frutas
{
    public class Laranja { }
    public class Lima { }
}

//Nested
namespace Sistema
{
    namespace RH
    {
        public class Funcionario { }
    }

    public class Gerente { }
}

namespace Sistema.Producao
{
    public class Produto { }
}
