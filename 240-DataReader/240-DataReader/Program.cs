using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Data;

namespace _240_DataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EntityConnection ec = new EntityConnection("name=VS2010Entities"))
            {
                ec.Open();

                String sql = "SELECT VALUE PESSOA FROM VS2010Entities.PESSOA";

                using (EntityCommand ek = ec.CreateCommand())
                {
                    ek.CommandText = sql;

                    using (EntityDataReader edr = ek.ExecuteReader(CommandBehavior.SequentialAccess))
                    {
                        while (edr.Read())
                        {
                            Console.WriteLine("{0} - {1} - {2}", edr["COD_PESSOA"], edr["NOME_PESSOA"], edr["SEXO_PESSOA"]);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
