using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS
{
    public class Poney
    {
        public virtual void Acordar() { Console.WriteLine("O Poney acordou"); }
        public virtual void Comer() { Console.WriteLine("O Poney comeu"); }
        public virtual void Dormir() { Console.WriteLine("O Poney dormiu"); }
    }
}
