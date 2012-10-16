using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _159_xxxCommandProcOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "USP_SOMA_OUTPUT";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    SqlParameter p = new SqlParameter("@SOMA", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;

                    k.Parameters.Add(p);

                    c.Open();

                    k.ExecuteNonQuery();

                    Console.WriteLine(k.Parameters["@SOMA"].Value);
                    Console.WriteLine(p.Value);

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}

/*
CREATE PROC USP_SOMA_OUTPUT
	@X INT, 
	@Y INT, 
	@SOMA INT OUTPUT
AS
	SET NOCOUNT ON
	
	SET @SOMA = @X + @Y
GO

--TESTE

DECLARE @S INT
EXEC USP_SOMA_OUTPUT 10, 20, @S OUTPUT
SELECT @S
*/