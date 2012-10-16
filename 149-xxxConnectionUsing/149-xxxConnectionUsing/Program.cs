using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _149_xxxConnectionUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //String sc = @"Data Source=.\SQLEXPRESS;Initial Catalog=MASTER;Integrated Security=true";
            String sc = @"Data Source=.\SQLEXPRESS;Initial Catalog=MASTER;User=sa;Password=abc123@";

            using (SqlConnection c = new SqlConnection(sc))
            {
                c.Open();
            }

            Console.ReadKey();
        }
    }
}
