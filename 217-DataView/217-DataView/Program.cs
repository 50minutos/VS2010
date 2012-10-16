using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _217_DataView
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

            DataView dv1 = dt.DefaultView;

            DataView dv2 = new DataView(dt, "SEXO = 'M'","NOME", DataViewRowState.CurrentRows);

            DataView dv3 = new DataView(dt);
            dv3.RowFilter = "NOME LIKE 'A%'";

            MostrarDados(dt);

            MostrarDados(dv1.ToTable());
            MostrarDados(dv2.ToTable());
            MostrarDados(dv3.ToTable());

            Console.ReadKey();
        }

        private static void MostrarDados(DataTable dt)
        {
            Console.WriteLine(dt.TableName);

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    Console.Write("{0} ", linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
