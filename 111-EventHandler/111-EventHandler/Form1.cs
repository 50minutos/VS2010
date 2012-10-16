using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _111_EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button b0 = new Button();
            b0.Size = this.button1.Size;
            b0.Location = new Point(this.button1.Location.X, 50);
            b0.Text = "clique aqui também";
            b0.Click += new EventHandler(this.TratarCliqueBotao);

            this.Controls.Add(b0);

            MyButton b1 = new MyButton();
            b1.Size = this.button1.Size;
            b1.Location = new Point(this.button1.Location.X, 100);
            b1.Text = "double click aqui";
            //b1.Click +=new EventHandler(this.TratarCliqueBotao);
            b1.DoubleClick += new EventHandler(this.TratarCliqueDuploBotao);

            this.Controls.Add(b1);
        }

        void TratarCliqueDuploBotao(object sender, EventArgs e)
        {
            MessageBox.Show("clique duplo");
        }

        private void TratarCliqueBotao(object sender, EventArgs e)
        {
            MessageBox.Show("clicou");
        }
    }
}
