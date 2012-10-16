using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace _155_xxxCommandExecuteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Provider=SQLNCLI10;Server=.\\sqlexpress;Database=vs2010;Trusted_Connection=yes;";

             using (OleDbConnection c = new OleDbConnection(sc))
             {
                 String cmd = "SELECT * FROM PESSOA";

                 using (OleDbCommand k = new OleDbCommand(cmd, c))
                 {
                     c.Open();

                     OleDbDataReader dr = k.ExecuteReader();

                     while (dr.Read())
                     {
                         Console.WriteLine("{0} -> {1} ({2})", dr["COD_PESSOA"], dr["NOME_PESSOA"], dr["SEXO_PESSOA"]);
                     }

                     c.Close();
                 }
             }

             Console.ReadKey();
        }
    }
}
