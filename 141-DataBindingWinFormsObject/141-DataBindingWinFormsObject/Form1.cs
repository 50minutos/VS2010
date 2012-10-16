using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _141_DataBindingWinFormsObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Livro[] livros = 
            { 
                new Livro(){Titulo="Advanced mouse clicator - entenda a diferença entre um duplo clique e dois cliques", Preco=98.22}, 
                new Livro(){Titulo="ABC do mouse", Preco=120.45}, 
                new Livro(){Titulo="Como programar: CTRL+C, CTRL+V sem mistério", Preco=111}, 
                new Livro(){Titulo="Com ser um drag-and-drop developer de sucesso", Preco=132.23}
            };

            var l = from livro in livros
                    orderby livro.Preco
                    select livro;

            dataGridView1.DataSource = l.ToList<Livro>();

            dataGridView1.Columns[0].Width = 450;
        }
    }
}
