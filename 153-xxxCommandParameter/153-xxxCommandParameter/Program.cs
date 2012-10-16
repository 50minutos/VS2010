using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _153_xxxCommandParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                int codPessoa = 1;
                String nomePessoa = "Adão";
                String sexoPessoa = "M";

                //ABERTO AO sql injection
                //String sexoPessoa = "M');drop table pessoa;--";
                //String cmd = "INSERT INTO PESSOA VALUES (" + codPessoa.ToString() + ", '" + nomePessoa + "', '" + sexoPessoa + "')";

                String cmd = "INSERT INTO PESSOA VALUES (@COD_PESSOA, @NOME_PESSOA, @SEXO_PESSOA)";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    k.Parameters.AddWithValue("@COD_PESSOA", codPessoa);
                    k.Parameters.AddWithValue("@NOME_PESSOA", nomePessoa);
                    k.Parameters.AddWithValue("@SEXO_PESSOA", sexoPessoa);

                    c.Open();

                    k.ExecuteNonQuery();

                    c.Close();
                }

                Console.WriteLine("inseri o registro");

                Console.ReadKey();
            }
        }
    }
}
