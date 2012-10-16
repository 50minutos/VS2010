using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Collections;

namespace _176_SerializacaoXMLColecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto() { codigo = 1, nome = "martelo", Preco = 10.10 };
            Produto p2 = new Produto() { codigo = 2, nome = "serrote", Preco = 20.20 };
            Produto p3 = new Produto() { codigo = 3, nome = "facão", Preco = 30.30 };

            #region opcao com System.Collections.ArrayList

            //ArrayList lista = new ArrayList() { p1, p2, p3 };
            //Type[] tipos = { typeof(Produto) };

            //XmlSerializer x = new XmlSerializer(typeof(ArrayList), tipos);
            //ArrayList precisa de um array com o tipo do seu conteúdo e ele deve ser passado como segundo argumento no construtor do XmlSerializer

            #endregion

            #region opcao com System.Collections.Generic.List<Produto>

            List<Produto> lista = new List<Produto>() { p1, p2, p3 };
            
            XmlSerializer x = new XmlSerializer(typeof(List<Produto>));

            #endregion

            FileStream fs = new FileStream("saida.xml", FileMode.Create, FileAccess.Write);
           
            x.Serialize(fs, lista);
            
            fs.Close();

            Process.Start("saida.xml");
        }
    }

    public class Produto
    {
        public int codigo;
        public String nome;

        public double Preco { get; set; }
    }
}
