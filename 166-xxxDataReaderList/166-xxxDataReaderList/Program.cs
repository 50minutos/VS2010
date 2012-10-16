using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _166_xxxDataReaderList
{
    class Program
    {
        static void Main(string[] args)
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

                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();
            }
        }
    }

    class Pessoa
    {
        public int CodPessoa { get; set; } //COD_PESSOA
        public String NomePessoa { get; set; } //NOME_PESSOA
        public char SexoPessoa { get; set; }//SEXO_PESSOA

        public Pessoa(int codPessoa, String nomePessoa, char sexoPessoa)
        {
            this.CodPessoa = codPessoa;
            this.NomePessoa = nomePessoa;
            this.SexoPessoa = sexoPessoa;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.CodPessoa, this.NomePessoa, this.SexoPessoa);
        }
    }
}
