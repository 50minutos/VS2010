using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _214_DataColumn
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
            //dr[1] = "ADÃO-----------------------------------------------------------------------------------------------------------";
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

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    Console.WriteLine(linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
