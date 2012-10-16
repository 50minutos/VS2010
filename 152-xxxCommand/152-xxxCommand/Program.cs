using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _152_xxxCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=MASTER;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "CREATE DATABASE VS2010";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    //SqlCommand faz parte do modelo CONECTADO
                    //ExecuteNonQuery retorna o número de linhas afetadas

                    c.Open();

                    k.ExecuteNonQuery();

                    c.ChangeDatabase("VS2010");

                    k.CommandText = "CREATE TABLE PESSOA (COD_PESSOA INT, NOME_PESSOA VARCHAR(50), SEXO_PESSOA CHAR(1))";

                    k.ExecuteNonQuery();

                    c.Close();
                }
            }

            Console.WriteLine("funcionou");

            Console.ReadKey();
        }
    }
}
