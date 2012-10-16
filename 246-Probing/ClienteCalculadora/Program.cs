using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace ClienteCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.Somar(10, 3));
            Console.WriteLine(new Calculadora().Subtrair(10, 3));

            Console.ReadKey();
        }
    }
}

//CRIAR PASTA DLLS
//MOVER DLL PARA LÁ

//APP.CONFIG:
//<?xml version="1.0" encoding="utf-8" ?>
//<configuration>
//  <runtime>
//    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
//      <probing privatePath="DLLS;"/>
//    </assemblyBinding>
//  </runtime>
//</configuration>