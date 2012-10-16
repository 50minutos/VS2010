using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _160_xxxCommandProcSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "USP_SWAP";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    k.Parameters[0].Direction = ParameterDirection.InputOutput;
                    k.Parameters[1].Direction = ParameterDirection.InputOutput;

                    c.Open();

                    k.ExecuteNonQuery();

                    Console.WriteLine("{0} e {1}", k.Parameters["@X"].Value, k.Parameters["@Y"].Value);

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}

/*
CREATE PROC USP_SWAP
	@X INT OUTPUT, 
	@Y INT OUTPUT
AS
	DECLARE @TMP INT = @X
	SET @X = @Y
	SET @Y = @TMP
GO

--TESTE

DECLARE @A INT = 1
DECLARE @B INT = 2
SELECT 'ANTES' AS 'QUANDO', @A AS '@A', @B AS '@B'
EXEC USP_SWAP @A OUTPUT, @B OUTPUT
SELECT 'DEPOIS' AS 'QUANDO', @A AS '@A', @B AS '@B'
 */