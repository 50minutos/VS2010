using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _209_MultiplosResultSets
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection c = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=VS2010;Integrated Security=True"))
            {
                SqlCommand k = new SqlCommand("SELECT * FROM PESSOA;SELECT COD_PESSOA, NOME_PESSOA FROM PESSOA;SELECT COUNT(*) AS 'QTD' FROM PESSOA", c);

                c.Open();

                SqlDataReader dr = k.ExecuteReader();

                do
                {
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            Console.WriteLine("{0}\t{1}", dr.GetName(i), dr[i]);
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine("-------------------------\n");
                }
                while (dr.NextResult());

                c.Close();

                Console.ReadKey();
            }
        }
    }
}
