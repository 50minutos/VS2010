using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _095_PolimorfismoNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEM POLIMORFISMO

            Derivada d = new Derivada();
            
            d.MetodoVirtual();
            d.Metodo();
            d.MetodoAbstract();

            Console.WriteLine();

            //COM POLIMORFISMO

            Base b = new Derivada();

            b.MetodoVirtual();
            b.Metodo();
            b.MetodoAbstract();

            Console.ReadKey();
        }
    }

    abstract class Base
    {
        public virtual void MetodoVirtual() { Console.WriteLine("método que PODE ser sobreposto"); }
        public void Metodo() { Console.WriteLine("método que NÃO FOI PREPARADO para ser sobreposto"); }
        public abstract void MetodoAbstract(); //DEVE ser sobreposto
    }

    class Derivada : Base
    {
        public override void MetodoAbstract()
        {
            Console.WriteLine("fui obrigado a implementar"); ;
        }

        public override void MetodoVirtual()
        {
            Console.WriteLine("foi minha opção sobrepor");
        }

        public new void Metodo()
        {
            Console.WriteLine("ocultei o método que tem a mesma assinatura na classe Base");
        }
    }
}
