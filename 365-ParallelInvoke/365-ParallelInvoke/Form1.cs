using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace _365_ParallelInvoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader arq = new StreamReader("Texto.txt");

            richTextBox1.Text = arq.ReadToEnd();

            arq.Close();

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] palavras = richTextBox1.Text.Split(
  new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/', '!' },
  StringSplitOptions.RemoveEmptyEntries);

            String[] down5 = null;

            String maiorPalavra = String.Empty;

            Parallel.Invoke
              (
                  () => { down5 = BuscarDown5(palavras); },
                  () => { maiorPalavra = BuscarMaiorPalavra(palavras); }
              );

            String down = String.Empty;

            foreach (var item in down5)
                down += item + " ";

            String msg = String.Format("maior palavra: {0}\npalavras que menos aparecem: {1}", maiorPalavra, down.Trim());

            MessageBox.Show(msg);
        }

        private String[] BuscarDown5(String[] palavras)
        {
            var lista = from p in palavras
                        group p by p into grupo
                        orderby grupo.Count()
                        select grupo.Key;

            return lista.Take(5).ToArray();
        }

        private String BuscarMaiorPalavra(String[] palavras)
        {
            return palavras.OrderByDescending(p => p.Length).First();
        }
    }
}
