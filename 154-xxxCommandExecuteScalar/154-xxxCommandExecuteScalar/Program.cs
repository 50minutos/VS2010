using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _154_xxxCommandExecuteScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                //String cmd = "SELECT GETDATE()";
                String cmd = "SELECT COUNT(*) FROM PESSOA";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    //o retorno de ExecuteScalar é Object

                    //DateTime d = Convert.ToDateTime(k.ExecuteScalar());
                    int qtd = Convert.ToInt32(k.ExecuteScalar());

                    c.Close();

                    //Console.WriteLine(d);
                    Console.WriteLine(qtd);
                }

                Console.ReadKey();
            }
        }
    }
}
