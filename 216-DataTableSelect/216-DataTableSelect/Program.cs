using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _216_DataTableSelect
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

            dt.Columns.Add(new DataColumn("SEXO", typeof(char)));

            DataRow dr = dt.NewRow();
            dr[1] = "ADÃO";
            dr[2] = 'M';
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "EVA";
            dr[2] = 'F';
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "CAIM";
            dr[2] = 'M';
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[1] = "ABEL";
            dr[2] = 'M';
            dt.Rows.Add(dr);

            DataRow[] linhas = dt.Select("SEXO <> 'M'");

            foreach (DataRow item in linhas)
            {
                Console.WriteLine(item["NOME"]);
            }

            Console.ReadKey();
        }
    }
}
