using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _105_LeituraArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] linhas = null;

            using (StreamReader arqLeitura = new StreamReader("arquivo.txt"))
            {
                linhas = arqLeitura.ReadToEnd().Split('\n');
            }

            int linha = 0;

            foreach (var item in linhas)
            {
                if (item.Substring(0, 2).Equals("01"))
                {
                    Pai p = new Pai(item);
                    Escrever(p, ++linha);
                }
                else
                {
                    Filho f = new Filho(item);
                    Escrever(f, linha);
                }
            }

            Process.Start("dados.txt");
        }

        private static void Escrever<T>(T t, int linha)
        {
            using (StreamWriter arqEscrita = new StreamWriter("dados.txt", true, Encoding.UTF8))
            {
                String tmp = "000000" + linha.ToString();
                
                if (t is Filho)
                    tmp = "      ";

                arqEscrita.WriteLine("{0} {1}", tmp.Substring(tmp.Length - 6), t);
            }
        }
    }

    class Pai
    {
        public const char SEPARADOR = ';';
        
        public int ID { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }
        
        public Pai()
        {

        }

        public Pai(String txt)
        {
            this.ID = Convert.ToInt32(txt.Substring(0, 2));
            this.Nome = txt.Substring(2, 20).Trim();
            this.Sexo = txt[22];
        }

        public override string ToString()
        {
            return String.Format("{1}{0}{2}{0}{3}", Pai.SEPARADOR, this.ID, this.Nome, this.Sexo);
        }
    }

    class Filho : Pai
    {
        public int Idade { get; set; }

        public Filho(String txt)
        {
            this.ID = Convert.ToInt32(txt.Substring(0, 2));
            this.Nome = txt.Substring(2, 10).Trim();
            this.Idade = Convert.ToInt32(txt.Substring(12, 2));
            this.Sexo = txt[14];
        }
        public override string ToString()
        {
            return String.Format("{1}{0}{2}{0}{3}{0}{4}", Filho.SEPARADOR, this.ID, this.Nome, this.Idade, this.Sexo);
        }
    }
}
