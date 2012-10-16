using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _210_DataSetDataTableDataColumnDataRow
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("PESSOA");

            dt.Columns.Add("COD_PESSOA", typeof(int));

            dt.Columns.Add(new DataColumn("NOME_PESSOA", typeof(String)));

            DataColumn dc = new DataColumn();

            dc.ColumnName = "SEXO_PESSOA";
            dc.DataType = typeof(char);

            dt.Columns.Add(dc);

            DataSet ds = new DataSet("TABELAS");

            ds.Tables.Add(dt);

            DataRow dr = dt.NewRow();

            dr.SetField<int>("COD_PESSOA", 1);
            dr.SetField<String>(1, "ADÃO");
            dr[2] = 'M';

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "EVA";
            dr[2] = 'F';

            dt.Rows.Add(dr);

            Console.WriteLine("DataSet: {0}", ds.DataSetName);

            Console.WriteLine("Tabela: {0}", ds.Tables[0].TableName);

            Console.WriteLine();

            foreach (DataRow linha in ds.Tables[0].Rows)
            {
                foreach (DataColumn coluna in ds.Tables[0].Columns)
                {
                    Console.WriteLine("{0} -> {1}", coluna.ColumnName, linha[coluna]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
