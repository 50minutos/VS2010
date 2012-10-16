using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _158_xxxCommandProcReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "USP_SOMA_RETURN";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    SqlParameter p = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                    p.Direction = ParameterDirection.ReturnValue;

                    k.Parameters.Add(p);

                    c.Open();
                    
                    k.ExecuteNonQuery();

                    Console.WriteLine(k.Parameters["@RETURN_VALUE"].Value);
                    Console.WriteLine(p.Value);

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}

/*
CREATE PROC USP_SOMA_RETURN
	@X INT, 
	@Y INT
AS
	SET NOCOUNT ON
	
	RETURN @X + @Y
GO 
 */