using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _211_RowState
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("PRODUTO");

            dt.Columns.Add("CODIGO", typeof(int));
            dt.Columns.Add("DESCRICAO", typeof(String));

            DataRow dr = dt.NewRow();

            Console.WriteLine("Depois do dt.NewRow - {0}", dr.RowState);

            dr[0] = 1;
            dr[1] = "MARTELO";

            dt.Rows.Add(dr);

            Console.WriteLine("Depois do dt.Rows.Add - {0}", dr.RowState);

            dt.AcceptChanges();

            Console.WriteLine("Depois do dt.AcceptChanges - {0}", dr.RowState);

            dr["DESCRICAO"] = "MARTELO DE ORELHA";

            Console.WriteLine("Depois da alteração de conteúdo - {0}", dr.RowState);

            foreach (DataRow linha in dt.Rows)
            {
                foreach (DataColumn coluna in dt.Columns)
                {
                    Console.WriteLine("   {0}", linha[coluna]);
                }
            }

            dt.Rows[0].Delete();

            Console.WriteLine("Depois do dt.Rows[0].Delete - {0}", dr.RowState);

            Console.ReadKey();
        }
    }
}
