using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace _213_DataSetDataTable
{
    /// <summary>
    /// classe que faz sei lá o que...
    /// </summary>
    class Program
    {
        /// <summary>
        /// método da classe...
        /// </summary>
        /// <param name="args">parâmetro do método</param>
        static void Main(string[] args)
        {
            DataSet ds = new DataSet("TABELAS");

            ds.ExtendedProperties["DATA_CRIACAO"] = DateTime.Now;
            ds.ExtendedProperties["EMPRESA"] = "50minutos";

            Console.WriteLine("Nome do DataSet: {0}\n", ds.DataSetName);

            foreach (DictionaryEntry item in ds.ExtendedProperties)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            DataTable dt = new DataTable("AGENDA");

            dt.Columns.Add("NOME", typeof(String));
            dt.Columns.Add("EMAIL", typeof(String));

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            Console.WriteLine("Nome do DataTable: {0}\n", dt.TableName);

            Console.Write("Coluna(s) da Tabela: ");

            foreach (DataColumn item in dt.Columns)
            {
                Console.Write("{0} ", item.ColumnName);
            }

            Console.Write("\n\nColuna(s) da PK: ");

            foreach (DataColumn item in dt.PrimaryKey)
            {
                Console.Write("{0} ", item.ColumnName);
            }

            DataRow dr = dt.NewRow();

            dr[0] = "agnaldo";
            dr[1] = "agnaldo@50minutos.com.br";

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = "agnaldo";
            dr[1] = "diabonaldo@gmail.com";

            //dt.Rows.Add(dr);
            //erro de PK

            Console.ReadKey();
        }
    }
}
