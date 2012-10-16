using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _163_DataSet
{
    public partial class Form1 : Form
    {
        DataSet ds;
        String fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "arquivos de cadastro|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;

                ds = new DataSet();
                ds.ReadXml(fileName);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "arquivos de cadastro|*.xml";

            sfd.FileName = fileName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ds.WriteXml(sfd.FileName);
                MessageBox.Show("Salvei a bagaça");
            }
        }
    }
}
