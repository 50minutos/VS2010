using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _092_DesignPatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {            
            Sorvete s = new Sorvete();

            Console.WriteLine("Sorvete:");            
            Console.WriteLine("{0:c}", s.Preco);
            Console.WriteLine();

            SorveteComCobertura c = new SorveteComCobertura(s);
            
            Console.WriteLine("Sorvete com cobertura:");            
            Console.WriteLine("{0:c}", c.Preco);
            Console.WriteLine();
            
            SorveteComBalinha b = new SorveteComBalinha(s);

            Console.WriteLine("Sorvete com balinha:");
            Console.WriteLine("{0:c}", b.Preco);
            Console.WriteLine();
            
            SorveteComCobertura cb = new SorveteComCobertura(b);
         
            Console.WriteLine("Sorvete com cobertura E balinha:");            
            Console.WriteLine("{0:c}", cb.Preco);
            Console.ReadKey();        }    }
    
    //IComponent    
    interface ISorvete    
    {        
        //State        
        double Preco { get; }
    }
    
    //Component    
    sealed class Sorvete : ISorvete    
    {        
        //State        
        public double Preco        
        {            
            get            
            {                
                return 1.50;            
            }        
        }    
    }
    
    //Decorator    
    class SorveteComCobertura : ISorvete
    {        
        //Component : IComponent        
        ISorvete s;
        
        public SorveteComCobertura(ISorvete s)        
        {            
            this.s = s;        
        }
        
        //State        
        public double Preco        
        {            
            get            
            {                
                return this.s.Preco + 0.50;            
            }        
        }    
    }

    //Decorator    
    class SorveteComBalinha : ISorvete    
    {        
        //Component : IComponent        
        ISorvete s;
        
        public SorveteComBalinha(ISorvete s)        
        {            
            this.s = s;
        }
        
        //State        
        public double Preco        
        {            
            get            
            {                
                return this.s.Preco + 0.75;            
            }        
        }    
    }
}