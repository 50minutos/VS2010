using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TesteWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyUsuario.UsuarioClient uc = new ProxyUsuario.UsuarioClient();

            ProxyUsuario.UsuarioModel usuario = new ProxyUsuario.UsuarioModel()
            {
                CodUsuario = 1,
                NomeUsuario = "ADMIN",
                PwdUsuario = "ADMIN",
                AdmUsuario = 'S'
            };

            uc.Inserir(usuario);

            //uc.Alterar(usuario);
            
            //uc.Excluir(usuario);
            
            //Console.WriteLine(uc.ConsultarCodUsuario(usuario).NomeUsuario);

            //usuario = uc.Logar(usuario);

            //if (usuario != null)
            //    Console.WriteLine(usuario.NomeUsuario);
            //else
            //    Console.WriteLine("não logou");

            //ProxyRelatorio.RelatorioClient rc = new ProxyRelatorio.RelatorioClient();

            //DataSet ds = new DataSet();

            //ds = rc.ObterDadosRelatorioA();

            //Console.WriteLine(ds.Tables[0].Rows[0][1]);

            Console.WriteLine("foi");

            Console.ReadKey();
        }
    }
}
