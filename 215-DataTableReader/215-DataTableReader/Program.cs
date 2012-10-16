using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _215_DataTableReader
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("PESSOA");

            DataColumn dc = new DataColumn("CODIGO", typeof(int)) { AutoIncrement = true, AutoIncrementSeed = 1, AutoIncrementStep = 1, ReadOnly = true, Unique = true, AllowDBNull = false };
            dt.Columns.Add(dc);

            dt.Columns.Add(new DataColumn("NOME", typeof(String)));
            dt.Columns["NOME"].MaxLength = 50;

            DataRow dr = dt.NewRow();
            dr[1] = "ADÃO";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "EVA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "CAIM";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "ABEL";
            dt.Rows.Add(dr);

            DataTableReader dtr = dt.CreateDataReader();

            while (dtr.Read())
            {
                for (int i = 0; i < dtr.FieldCount; i++)
                {
                    //Console.WriteLine(dtr[i]);
                    Console.WriteLine(dtr.GetValue(i));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
