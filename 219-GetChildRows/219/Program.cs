using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _219
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet("TABELAS");

            DataTable dtp = new DataTable("PAI");

            DataColumn dc = new DataColumn("CODIGO", typeof(int)) { AutoIncrement = true, AutoIncrementSeed = 1, AutoIncrementStep = 1, ReadOnly = true, Unique = true, AllowDBNull = false };
            dtp.Columns.Add(dc);

            dtp.Columns.Add(new DataColumn("NOME", typeof(String)));
            dtp.Columns["NOME"].MaxLength = 50;

            DataTable dtf = new DataTable("FILHO");

            dc = new DataColumn("CODIGO", typeof(int)) { AutoIncrement = true, AutoIncrementSeed = 1, AutoIncrementStep = 1, ReadOnly = true, Unique = true, AllowDBNull = false };
            dtf.Columns.Add(dc);

            dtf.Columns.Add(new DataColumn("NOME", typeof(String)));
            dtf.Columns["NOME"].MaxLength = 50;

            dtf.Columns.Add(new DataColumn("CODIGO_PAI", typeof(int)));

            ds.Tables.Add(dtp);
            ds.Tables.Add(dtf);

            DataRelation dr = new DataRelation("PAIS_FILHOS", ds.Tables["PAI"].Columns["CODIGO"], ds.Tables["FILHO"].Columns["CODIGO_PAI"]);

            ds.Relations.Clear();

            ds.Relations.Add(dr);

            DataRow row = dtp.NewRow();
            row[1] = "ADÃO";
            dtp.Rows.Add(row);

            row = dtp.NewRow();
            row[1] = "AGNALDO";
            dtp.Rows.Add(row);

            row = dtf.NewRow();
            row[1] = "CAIM";
            row[2] = 1;
            dtf.Rows.Add(row);

            row = dtf.NewRow();
            row[1] = "ABEL";
            row[2] = 1;
            dtf.Rows.Add(row);

            row = dtf.NewRow();
            row[1] = "BRUNO";
            row[2] = 2;
            dtf.Rows.Add(row);

            row = dtf.NewRow();
            row[1] = "NETINHO";
            row[2] = 2;
            dtf.Rows.Add(row);

            row = dtf.NewRow();
            row[1] = "PEDRO";
            row[2] = 2;
            dtf.Rows.Add(row);

            MostrarDados(dtp);
            MostrarDados(dtf);

            DataRow adao = ds.Tables["PAI"].Rows[0];

            DataRow[] linhas = adao.GetChildRows("PAIS_FILHOS");

            MostrarDados(linhas);

            Console.ReadKey();
        }

        private static void MostrarDados(DataRow[] linhas)
        {
            Console.WriteLine("Filhos do {0}", linhas[0].GetParentRow("PAIS_FILHOS")["NOME"]);

            foreach (DataRow linha in linhas)
            {
                foreach (var dado in linha.ItemArray)
                {
                    Console.Write("{0} ", dado);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
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