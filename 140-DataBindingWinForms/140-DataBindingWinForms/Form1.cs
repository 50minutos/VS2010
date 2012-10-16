using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _140_DataBindingWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] palestrantes = { 
                "Alexandre Lopes", 
                "Vitor Fava", 
                "Marcelo Sincic", 
                "Laerte Jr", 
                "Roberto Fonseca", 
                "Thiago Zavaschi", 
                "Agnaldo Diogo dos Santos"
                };

            var p = from palestrante in palestrantes
                    orderby palestrante
                    select new { palestrante };

            dataGridView1.DataSource = p.ToList();
            dataGridView1.Columns[0].Width = 300;
        }
    }
}
