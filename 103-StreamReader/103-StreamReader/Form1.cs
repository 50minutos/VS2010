using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _103_StreamReader
{
    public partial class Form1 : Form
    {
        private String arquivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscolherArquivo();

            if(arquivo != null)
                LerArquivo();
        }

        private void EscolherArquivo()
        {
            if (arquivo == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "arquivos xml|*.config";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    arquivo = ofd.FileName;
                }
            }
        }

        private void LerArquivo()
        {
            Encoding encoding = Encoding.BigEndianUnicode;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "ASCII": encoding = Encoding.ASCII; break;
                case "Default": encoding = Encoding.Default; break;
                case "UTF7": encoding = Encoding.UTF7; break;
                case "UTF8": encoding = Encoding.UTF8; break;
                case "UTF32": encoding = Encoding.UTF32; break;
                case "Unicode": encoding = Encoding.Unicode; break;
            }

            using (StreamReader sr = new StreamReader(arquivo, encoding))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0 && arquivo != null)
            {
                LerArquivo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String novoNome = String.Format("{0}{1}.{2}", arquivo.Substring(0, arquivo.Length - 6), comboBox1.SelectedItem.ToString(), arquivo.Substring(arquivo.Length-6));

            File.Copy(arquivo, novoNome);
            File.Delete(arquivo);

            MessageBox.Show("Foi");
        }
    }
}
