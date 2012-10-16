using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _148_xxxConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = @"Data Source=.\SQLEXPRESS;Initial Catalog=MASTER;Integrated Security=true";
            
            SqlConnection c = new SqlConnection(sc);

            Console.WriteLine(c.State);
            
            c.Open();
            
            Console.WriteLine(c.State);
            
            c.Close();
            
            Console.WriteLine(c.State);

            Console.ReadKey();
        }
    }
}
