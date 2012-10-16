using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _150_xxxConnectionStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            
            csb.DataSource = @"ze\sqlexpress"; //servidor errado para dar erro!!!
            csb.InitialCatalog = "MASTER";
            csb.IntegratedSecurity = true;
            csb.ConnectTimeout = 3;
            csb.Pooling = false;

            Console.WriteLine(csb.ConnectionString);

            using (SqlConnection c = new SqlConnection(csb.ConnectionString))
            {
                c.Open();
            }

            //Console.ReadKey();
        }
    }
}
