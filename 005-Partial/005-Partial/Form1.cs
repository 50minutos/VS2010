﻿using System;
using System.Windows.Forms;

namespace _005_Partial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mbox, TAB, TAB
            MessageBox.Show("Opa... finalmente um Hello World!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicou no botão!!!");
        }
    }
}
