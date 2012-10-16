using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _220_DataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pESSOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PESSOA' table. You can move, or remove it, as needed.
            this.pESSOATableAdapter.Fill(this.dataSet1.PESSOA);
            // TODO: This line of code loads data into the 'dataSet1.PESSOA' table. You can move, or remove it, as needed.
            this.pESSOATableAdapter.Fill(this.dataSet1.PESSOA);

        }

        private void pESSOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
