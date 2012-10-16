using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _165_xxxDataAdapter
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sc = @"Data Source=.\sqlexpress;Initial Catalog=VS2010;Integrated Security=true;";
            
            String cmd = "SELECT * FROM PESSOA";

            da = new SqlDataAdapter(cmd, sc);

            ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(da);
            
            da.Update(ds);
            
            MessageBox.Show("FOI");
        }
    }
}

/*
--A PARTIR DAQUI AS PROCEDURES DOS OUTROS EXEMPLOS NÃO FUNCIONARÃO
USE VS2010

DROP TABLE PESSOA

CREATE TABLE PESSOA
(
	COD_PESSOA int PRIMARY KEY IDENTITY,
	NOME_PESSOA varchar(50) NULL,
	SEXO_PESSOA char(1) NULL
)

INSERT INTO PESSOA VALUES ('ADÃO', 'M')
INSERT INTO PESSOA VALUES ('CAIM', 'M')
INSERT INTO PESSOA VALUES ('ABEL', 'M')
INSERT INTO PESSOA VALUES ('EVA', 'F')
INSERT INTO PESSOA VALUES ('COBRA', 'F')
*/