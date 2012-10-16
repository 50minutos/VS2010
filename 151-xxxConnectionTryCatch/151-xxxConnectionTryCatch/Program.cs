using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _151_xxxConnectionTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = @"Data Source=.\sqlexpress;Initial Catalog=MASTER;Integrated Security=true;Connect Timeout=1;Pooling=false";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(sc);

                c.Open();
                c.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                if (/*c != null &&*/ c.State != ConnectionState.Closed)
                    c.Close();

                Console.ReadKey();
            }
        }
    }
}
