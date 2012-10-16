using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;

namespace _156_xxxCommandExecuteXmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            String sc = "Data Source=.\\sqlexpress;Initial Catalog=vs2010;Integrated Security=true;";

            using (SqlConnection c = new SqlConnection(sc))
            {
                String cmd = "SELECT * FROM PESSOA FOR XML AUTO";

                using (SqlCommand k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    XmlReader xml = k.ExecuteXmlReader();
                    
                    while (xml.Read())
                    {
                        Console.WriteLine("{0} - {1} - {2}", xml["COD_PESSOA"], xml["NOME_PESSOA"], xml["SEXO_PESSOA"]);
                    }

                    Console.WriteLine();

                    Console.WriteLine(xml);

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
