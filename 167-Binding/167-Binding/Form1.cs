using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _167_Binding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Pessoa> lista = new List<Pessoa>();

                using (SqlConnection c = new SqlConnection())
                {
                    c.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VS2010;Integrated Security=true;";

                    SqlCommand k = new SqlCommand("SELECT * FROM PESSOA", c);

                    c.Open();
                    SqlDataReader dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Pessoa(Convert.ToInt32(dr["COD_PESSOA"]), dr["NOME_PESSOA"].ToString(), dr["SEXO_PESSOA"].ToString()[0]));
                    }

                    c.Close();

                    comboBox1.DataSource = lista;
                    comboBox1.DisplayMember = "NomePessoa";
                    comboBox1.ValueMember = "CodPessoa";

                    comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString(), ((Pessoa)comboBox1.SelectedItem).NomePessoa);
        }
    }

    class Pessoa
    {
        public int CodPessoa { get; set; }
        public String NomePessoa { get; set; }
        public char SexoPessoa { get; set; }

        public Pessoa(int c, String n, char s)
        {
            this.CodPessoa = c;
            this.NomePessoa = n;
            this.SexoPessoa = s;
        }
    }
}