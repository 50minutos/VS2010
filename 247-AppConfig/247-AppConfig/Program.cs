using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace _247_AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettingsReader leitor = new AppSettingsReader();
            
            Console.WriteLine("nome: {0}", leitor.GetValue("nome", typeof(String)));
            Console.WriteLine("e-mail: {0}", leitor.GetValue("email", typeof(String)));

            System.Console.WriteLine(Properties.Settings.Default.varAplicacao);
            Properties.Settings.Default.varUsuario = "outro valor";
            System.Console.WriteLine(Properties.Settings.Default.varUsuario);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
