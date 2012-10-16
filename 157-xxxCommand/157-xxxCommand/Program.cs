using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _157_xxxCommand
{
    class Program
    {
        static void Main(string[] args)
        {
             String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

             using (SqlConnection c = new SqlConnection(sc))
             {
                 String cmd = "USP_PESSOA_INS";

                 using (SqlCommand k = new SqlCommand(cmd, c))
                 {
                     k.CommandType = CommandType.StoredProcedure;

                     k.Parameters.AddWithValue("@COD_PESSOA", 5);
                     k.Parameters.AddWithValue("@NOME_PESSOA", "SERPENTE");
                     k.Parameters.AddWithValue("@SEXO_PESSOA", 'F');

                     c.Open();

                     k.ExecuteNonQuery();

                     c.Close();
                 }
             }

             Console.WriteLine("entrou");

             Console.ReadKey();
        }
    }
}

/*
CREATE PROC USP_PESSOA_INS
	@COD_PESSOA INT, 
	@NOME_PESSOA VARCHAR(50), 
	@SEXO_PESSOA CHAR(1)
AS
	SET NOCOUNT ON
	
	INSERT INTO PESSOA VALUES (@COD_PESSOA, @NOME_PESSOA, @SEXO_PESSOA)
GO
 */